namespace procedimientoSumaResta
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Title = "Trabajando con procedimientos";
            suma();//llamado al procedimiento llamado suma
            Console.ReadKey();
            Console.Clear();
            resta();   // llamado al procedimnto resta
            Console.ReadLine();
            Console.Clear();
        }
        static void suma()
        {
            //declaracion de variables
            double resultado;
            double n1;
            double n2;
            Console.WriteLine(" Favor digitar 1a. cantidad : ? ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine(" Favor digitar la 2a. cantidad : ? ");
            n2 = double.Parse(Console.ReadLine());
            resultado = n1 + n2;
            Console.WriteLine(" El resultado de la suma :  " + resultado);
        }
        static void resta()
        {
            //declaracion de variables
            double resultado;
            double n1;
            double n2;
            Console.WriteLine(" Favor digitar 1a. cantidad : ? ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine(" Favor digitar la 2a. cantidad : ? ");
            n2 = double.Parse(Console.ReadLine());
            resultado = n1 - n2;
            Console.WriteLine(" El resultado de la resta :  " + resultado);
        }
    }
}
