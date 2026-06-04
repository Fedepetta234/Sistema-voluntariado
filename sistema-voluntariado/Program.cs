class Program
{
    static List<Voluntario> voluntarios = new List<Voluntario>();
    static List<Coordinador> coordinadores = new List<Coordinador>();
    static void Main()
    {
        

        int op;

        do
        {
            Console.WriteLine("\n\t--Menu--");
            Console.WriteLine("1. Agregar voluntario");
            Console.WriteLine("2. Agregar coordinador");
            Console.WriteLine("3. Mostrar voluntarios");
            Console.WriteLine("4. Mostrar coordinadores");
            Console.WriteLine("0. Salir");
            Console.Write("Ingrese una opción: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    AgregarVoluntario();
                    break;
                case 2:
                    AgregarCoordinador();
                    break;
                case 3:
                    MostrarVoluntarios();
                    break;
                case 4:
                    MostrarCoordinadores();
                    break;
                case 0:
                    Console.WriteLine("se vimos");
                    break;
                default:
                    Console.WriteLine("Opción inválida!!!");
                    break;
            }
        }while (op != 0);
    }

    static void AgregarVoluntario()
    {
        Console.Write("\nIngrese el nombre del voluntario: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese el apellido del voluntario: ");
        string apellido = Console.ReadLine();

        Console.Write("Ingrese el DNI del voluntario: ");
        string dni = Console.ReadLine();

        Console.Write("Ingrese las horas trabajadas por el voluntario: ");
        int horas = int.Parse(Console.ReadLine());

        
        voluntarios.Add(new Voluntario(nombre, apellido, dni, horas));
    }

    static void AgregarCoordinador()
    {
        Console.Write("\nIngrese el nombre del coordinador: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese el apellido del coordinador: ");
        string apellido = Console.ReadLine();

        Console.Write("Ingrese el DNI del coordinador: ");
        string dni = Console.ReadLine();

        Console.Write("Ingrese el área de trabajo del coordinador: ");
        string area = Console.ReadLine();

        Console.Write("Ingrese la cantidad de personas a su cargo: ");
        int cantPersonas = int.Parse(Console.ReadLine());

        
        coordinadores.Add(new Coordinador(nombre, apellido, dni, area, cantPersonas));
    }

    static void MostrarVoluntarios()
    {
        Console.WriteLine("Voluntarios:");
        foreach (var voluntario in voluntarios)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"- {voluntario.Nombre} {voluntario.Apellido} (DNI: {voluntario.Dni}, Horas: {voluntario.Horas})");
            Console.WriteLine("-------------------------------");
        }
    }

    static void MostrarCoordinadores()
    {
        Console.WriteLine("Coordinadores:");
        foreach (var coordinador in coordinadores)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"- {coordinador.Nombre} {coordinador.Apellido} (DNI: {coordinador.Dni}, Área: {coordinador.Area})");
            Console.WriteLine("-------------------------------");
        }
    }   
}
