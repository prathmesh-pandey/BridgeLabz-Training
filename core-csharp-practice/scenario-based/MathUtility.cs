using System;


class MathUtility
{

    // Factorial method
    static long Factorial(int n)
    {
        if (n < 0)
            return -1;

        long result = 1;
        for (int i = 1; i <= n; i++)
            result *= i;

     
        return result;
    }


    // Prime check method
    static bool IsPrime(int n)
    {
        if (n <= 1)
            return false;

        for (int i = 2; i <= n / 2; i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }


    // GCD method
    static int GCD(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);

        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        return a;
    }


    // Fibonacci method
    static int Fibonacci(int n)
    {
        if (n < 0)
            return -1;

        if (n == 0)
            return 0;

        if (n == 1)
            return 1;

        int a = 0, b = 1, c = 0;
        for (int i = 2; i <= n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }

        return c;
    }


    // Main method
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- Math Utility Menu ---");
            Console.WriteLine("1. Factorial");
            Console.WriteLine("2. Prime Check");
            Console.WriteLine("3. GCD");
            Console.WriteLine("4. Fibonacci");
            Console.WriteLine("5. Exit");
            Console.Write("Choose option: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter number: ");
                    int n1 = int.Parse(Console.ReadLine());
                    long fact = Factorial(n1);

                    if (fact == -1)
                        Console.WriteLine("Factorial not defined for negative numbers.");
                    else
                        Console.WriteLine("Factorial = " + fact);
                    break;

                case 2:
                    Console.Write("Enter number: ");
                    int n2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(IsPrime(n2) ? "Prime Number" : "Not a Prime Number");
                    break;

                case 3:
                    Console.Write("Enter first number: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("GCD = " + GCD(a, b));
                    break;

                case 4:
                    Console.Write("Enter n: ");
                    int n3 = int.Parse(Console.ReadLine());
                    int fib = Fibonacci(n3);

                    if (fib == -1)
                        Console.WriteLine("Fibonacci not defined for negative numbers.");
                    else
                        Console.WriteLine("Fibonacci = " + fib);
                    break;

                case 5:
                    Console.WriteLine("Exiting program.");
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
