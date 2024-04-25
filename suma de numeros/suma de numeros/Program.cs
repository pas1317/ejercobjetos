namespace suma_de_numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numero1;
            string numero2;
            int numero1N;
            int numero2N;
            int suma;
            Console.WriteLine(" favor ingrese el 1er numero :?");
            numero1 = Console.ReadLine();
            numero1N = int.Parse(numero1);
            Console.WriteLine(" favor ingrese el 2do. numero:? ");
            numero2 = Console.ReadLine();
            numero2N = int.Parse(numero2);
            suma = numero1N + numero2N;
            Console.WriteLine("la sema de los numeros" + numero1 + " y  " + numero2 + " es igual a:" + suma);

        }
    }
}
