///Escribir un numero y que me diga si es par o impar
namespace parOimpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine(" Ingrese un numero:?");
            n = int.Parse(Console.ReadLine());
            if (( n % 2 ) == 0)
            {
                Console.WriteLine("El numero es `par");
            }
            else
            { Console.WriteLine("el numero es impar");
            } 
        }
    }
}
