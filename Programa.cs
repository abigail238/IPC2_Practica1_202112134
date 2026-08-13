
using System;

using System.Collections.Generic;
using System.Security.AccessControl;

public class programa
{
    static List<Mascota> mascotas= new List<Mascota>();

    public static void Main (string[] args)
    {
        int opcion = 0;

        while (opcion !=5)
        {
            Console.WriteLine();
            Console.WriteLine("===Veterinari===");
            Console.WriteLine("1. Registrar mascota");
            Console.WriteLine("2. Mostrar mascota");
            Console.WriteLine("3. Cambiar estado");
            Console.WriteLine("4. Calcular dosis");
             Console.WriteLine("5. salir");

            Console.WriteLine("Seleccione una opacion: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                
            }

        }

    }
}