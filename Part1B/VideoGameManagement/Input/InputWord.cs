
namespace VideoGameManagement.Input;

internal class InputWord
{
    public string GetNonEmptyString(string prompt)
    {
        string? input;
        do
        {
            Console.Write(prompt);
            input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("\n=== EMPTY INPUT - TRY AGAIN ===");
            }
        } while (string.IsNullOrEmpty(input));

        return input;
    }

    public int GetValidInt(string prompt)
    {
        int year;
        string? input;

        do
        {
            Console.Write(prompt);
            input = Console.ReadLine();

            if (!int.TryParse(input, out year))
            {

                Console.WriteLine("\n=== INVALID NUMBER - TRY AGAIN ===");
            }
        } while (!int.TryParse(input, out year));

        return year;
    }
}

