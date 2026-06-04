abstract public class Persona
{
    private string nombre;
    private string apellido;
    private string dni;

    public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
    public string Apellido { get { return this.apellido; } set { this.apellido = value; } }
    public string Dni { get { return this.dni; } set { this.dni = value; } }

    public Persona(string nombre, string apellido, string dni)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Dni = dni;
    }

    public abstract void Desempenio();
}