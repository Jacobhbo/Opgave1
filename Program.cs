namespace ctof
{
    internal class Opgaveyk
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skrive hvor mange Celcius du ville convert til Fahrenheit");
            Console.Write("C: ");
            int ctof = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"F: {ctofconverter(ctof)} ");

            Console.ReadKey();

            static float ctofconverter(int ctof)
            {
                return ctof * 9 / 5 + 32;
            }

            Console.ReadKey();
        }
    }
}