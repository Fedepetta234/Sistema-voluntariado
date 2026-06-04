public class Coordinador : Persona
{
    private string area;
    private int cantPersonas;

    public string Area { get { return this.area; } set { this.area = value; } }
    public int CantPersonas { get { return this.cantPersonas; } set { this.cantPersonas = value; } }
    
    public Coordinador(string nombre, string apellido, string dni, string area, int cantPersonas) : base (nombre, apellido, dni)
    {
        this.Area = area;
        this.CantPersonas = cantPersonas;
    }

    public override void Desempenio()
    {
        Console.WriteLine($"Coordinador: {this.Nombre} {this.Apellido}");
        Console.WriteLine($"Área: {this.Area}");
        Console.WriteLine($"Cantidad de personas a su cargo: {this.CantPersonas}");
    }
}