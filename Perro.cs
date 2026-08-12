
//aqui vamos a trabajar herencia de la clase mascota 
// se usa : para indicar que la clase perro hereda de la clase mascota 

public class Perro : Mascota
{
    // aqui vamos a declarar los atributos 

private string raza;
private string tamanio;

public Perro(String nombre, double peso, string sexo, int edad, string propietario, bool enfermo, string raza, string tamanio):
base(nombre, peso, sexo, edad, propietario)
    {
        this.raza = raza;
        this.tamanio = tamanio;
    }

public string Raza
    {
        get{return raza;}
        set{raza = valvue;}

    }

    public string Tamnio
    {
        get{return tamanio;}
        set{tamanio = value;}
    }
 
// aqui vamos a polimorfismo 

public override double CalcularDosis(double dosisPorKg)  //override es para remplazar el comportamiento del metodo que herede de la clase padre 

    {
        return peso * dosisPorKg;

    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion(); //aqui base es para llamar primero al metodo de la clase padre y despues sera este de perro

        Console.WriteLine("Raza : " + raza);
        Console.WriteLine("Tamanio:" + tamanio);
    }

}