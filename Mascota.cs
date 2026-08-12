public class Mascota
{
    // atributos 

    private string nombre;        //Private osea que solo lo usaremos dentro de la clase mascota 
    private double peso;
    private string sexo;
    private int edad;
    private string propietario;
    private string codigo;
    private bool enfermo;


 //cosntructor
public Mascota (string nombre, double peso, string sexo, int edad, string propietario, bool enfermo)
{
    this.nombre = nombre;
    this.peso = peso;
    this.sexo = sexo;
    this.edad = edad;
    this.propietario = propietario;
    this.enfermo = enfermo;

    codigo = GenerarCodigo();
    enfermo = true;


}
 //METODO CODIGO 
  private string GenerarCodigo()
{
// identificador unico 
    return Guid.NewGuid()                       
    .ToString("N").Substring(0, 8).ToUpper();
}

//encapsulamiento de los atributos mascota osea los get y set 
//value es el valor que alguien intenta asignarle a una propiedad 
public string Nombre
{
    get {return nombre;}
    set {return nombre = value;}
}

public double Peso
{
    get {return peso;}
    set {return peso = value;}
}
public string Sexo
{
    get{return sexo;}
    set{return sexo = value;}
}

public int Edad
{
    get{return edad;}
    set{return edad= value;}
}
public string Propietario
{
    get{return propietario;}
    set{return propietario = value;}
}

public string Codigo
{
    get{return codigo;}
    set{return codigo = value;}
}
public bool Enfermo
{
    get{return enfermo;}
    set{return enfermo = value;}
}

public virtual double CalcularDosis(double dosisPorKg)
    {
        return peso * dosisPorkg;
    }

//aqui el metodo para cambiar el estado del paciente de enfermos a sano 
//osea aqui se revisa el valor booleano true o false 
public void CambiarEstado()
    {
        enfermo = !enfermo;
    }

        public virtual void MostrarInformacion()
    {
// aqui esta el metodo para mostrar la informcion de la mascota 
Console.WriteLine("......................");
Console.WriteLine("Nombre: " + nombre);
Console.WriteLine("Peso: " + peso + "Kg");
Console.WriteLine("Sexo: " + sexo);
Console.WriteLine("Edad: " + edad );
Console.WriteLine("Propietario: " + propietariop);
Console.WriteLine("Codigo:" + codigo);

if (enfermo){
    console.WriteLine("Estado: enfermo");
}
else
{
    Console.WriteLine("Estado: sano");
}
    }
}

