namespace numeroPrimooNoPrimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // crear una funcion que determine si el numero recibido
            // por parametro es primo o no
            //  declaracion de variables
            int numero;
            string numeroN;
            //Ingreso de datos
            Console.WriteLine(" Favor ingrese un numero: ? ...");
            numeroN = Console.ReadLine();
            numero = int.Parse(numeroN);
            //Desarrollo
            if (numero%2 != 0)
            {
                Console.WriteLine("El numero no es primo ");
            }
            else
            {
                Console.WriteLine(" El Numero es primo ");
            }

        }
    }
}
