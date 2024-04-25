namespace repWhile_NumParesImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //desarrollar un programa que permita ingresar n numeros enteros
            // y luego nos imprima cuantos valores fueron pares y cuantos impares

            int n;
            int z;
            int x;
            int pares;
            int impares;
            string linea1;
            string linea2;
            z = 0;
            pares = 0;
            impares = 0;
            Console.WriteLine(" Cuantos numeros enteros desea ingresar:?  ");
            linea1 = Console.ReadLine();
            n = int.Parse(linea1);
            while (z <= (n - 1))
            {
                Console.WriteLine(" ingrese el un numero :?");
                linea2 = Console.ReadLine();
                x = int.Parse(linea2);
                z = z + 1;
                if (x % 2 == 0)
                {
                    pares = pares + 1;
                }
                else
                {
                    impares = impares + 1;
                }
            }

            Console.WriteLine(" la cantidad de numeros ingresados es:   " + n);
            Console.WriteLine("la cantidad de numeros pares es de:  " + pares);
            Console.WriteLine(" la cantidad de numeros impares es:   " + impares);


        }
    }
}
 
