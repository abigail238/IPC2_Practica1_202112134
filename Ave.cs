
public class Ave: Mascota
{
    private string envergadura;
    private bool puedeVolar;

    // constructor 
    public Ave(string nombre, double peso, string sexo, int edad, string propietario, bool enfermo, string envergadura, bool puedeVolar):
    base(nombre, peso, sexo, edad, propietario)
    {
        this.envergadura = envergadura;
        this.puedeVolar = puedeVolar;
    }

// Encapsulamiento de los atributos de la clase ave
    public string Envergadura
    {
        get{return envergadura;}
        set{envergadura =  value;}
}

public bool PuedeVolar
    {
        get{return puedevolar}
        set{puedeVolar = value;}
    }

    //plimorfismo de la calse ave 

    public override double CalcularDosis(double dosisPorKg)
    {
        double dosisBase = Peso * dosisPorkg;
        return dosisBase * 0.50;
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();

        Console.WriteLine("Envergadura; " + envergadura);

        if (puedeVolar)
        {
            Console.WriteLine("Puede volar: Si");

        }
        else
        {
            Console.WriteLine("Puede volar: No");
        }
    }
    

}