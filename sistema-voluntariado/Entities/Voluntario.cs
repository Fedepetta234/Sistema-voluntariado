using System.Runtime.InteropServices;

public class Volountario : Persona
{
    private int horas;

    public int Horas{get{return this.horas;} set{value = this.horas}}
    public Volountario(string nombre, String apellido, String dni, int horas) : base (nombre, apellido, dni)
    {
        this.Horas = horas;   
    }

    public override void Desempenio()
    {
        Console.WriteLine($"Horas trabajadas: {horas}");
    }
}