namespace estRepWhileMostrarN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //realizar un programa que dado un numero entero , imprima consecutivamente
            //hasta ese numero
            int n;
            int x;
            string nCarac;
            Console.WriteLine(" ingrese el valor de n.");
            nCarac = Console.ReadLine();
            n = int.Parse(nCarac);
            x = 1;
            while (x <= n)
            {
                Console.Write(x);
                Console.Write("  , ");
                x = x + 1;
            }
            Console.ReadKey();
        }
    }
}
