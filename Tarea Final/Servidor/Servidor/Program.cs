using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Servidor
{
    class Program
    {
        // Datos Recibidos Desde ElCliente.  
        public static string data = null;

        public static void StartListening()
        {
            // Bufer de Datos paralosdatos recibidos  
            byte[] bytes = new Byte[1024];

            // Establece el punto deentrada final para el socket.  
            // Dns.GetHostName devuelve el nombre del host donde correr la aplicacion
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];

            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, 11000);

            // Crea un Socket TCP/IP x.  
            Socket listener = new Socket(IPAddress.Any.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);


            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);

                // Inicia a escuchas miestras llegan conexiones.  
                while (true)
                {
                    Console.WriteLine("Esperando por ceonexiones ...");
                    // el Programa es suspendido mientras espera oconexiones de entrada .  
                    Socket handler = listener.Accept();
                    data = null;

                    // La conexion de entrada necesita ser procesada.  
                    while (true)
                    {
                        int bytesRec = handler.Receive(bytes);
                        data += Encoding.ASCII.GetString(bytes, 0, bytesRec);

                    }

                    // Muestra los datos en la consola .  
                    Console.WriteLine("Texto recibido: {0}", data);
                    string[] mensajedescompuestos = data.Split(',');
                    string operacion = mensajedescompuestos[0];
                    double a = double.Parse(mensajedescompuestos[1]);
                    double b = double.Parse(mensajedescompuestos[2]);
                    double c = 0;
                    switch(operacion)
                    {
                        case "suma":
                            c = Aritmetica.getInstancia().sumar(a, b);
                            break;
                        case "resta":
                            c = Aritmetica.getInstancia().restar(a, b);
                            break;
                        case "multiplicación":
                            c = Aritmetica.getInstancia().multiplicar(a, b);
                            break;
                        case "división":
                            c = Aritmetica.getInstancia().dividir(a, b);
                            break;
                        case "raíz":
                            c = Aritmetica.getInstancia().raiz(a, b);
                            break;
                        case "potencia":
                            c = Aritmetica.getInstancia().potencia(a, b);
                            break;
                        default:
                            c = -1;
                            break;
                    }

                    // Prepara los datos para responder  al cliente.  
                    byte[] msg = Encoding.ASCII.GetBytes(c.ToString());

                    handler.Send(msg);
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\nPresiones ENTER para continuar...");
            Console.Read();
        }
        public static int Main(String[] args)
        {
            StartListening();
            return 0;
        }
    }
}
