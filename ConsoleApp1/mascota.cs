public class Mascota
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Especie { get; set; }

    public Mascota(string nombre, int edad, string especie)
    {
        Nombre = nombre;
        Edad = edad;
        Especie = especie;
    }

   
    public static void CrearMascota(Mascota[] mascotas, ref int mascotaCount)
    {
        Console.Write("Ingrese el nombre de la mascota: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese la edad de la mascota: ");
        int edad = int.Parse(Console.ReadLine());

        Console.Write("Ingrese la especie de la mascota: ");
        string especie = Console.ReadLine();

        mascotas[mascotaCount] = new Mascota(nombre, edad, especie);
        mascotaCount++;
        Console.WriteLine("Mascota agregada exitosamente.");
    }

    
    public static void EliminarMascota(Mascota[] mascotas, ref int mascotaCount)
    {
        Console.Write("Ingrese el número de la mascota a eliminar: ");
        int indice = int.Parse(Console.ReadLine());

        if (indice >= 0 && indice < mascotaCount)
        {
            for (int i = indice; i < mascotaCount - 1; i++)
            {
                mascotas[i] = mascotas[i + 1];
            }

            mascotas[mascotaCount - 1] = null;
            mascotaCount--;
            Console.WriteLine("Mascota eliminada.");
        }
        else
        {
            Console.WriteLine("Índice inválido.");
        }
    }

    
    public static void ListarMascotas(Mascota[] mascotas, int mascotaCount)
    {
        Console.WriteLine("\n--- Lista de Mascotas ---");
        for (int i = 0; i < mascotaCount; i++)
        {
            Console.WriteLine($"{i}. {mascotas[i].Nombre}, {mascotas[i].Edad} años, {mascotas[i].Especie}");
        }
    }
}