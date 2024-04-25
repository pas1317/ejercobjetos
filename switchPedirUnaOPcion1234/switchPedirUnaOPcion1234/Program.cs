namespace switchPedirUnaOpcion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pedir una opcion al usuario
            //1.- fondo azul , letras rojo
            //2.- fondo verde , letras amarillas
            //3.-fondo blanco , letras negras
            //4.-fondo amarillo , letras azules
            //5.-fondo magneta letras amarillas
            //6.-fondo blanco , letras oscura
            // mostrar mensaje que introdujo el usuario
            // Deaclaracion de variables
            string mensaje;
            int opcion;
            string opcionN;
            // ingreso de datos
            Console.WriteLine(" elija una opcion");
            Console.WriteLine("1.- fondo azul , letras rojo");
            Console.WriteLine("2.- fondo verde , letras amarillas");
            Console.WriteLine("3.- fondo amrillo , letras azules");
            Console.WriteLine("4.- fondo blanco , letras negras");
            Console.WriteLine("5.- fondo magneta oscuro , letras amarillas");
            Console.WriteLine("6.- fondo blanco , letras azules");
            Console.WriteLine(" introduzca la opcion deseada ( de 1 a 6) :  ");
            opcionN = Console.ReadLine();
            opcion = int.Parse(opcionN);
      
            Console.WriteLine(" favor introduzca un mensaje");
            mensaje = Console.ReadLine();
             
            switch (opcion)
            {
                case 1:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(mensaje);
                break;
                case 2:
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(mensaje);
                    break;
                case 3:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(mensaje);
                break;
                case 4:
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(mensaje);
                break;
                case 5:
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(mensaje);
                break;
                case 6:
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(mensaje);
                break;
                default:
                    Console.WriteLine("Favor ingrese una opcion correcta");
                break;
            }
        }
    }
}
