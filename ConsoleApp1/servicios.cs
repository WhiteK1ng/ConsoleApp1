using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Servicio
    {
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public static void CrearServicio(Servicio[] servicios, int count)
        {
            string continuar = "";
            do
            {
                Console.Write("Ingrese el servicio: ");
                string descripcion = Console.ReadLine();
                Console.Write("Ingrese el precio del servicio: ");
                decimal precio = decimal.Parse(Console.ReadLine());

                servicios[count] = new Servicio { Descripcion = descripcion, Precio = precio };
                count++;
                Console.WriteLine("Servicio agregado exitosamente.");
                Console.WriteLine("Deseas seguir solicitando mas servicios?[si/no]");
                continuar = Console.ReadLine();
            } while (continuar == "si");
        }
        public static void EliminarServicio(Servicio[] servicios, int count)
        {
            Console.Write("Ingrese servicio a eliminar: ");
            int indice = int.Parse(Console.ReadLine());
            if (indice > 0)
            {
                for (int i = indice; i < count - 1; i++)
                {
                    servicios[i] = servicios[i + 1];
                }
                servicios[count - 1] = null;
                count--;
                Console.WriteLine("Servicio eliminado.");
            }
        }
        public static void ListarServicios(Servicio[] servicios, int count)
        {
            Console.WriteLine("--- Lista de Servicios ---");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}. {servicios[i].Descripcion} - S/ {servicios[i].Precio}");
            }
        }
    }
}