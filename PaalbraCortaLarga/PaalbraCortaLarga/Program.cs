namespace PaalbraCortaLarga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una funcion que evale si una palabra es corta o larga.
            // Se considera larga si tiene mas de 8 caracteres
            //Definicion de variables
            string palabra;
            int Largo;
            // ingreso de datos
            Console.WriteLine(" Favor ingrese una palabra : ?  ");
            palabra = Console.ReadLine();
            //Contar las letras de la palabra
            Largo = palabra.Length;
            //Ver si la palabra es corta o larga
            if (Largo <=  8)
            { Console.WriteLine(" La palabra es corta");
            }
            else
            {
                Console.WriteLine(" La palabra es larga") ;
            }

        }
    }
}
