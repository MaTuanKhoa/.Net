Console.WriteLine("This is coding programe is written by Ma Tuan Khoa");
while (true)
{
    Console.Clear();

    Console.Write("Type the value of n (or Enter to close): ");
    var num = Console.ReadLine();
    if (String.IsNullOrEmpty(num)) { break; }

    int n = int.Parse(num);

    // If  abs( Result – Code Resul ) < 0.05 {Pass} Else { Error}
    Console.WriteLine($"S1: \t{S1(n):F3}");
    Console.WriteLine($"S2: \t{S2(n):F3}");
    Console.WriteLine($"S5: \t{S5(n):F3}");
    Console.WriteLine($"S6: \t{S6(n):F3}");
    Console.WriteLine($"S7: \t{S7(n):F3}");
    Console.Write("\n=== Press Any Key to Continue ===");
    Console.ReadKey();
}

//Caculate Function
double S1(int n)
{
    double sum = 0;
    for (int i = 1; i <= n; i++)
    {
        sum += Math.Pow(-1, i + 1) / SumPow2(i);
    }
    return sum;
}

double S2(int n)
{
    double sum = 1;
    for (int i = 1; i <= n; i++)
    {
        sum += Math.Pow(-2, i) / Factorial(i);
    }
    return sum;
}

double S5(int n)
{
    double sum = 0;
    for (int i = 1; i <= n; i++)
    {
        sum += Math.Pow(-1, i + 1) / (2 * i);
    }
    return sum;
}

double S6(int n)
{
    double sum = 0;
    for (int i = 1; i <= n; i++)
    {
        sum += Math.Pow(-1, i + 1) / SumNum(i);
    }
    return sum;
}

double S7(int n)
{
    double sum = 1;
    for (int i = 1; i <= n; i++) { sum += Math.Pow(2, i) / Factorial(i); }
    return sum;
}

//Elemetal Function
double SumPow2(int n)
{
    double sum = 0;
    for (int i = 1; i <= n; i++) { sum += i * i; }
    return sum;
}

double SumNum(int n)
{
    return n * (n + 1) / 2.0;
    /*  S=n+(n−1)+(n−2)+...+1
        (S + S) = (1 + n) + (2 + (n−1))+(3 + (n−2))+...+(n + 1)
        (S+S)=(1+n)+(2+(n−1))+(3+(n−2))+...+(n+1)
        2S=(n+1)+(n+1)+(n+1)+...+(n+1) ======> 2S=n(n+1)  
     */
}

double Factorial(int n)
{
    double f = 1;
    for (int i = 1; i <= n; i++)
    {
        f *= i;
    }
    return f;
}