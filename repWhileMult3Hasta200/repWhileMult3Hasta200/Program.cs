namespace repWhileMult3Hasta200
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desarrollar un programa que imprima los multiplos 
            // de 3 hasta el numero 200.-
            int multiplic;
            multiplic = 3;
            while ( multiplic<=200)
            {
                Console.Write(multiplic + " , "); 
                multiplic = multiplic + 3;
            }
            Console.ReadKey();
                    }
    }
}
