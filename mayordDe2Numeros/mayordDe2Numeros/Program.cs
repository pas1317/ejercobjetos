namespace mayordDe2Numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Num1;
            int Num2;
            string linea;
            Console.Write(" Ingrese el 1er. Numero . ? ");
            linea = Console.ReadLine();
            Num1 = int.Parse(linea);
            Console.WriteLine("Ingrese el 2do. Numero :? ");
            linea = Console.ReadLine();
            Num2 = int.Parse(linea);
            if (Num1 > Num2)
            {
                Console.WriteLine(" el 1er numero es mayor al 2do numero");
            }
            else
            {
                if (Num1 == Num2)
                {
                    Console.WriteLine(" Los dos numeros son iguales");
                }
                else
                {
                    Console.WriteLine(" el 2do numero es mayor al 1er numero");
                }

            }
        }

    }
}