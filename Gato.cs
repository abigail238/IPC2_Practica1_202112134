
//aqui volvemos a trabajar herencia de la clase mascota 

public class Gato : Macota
{
    private string raza;
    private bool esterilizado;

    // aqui hacemos el constructor de la clase gato y le pasamos los parametros de la clase padre 
    // que no se me olvide como se hizo esto por que es lo mas practico 

    public Gato (string nombre, double peso, string sexo, int edad, string propietario, bool enfermo, string raza, bool esterilizado):
    base(nombre, peso, sexo, esdad, propietario)   //base es para llamar al constructor de la clase padre 
    {
        this.raza = raza;
        this.esterilizado = esterilizado;


    }

    public string Raza
    {
        get{return raza;}
        set{raza = value;}

    }

    public bool Esterilizado
    {
        get{return esterilizado;}
        set{esterilizado = value;}

    }
    public override double CalcularDosis(double dosisPorKg)
    {
        double dosisBase =  Peso * dosisPorKg;
        return dosisBase * 0.90; 

    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacio();

        Console.WriteLine("Raza: " + raza );
        
        if (esterilizado)
        {
            Console.WriteLine("Esterilizado : Si");

        }
        else
        {
            Console.WriteLine("Esterilizado: No");
        }
    }


}