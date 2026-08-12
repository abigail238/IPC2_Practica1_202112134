
using System.Data;
using System.Reflection.PortableExecutable;

public class Tortuga : Mascota
{
    private string tipoCaparazon;
    private bool puedeNadar;

  //cosntructor 

  public Tortuga(string nombre, double peso, string sexo, int edad, string propietario, bool enfermo, string tipoCaparazon, bool puedeNadar):
  base(nombre, peso, sexo, edad, propietario)
    {
        this.tipoCaparazon =  tipoCaparazon;
        this.puedeNadar = puedeNadar;
    }

    //Encapsulamiento

    public string TipodeCaparazon
    {
        get{return tipoCaparazon;}
        set{tipoCaparazon = value;}
    }

    public bool PuedeNadar
    {
        get{return puedeNadar;}
        set{puedeNadar =  value ;}
    }

    //plolimorfismo
    public override CalcularDosis(double dosisPorKg)
    {
        double dosisBase = PEStreamOptions * dosisPorKg;
        return dosisBase * 0.80;

    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();

        Console.WriteLine("Tipo de caparazon: " + tipoCaparazon);

        if (PuedeNadar)
        {

        Console.WriteLine("Puede Nadar: No");

    }
    else
    {

        Console.WriteLine("Puede Nadar: Si");
    }

}
}