using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*if (args.Length == 0)
            {
                System.Console.WriteLine("Por favor ingresar los dos parametros: interface [loggin]");
                return;
            }*/

            Console.WriteLine("Introduzca un texto");
            String fecha = Console.ReadLine();

            /* System.Console.WriteLine("Interface: " + args[0]);
            System.Console.WriteLine("Fecha: " + args[1]);
            System.Console.WriteLine("Logging: " + args[2]); 

            String fecha = args[1]; */

            HttpWebRequest request = WebRequest.Create("http://localhost:8080/OSDEPYM/obtenerClientes?fecha=" + fecha) as HttpWebRequest;
            request.Method = "GET";
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string body = reader.ReadToEnd();

            System.Console.WriteLine("Datos recibidos: " + body);
            /* Autenticacion */
            /* string credentials = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes("usuario:clave"));
            request.Headers.Add("Authorization", "Basic " + credentials);*/

        }
    }
}
