using System.ComponentModel.Design;
namespace ejercArraayClaveyVerificacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creacion de una clave de entrada y verificar con 3 intentos
            // dECLARACION DE VARIABLES
            byte k;
            byte sw;
            string Clave;
            //Inicializacion de variables
            sw = 0;
            k = 0;
            // Entrada de clave
            do
            {
                Console.WriteLine(" Digite una clave :   ");
                Clave = Console.ReadLine();
                if (Clave =="1234")
                {
                    Console.WriteLine("· la clave es correcta");
                    sw =1;
                }
                else
                {
                    k++;
                }
            }  while (((k < 3) & (sw == 0)));
            if (sw == 1)
            {
                Console.WriteLine(" Bienvenido   " + Clave);
            }
            else
            {
                Console.WriteLine("oportunidades terminadas");
                Console.WriteLine(" Ya hizo 3 intentos");
            }
            Console.WriteLine(" Pulse una tecla ");
            Console.ReadLine();
            }
    }
}
