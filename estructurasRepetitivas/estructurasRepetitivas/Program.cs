namespace estructurasRepetitivas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //realize un programa dque dado un numero entero ,
            //imprima consecutivamente hasta ese numero.-
            int x;
            string linea;
            int n;
            x = 1; 
            Console.WriteLine(" favor ingrese el valor del numero:?  ");
            linea= Console.ReadLine();
            n = int.Parse(linea);
            while (x<= n)
            {
                Console.Write(x + "  ,  " );
                x = x + 1;
            }
            Console.ReadKey();
        }
    }
}
