using System.Diagnostics;

namespace ingresar5NumYProm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar 5 numeros enteros , calcular y mostrar promedio
            string n1;
            string n2;
            string n3;
            string n4;
            string n5;
            int n1Num;
            int n2Num;
            int n3Num;
            int n4Num;
            int n5Num;
            double promedio = 0;
            Console.WriteLine(" favor ingresar el 1er numero");
            n1 = Console.ReadLine();
            n1Num = int.Parse(n1);
            Console.WriteLine(" favor ingrese 2do numero");
            n2 = Console.ReadLine();
            n2Num = int.Parse(n2);
            Console.WriteLine("favaor ingrese 3er numero");
            n3 = Console.ReadLine();
            n3Num = int.Parse(n3);
            Console.WriteLine(" favor ingrese 4to numero");
            n4 = Console.ReadLine();
            n4Num = int.Parse(n4);
            Console.WriteLine("favor ingrese 5to numero");
            n5 = Console.ReadLine();
            n5Num = int.Parse(n5);
            promedio = (n1Num+n2Num+n3Num+n4Num+n5Num)/ 5;
            Console.WriteLine(" El promedio de los 5 numeros es : " + (promedio));
            
        }
    }
}
