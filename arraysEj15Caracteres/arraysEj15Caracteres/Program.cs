namespace arraysEj15Caracteres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pedir el ingreso de una palabra  , verificar que por lo menos tenga 5 caracteres
            //de n se asi informar. Luego mostrar los 3 primeros caracteres ( ej. zapallo ---> Zap)
            // Definicion de variables
            String palabra;
            int cantidadLetras = 0;
            //Ingreso de plabra
            do
            {
                Console.WriteLine(" Favor ingrese una palabra con mas de 5 caracteres: ?   ");
                palabra = Console.ReadLine();
                //Cuento la cantidad de letras de la palabra
                cantidadLetras = palabra.Length;
                if (cantidadLetras>5)
                Console.WriteLine(" las 3 primeras letras de la palabra son: ");
                Console.Write(palabra[0]);
                Console.Write(palabra[1]);
                Console.Write(palabra[2]);
            }
            // si la ctad letras es menor a 5 volver a pedir ingresar palabra
            while (cantidadLetras < 5);
        }
    }
}


               
           