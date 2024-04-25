namespace procedimientoDigitarNumeroVerParImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {             // programa que me permita  digitar un numero entero
                          // y positivo y me diga si es par o impar
                          //Inicio programaPrincipal
                          //Fijo color teclas y pantalla
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                // Comienza programa
                Console.Title = " Uso de un procedimiento";
                //Declaracion de variables
                int num;
                //Desarrollo programa
                Console.WriteLine(" Favor digitar un numero entero positivo : ?  ");
                num = int.Parse(Console.ReadLine());
                Par(num);
                Console.WriteLine("\n");
                Console.WriteLine("--> Fin del Programa");
                Console.ReadKey();
            }
        }
        static void Par(int a)
        {
            int x;
            x = (a % 2);
            {
                if (x == 0)
                {
                    Console.WriteLine( " El numero   " + a + "  es par ");
                }
                else
                {
                    Console.WriteLine( " El numero    " + a +" es impar");
                }
            }
        }
    }
}                                                                                                                                                                                                                  
