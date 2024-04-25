// ingresar 3 numeros distintos y nos de el menor
namespace mayorDe3Numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;
            int n3;
            Console.WriteLine(" Ingrese el 1er numero:?");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Ingrese el 2do. numero");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Ingrese el 3er. Numero:?");
            n3 = int.Parse(Console.ReadLine());
            if (n1 < n2 & n2 < n3)
            {
                Console.WriteLine(" El 1er. numero es el menor" + n1);
            }
            else
            {
                if (n2 > n1 & n1 > n3)
                {
                    Console.WriteLine(" El 3er numero es el menor:? " + n3);
                }
                else
                {
                    Console.WriteLine("El 2do numero es el menor:?" + n2);
                }
            }        

        }
    }
}
