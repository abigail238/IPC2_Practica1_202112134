
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;


public class programa
{
    static Mascota[] mascotas = new Mascota[100];

    // contador del vector mascota 
    static int cantidadMascotas = 0;

    public static void Main(string[] args)
    {
        int opcion = 0;

        while (opcion != 5)
        {
            Console.WriteLine();
            Console.WriteLine("===Veterinaria===");
            Console.WriteLine("1. Registrar mascota");
            Console.WriteLine("2. Mostrar mascota");
            Console.WriteLine("3. Cambiar estado");
            Console.WriteLine("4. Calcular dosis");
            Console.WriteLine("5. salir");

            Console.WriteLine("Seleccione una opacion: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    RegistrarMascota();
                    break;

                case 2:
                    MostraMascota();
                    break;

                case 3:
                    CambiarEstado();
                    break;

                case 4:
                    Console.WriteLine("Calcular dosis");
                    break;

                case 5:
                    Console.WriteLine("Saliendo del programas...");
                    break;

                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }
    }

    static void RegistrarMascota()
    {
       

    Console.WriteLine();
                Console.WriteLine("Registrar Mascota");
                Console.WriteLine("1. Perro");
                Console.WriteLine("2. Gato");
                Console.WriteLine("3. Ave");
                Console.WriteLine("4. Tortuga");

                Console.Write("Seleccion el tipo de mascota: ");
                int tipo = int.Parse(Console.ReadLine());

    Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

    Console.Write("Peso en Kg: ");
                double peso = double.Parse(Console.ReadLine());

    Console.Write("Sexo: ");
                string sexo = Console.ReadLine();

    Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());

    Console.Write("Propietario: ");
                string propietario = Console.ReadLine();

        switch (tipo)
        {
            case 1 :
            Console.Write("Raza: ");
            string raza = Console.ReadLine();

    Console.Write("Tamaño: ");
            string tamanio = Console.WriteLine();

    //aqui estamos llamando al cosntructor perro 

    Perro perro = new Perro(nombre, peso, sexo, edad, propietario, raza, tamanio);

    mascotas[cantidadMascotas] = perro;
            cantidadMascotas++;

            Console.WriteLine("Perro registrado correctamente.");
            Console.WriteLine("Codigo: " + perro.codigo);

            break;

            case 2: 
            Console.Write("Raza : ");
            string razaGato = Console.ReadLine();

    Console.Write("Esta esterilizado? (s/n): ");
            string respuesta = Console.ReadLine();

    bool esterilizado = respuesta.ToLower() == "s";

    Gato gato = new Gato(nombre, peso, sexo, edad, propietario, razaGato, esterilizado);

    mascotas[cantidadMascotas] = gato;
            cantidadMascotas ++;

            Console.WriteLine("Gato registrado correctamente.");
            Console.WriteLine("codigo: " + gato,codigo);
            break;

            case 3: 

            Console.Write("Envergadura de alas: ");
            double envergadura = double.Parse(Console.ReadLine());

    Console.Write("Puede volar? (S/N)");
            String respuestaAve = Console.ReadLine();

    bool puedevolar = respuestaAve.ToLower() == "s";

    Ave ave = new Ave(nombre, peso, sexo, edad, propietario, envergadura, puedevolar);

    mascotas[cantidadMascotas] = ave;
            cantidadMascotas++;

            case 4:
            Console.Write("Tipo de caparazon: ");
            string tipoCaparazon = Console.ReadLine();

    Console.Write("Es acuatica: (s/n)");
            string respuestaTortuga = Console.ReadLine();
    Boolean actuatica = respuestaTortuga.ToLower() == "s";

    Tortuga tortuga = new Tortuga(nombre, peso, sexo, edad, propietario, tipoCaparazon, actuatica);

    mascotas[cantidadMascotas] = tortuga;
            cantidadMascotas ++;

            Console.WriteLine("Tortuga registrada correctamente.");
            Console.WriteLine("Codigo: " + tortuga.codigo);
            break;

            default:
            Console.WriteLine("Tipo de mascota no valido.");
            break;
    
        }
            
            
    }
    static void MostraMascota()
    {
        if (cantidadMascotas == 0)
        {
            Console.WriteLine("No hay mascota registrada.");
            return;
        }
        for (int i = 0; i < cantidadMascotas; i++)
        {
            mascotas[i].mostrarInformacion();
            Console.WriteLine();
        }
    }

    static Mascota BuscarMascota(string codigo)
    {
        for (int i =0; i < cantidadMascotas; i++)
        {
            if (mascotas[i].codigo == codigo);
            {
                return mascotas[i];
            }
        }
        return null;
    }

    static void CambiarEstado()
    {
        Console.Write("Ingrese el codigo de la mascota: ");
        string codigo = Console.ReadLine();

        mascota mascota = BuscarMascota(codigo);

    if (mascota == null)
        {
            Console.WriteLine("Mascota no encotrada.");
            return;
        }

        mascota.combiarEstado();

        Console.WriteLine("Estado cambiado correctamente.");
    }

    static void CalcularDosis()
    {
        Console.Write("Ingrese el codigo de la mascota: ");
        string codigo = Console.ReadLine();

        mascotas mascota = BuscarMascota(codigo);
         if (mascota == null)
        {
            Console.WriteLine("Mascota no encotrada");
            return;


        }
        Console.Write("Ingrese la dosis por Kg:");
        double dosisPorKg = double.Parse(Console.ReadLine());

        double dosis = mascota.CalculasDosis(dosisPorKg);

        Console.WriteLine("La dosis que debe administrar es: " + dosis + "mg");

    }

    }
        


    

