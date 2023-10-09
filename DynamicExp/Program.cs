internal class Program
{
    private static void Main(string[] args)
    {
        dynamic value;
        for (int demo = 0; demo < 2; demo++)
        {
            value = (demo == 0) ? (dynamic) 5 : (dynamic) "A";
            value = value + value;
            M(value);
        }
    }

    private static void M(Int32 n) { Console.WriteLine("M(Int32) : " + n); }
    private static void M(String s) { Console.WriteLine("M(String) : " + s); }
}