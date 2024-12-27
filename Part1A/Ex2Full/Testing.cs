using System.Diagnostics;
public class Testing
{
    public void TestFunction(string name, Func<double, double> func, double[] inputs, double[] expectedOutputs, double e)
    {
        Console.WriteLine();
        Console.WriteLine($"Function: {name}");
        for (int i = 0; i < inputs.Length; i++)
        {
            double input = inputs[i];
            double expected = expectedOutputs[i];

            Stopwatch stopwatch = Stopwatch.StartNew();
            double actual = func(input);
            stopwatch.Stop();

            //bool passed = actual - expected < +-epsilon;

            bool passed = Math.Abs(actual - expected) < e;
            Console.WriteLine($"Input: {input}, Expected: {expected}, Actual: {actual}, Result: {(passed ? "Passed" : "Failed")}");
        }

    }
}