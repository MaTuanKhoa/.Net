Console.WriteLine("This is a coding program written by Ma Tuan Khoa");
var test = new Testing();
while (true)
{
    double x = 0;

    Console.Write("Enter the value of epsilon (or Enter to close): ");
    var num = Console.ReadLine();

    if (string.IsNullOrEmpty(num)) { break; }

    double epsilon = double.Parse(num);
    if (epsilon >= 1 || epsilon <= 0)
    {
        Console.WriteLine("\n~~~ Please enter a number between 0 and 1 ~~~\n ");
        continue;
    }

    Console.Write($"\nApproximation of pi/4: {Pi(epsilon):F4}");





    while (true)
    {
        Console.WriteLine("\n=== CHOOSE WHAT YOU WANT TO CALCULATE ===");
        Console.WriteLine("1. Sin(x)");
        Console.WriteLine("2. Cos(x)");
        Console.WriteLine("3. Ln(1 + x) \t=>(-1 < x < 1)");
        Console.WriteLine("4. Sin(x); Ln(1 + x); Cos(x) \t=>(-1 < x < 1)");

        if (!int.TryParse(Console.ReadLine(), out int action))
        {
            Console.WriteLine("\n~~~ Please enter a number between 1 and 4 ~~~~\n");
            continue;
        }

        if (action == 3 || action == 4)
        {
            while (true)
            {
                Console.Write("\n=== x FROM -1 TO 1 ===\nEnter the value of x: ");
                if (!double.TryParse(Console.ReadLine(), out x) || x < -1 || x > 1)
                {
                    Console.WriteLine("Invalid x value. Please enter a valid number.");
                    continue;
                }
                else { break; }
            }
        }
        else
        {
            while (true)
            {
                Console.Write("\nEnter the value of x: ");
                if (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Invalid x value. Please enter a valid number.");
                    continue;
                }
                else { break; }
            }
        }


        switch (action)
        {
            case 1:
                {
                    Console.WriteLine($"Approximation of sin({x}): {Sin(epsilon, x):F4}");
                    break;
                }
            case 2:
                {
                    Console.WriteLine($"Approximation of cos({x}): {Cos(epsilon, x):F4}");
                    break;
                }
            case 3:
                {
                    Console.WriteLine($"Approximation of ln(1 + {x}): {Ln(epsilon, x):F4}");
                    break;
                }
            case 4:
                {
                    Console.WriteLine($"Approximation of sin({x}): {Sin(epsilon, x):F4}");
                    Console.WriteLine($"Approximation of ln(1 + {x}): {Ln(epsilon, x):F4}");
                    Console.WriteLine($"Approximation of cos({x}): {Cos(epsilon, x):F4}");
                    break;
                }
            default:
                {
                    Console.WriteLine("Invalid option. Please choose a valid action.");
                    continue;
                }
        }
        break;
    }
    Console.Write("\n=== Press Any Key to Next Step (testing) ===");
    Console.ReadKey();
    Console.Clear();


    Console.WriteLine("\n\t=== TESTING CODE ===");
    test.TestFunction("Sin", x => Sin(epsilon, x), new double[] { 0, 1.4, 2.3 }, new[] { Math.Sin(0), Math.Sin(1.4), Math.Sin(2.3) }, epsilon);
    test.TestFunction("Ln", x => Ln(epsilon, x), new double[] { 0, 0.5, 1 }, new double[] { Math.Log(1 + 0), Math.Log(1 + 0.5), Math.Log(1 + 1) }, epsilon);
    test.TestFunction("Cos", x => Cos(epsilon, x), new double[] { 0, 1.2, 1.5 }, new[] { Math.Cos(0), Math.Cos(1.2), Math.Cos(1.5) }, epsilon);
    Console.WriteLine("\n=== Press Any Key to Continue ===");
    Console.ReadKey();
    Console.Clear();




    double Pi(double epsilon)
    {
        double sum = 0;
        int n = 0;
        double term;
        do
        {
            term = Math.Pow(-1, n) / (2 * n + 1);
            sum += term;
            n++;
        } while (Math.Abs(term) >= epsilon);

        return sum * 4;
    }

     double Sin(double epsilon, double x)
    {
        double sum = x;
        double term = x;
        int n = 1;

        while (Math.Abs(term) >= epsilon)
        {
            term = Math.Pow(-1, n) * Math.Pow(x, 2 * n + 1) / Factorial(2 * n + 1);
            sum += term;
            n++;
        }

        return sum;
    }

     double Ln(double epsilon, double x)
    {
        double sum = x;
        int n = 2;
        double term = x;

        while (Math.Abs(term) >= epsilon)
        {
            term = Math.Pow(-1, n - 1) * Math.Pow(x, n) / n;
            sum += term;
            n++;
        }

        return sum;
    }

     double Cos(double epsilon, double x)
    {
        double sum = 1;
        double term = 1;
        int n = 1;

        while (Math.Abs(term) >= epsilon)
        {
            term = Math.Pow(-1, n) * Math.Pow(x, 2 * n) / Factorial(2 * n);
            sum += term;
            n++;
        }

        return sum;
    }
    double Factorial(int num)
    {
        double result = 1;
        for (int i = 2; i <= num; i++)
        {
            result *= i;
        }
        return result;
    }
}
