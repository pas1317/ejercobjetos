namespace Funciones
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello,world");
            int numero = pedirEnteroConRango("ingrese un numero entre 10 y 50", " El numero ingresado esta fuera de rango    ", 50, 10);
        }
        static int pedirEnteroConRango(string mensaje, string mensajeError, int maximo, int minimo)
        { //Funciones que no reciben ni retornan algo
            int numeroValido = 0;
            string numero;
            string numeroLeido;
            Console.Write(mensaje);
            numeroLeido = Console.ReadLine();
            numeroLeido = numeroLeido;
            Console.WriteLine($"el numero ingresado es:{numeroLeido}");
            while (!esNumerico(numeroLeido) || (int.Parse(numeroLeido ) > maximo ||int.Parse (numeroLeido)< minimo))   
            {
                Console.WriteLine(mensajeError);
                Console.Write(mensaje);
                numeroValido = int.Parse(Console.ReadLine());
            }
            return numeroValido;
        }
        static bool esNumerico(string dato)
        {
            bool esNumerico = true;
            foreach (char digito in dato)
            {
                if (!char.IsDigit(digito))
                {
                    esNumerico = false;
                    break;
                }
            }
            return esNumerico;
        }
    } 
 }
