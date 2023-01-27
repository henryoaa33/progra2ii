class ExpresionMatematica
{
    public double Numero1 { get; set; }
    public double Numero2 { get; set; }

    public double Suma()
    {
        return Numero1 + Numero2;
    }

    public double Resta()
    {
        return Numero1 - Numero2;
    }

    public double Division()
    {
        return Numero1 / Numero2;
    }

    public double Multiplicacion()
    {
        return Numero1 * Numero2;
    }

    public double Maximo()
    {
        return Math.Max(Numero1, Numero2);
    }

    public double Minimo()
    {
        return Math.Min(Numero1, Numero2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        ExpresionMatematica exp1 = new ExpresionMatematica { Numero1 = 5, Numero2 = 3 };
        ExpresionMatematica exp2 = new ExpresionMatematica { Numero1 = 8, Numero2 = 2 };

        Console.WriteLine("Expresión 1");
        Console.WriteLine("Suma: " + exp1.Suma());
        Console.WriteLine("Resta: " + exp1.Resta());
        Console.WriteLine("División: " + exp1.Division());
        Console.WriteLine("Multiplicación: " + exp1.Multiplicacion());
        Console.WriteLine("Máximo: " + exp1.Maximo());
        Console.WriteLine("Mínimo: " + exp1.Minimo());

        Console.WriteLine("Expresión 2");
        Console.WriteLine("Suma: " + exp2.Suma());
        Console.WriteLine("Resta: " + exp2.Resta());
        Console.WriteLine("División: " + exp2.Division());
        Console.WriteLine("Multiplicación: " + exp2.Multiplicacion());
        Console.WriteLine("Máximo: " + exp2.Maximo());
        Console.WriteLine("Mínimo: " + exp2.Minimo());

        Console.ReadKey();
    }
}
