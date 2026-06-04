using System.Runtime.InteropServices;

public class Voluntario : Persona
{
    private int horas;

    public int Horas{get{return this.horas;} set{this.horas = value;}}
    public Voluntario(string nombre, string apellido, string dni, int horas) : base (nombre, apellido, dni)
    {
        this.Horas = horas;   
    }

    public override void Desempenio()
    {
        Console.WriteLine($"Voluntario: {this.Nombre} {this.Apellido}");
        Console.WriteLine($"Horas trabajadas: {this.Horas}");
    }
}