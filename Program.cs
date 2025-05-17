public class MyClass
{
    public static void Main(string[] args)
    {
        string input = "10";
        int result;
        bool isSuccess = int.TryParse(input, out result);
        Console.WriteLine($"isSuccess = {isSuccess}");
        Console.WriteLine($"result = {result}");
        Console.ReadKey();
    }
}