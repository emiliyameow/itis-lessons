namespace Loops;

using System.Diagnostics;
class Program
{
    static void Main(string[] args)
    {
        //FibonacciMassiv(int.Parse(args[0]));
        PrintFibonacciByLoops(int.Parse(args[0]));
    }

    static void FibonacciMassiv(int n)
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();
        ulong [] FibMass = new ulong[n + 1];
        for (int i = 1; i <= n; i++)
        {
            if (i == 1)
              FibMass[i] = 0;
            else if (i == 2 || i == 3)
              FibMass[i] = 1;
            else {
              FibMass[i] = FibMass[i - 1] + FibMass[i - 2];
            }
            //Console.Write($" {FibMass[i]}");
        }
        //Console.WriteLine("");
        sw.Stop();
        Console.WriteLine($"{sw.ElapsedTicks}");
        Console.WriteLine($"{sw.ElapsedMilliseconds}");
    }

    static int Fibonacci(int n)
    {
        if (n == 1)
          return 0;
        if (n == 2 || n == 3)
          return 1;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void PrintFibonacciByLoops(int n)
    {
        ulong prev = 0;
        ulong curr = 1;
        Stopwatch sw = new Stopwatch();
        sw.Start();
        //Console.Write("0 ");

        for (int  i = 1; i < n; i++)
        {
            //Console.Write(curr + " ");
            curr = curr + prev;
            prev = curr - prev;
        }
        sw.Stop();
        Console.WriteLine($"{sw.ElapsedTicks}");
        Console.WriteLine($"{sw.ElapsedMilliseconds}");
    }
}
