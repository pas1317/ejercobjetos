namespace arraysUnid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array para ingresar 5 numeros
            //      Declaracion de arrays
            int cantidad = 5;
            int suma = 0;

            int[] numeros = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($" Ingrese el {i}ºnumero: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            foreach (int item in numeros)
            {
                suma += item;
            }
            foreach (int item in numeros)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"la sumatoria de todos los numeros es:  {suma} ");

        }
    }
}
