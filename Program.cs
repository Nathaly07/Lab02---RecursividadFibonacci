using System.Diagnostics;

namespace Lab02_RecursivoFibonacci;
class Program
{
    static int Main(string[] args)
    {
        Stopwatch tiempo_recursivo = new Stopwatch();
        Stopwatch tiempo_iterativo = new Stopwatch();
        int n, k;
        n = 0;
        k = 0;
        do
        {
            Console.WriteLine("Introduzca el número de términos: ");
            n = Int32.Parse(Console.ReadLine()); //Convierto lo que ingreso de Strings a Int

        } while (n <= 1);

        Console.WriteLine("\nSerie números de fibonacci recursivo: ");
        tiempo_recursivo.Start(); // llamamos al metodo para iniciar el conteo

        for (k = 0; k < n; k++)
        {
            Console.Write(FibonacciRecursivo(k) + " , ");
        }

        tiempo_recursivo.Stop(); //Finalizamos el conteo.
        Console.WriteLine("Elapse Time: " + tiempo_recursivo.Elapsed.TotalMilliseconds + "s");

        Console.WriteLine("\nSerie números de fibonacci iterativo: ");
        tiempo_iterativo.Start(); //Realizamos nuevamente el conteo para iterativo
        FibonacciIterativo(n);
        tiempo_iterativo.Stop(); //Finalizamos
        Console.WriteLine("Elapse Time: " + tiempo_iterativo.Elapsed.TotalMilliseconds + "s");
        return 0;

    }

    static long FibonacciRecursivo(int n)
    {
        if (n < 2) { return n; }
        else { return FibonacciRecursivo(n - 2) + FibonacciRecursivo(n - 1); }
    }

    static void FibonacciIterativo(int n)
    {
        int i; int ant1, ant2;
        ant1 = ant2 = 1;
        Console.Write("0 , 1 , 1 , ");
        for (i = 1; i < n - 2; i++)
        {
            int actual = ant1 + ant2;
            Console.Write(actual + " , ");
            ant2 = ant1;
            ant1 = actual;
        }
    }

}
