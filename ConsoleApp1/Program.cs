using System;

class Program
{
    static void Main()
    {
        Mascota[] mascotas = new Mascota[100];
        int mascotaCount = 0;
        string seguir = "";

        do
        {
            Console.WriteLine("--- Menú Veterinaria ---");
            Console.WriteLine("1. Crear Servicio");
            Console.WriteLine("2. Eliminar Servicio");
            Console.WriteLine("3. Listar Servicios");
            Console.WriteLine("4. Crear Mascota");
            Console.WriteLine("5. Eliminar Mascota");
            Console.WriteLine("6. Listar Mascotas");
            Console.Write("Seleccione una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 4:
                    Mascota.CrearMascota(mascotas, ref mascotaCount);
                    break;

                case 5:
                    Mascota.EliminarMascota(mascotas, ref mascotaCount);
                    break;

                case 6:
                    Mascota.ListarMascotas(mascotas, mascotaCount);
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

            Console.WriteLine("¿Regresar al menú? [si/no]");
            seguir = Console.ReadLine().ToLower();
            Console.Clear();
        }
        while (seguir == "si");
    }
}
