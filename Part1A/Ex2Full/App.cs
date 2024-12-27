
public class App
{

    public double Pi(double epsilon)
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

    public double Sin(double epsilon, double x)
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

    public double Ln(double epsilon, double x)
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

    public double Cos(double epsilon, double x)
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
    public double Factorial(int num)
    {
        double result = 1;
        for (int i = 2; i <= num; i++)
        {
            result *= i;
        }
        return result;
    }
}
