using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Final_Servidor
{
    class ServicioCliente
    {
        static ServicioCliente instancia;
        private ServicioCliente()
        {

        }
        public static ServicioCliente getInstancia()
        {
            if (instancia == null)
            {
                instancia = new ServicioCliente();
            }
            return instancia;
        }
        public double Calcularoperacion(String nombre, string sexo, int edad, double peso, double altura)
        {
            string cadena = nombre + "," + sexo.ToString() + "," + edad.ToString() + "," + peso.ToString() + altura.ToString() + ",";
            // Declara un bufer de  datos para recibir datos .  
            byte[] bytes = new byte[1024];

            // Se conecta al dispositivo remoto .  
            try
            {
                // Establece un punto remoto final para el socket.  
                // Este ejemplo usa el puerto 11000 en la computadora local.  
                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddress = ipHostInfo.AddressList[0];
                //               IPEndPopPnt remoteEP = new IPEndPoint(ipAddrPAdress.Paress, 11000);

                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 11000);

                // Crear un socket TCP/IP  .  
                Socket sender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                // Conetarse al punto final remoto  captura cualquier error .  
                try
                {
                    sender.Connect(remoteEP);

                    sender.RemoteEndPoint.ToString();

                    // codifica datos en un string dentro de un arreglo de bits. 

                    byte[] msg = Encoding.ASCII.GetBytes(cadena);

                    // Envia datos a traves del socket .  
                    int bytesSent = sender.Send(msg);

                    // Recibe ladespuesta desde el dispositivo remoto .  
                    int bytesRec = sender.Receive(bytes);
                    string respuesta = (Encoding.ASCII.GetString(bytes, 0, bytesRec));
                    // libera el socket.  
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();

                    return double.Parse(respuesta);
                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error no manejado  : {0}", e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return 0;
        }
    }
}
