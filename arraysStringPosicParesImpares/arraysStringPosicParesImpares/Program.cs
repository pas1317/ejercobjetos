using System.Runtime;

namespace arraysStringPosicParesImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // vamos a crear un arrays de caracteres y vamos a mostrar por
            // pantalla las posiciones `pares y impares
            //declaracion de arrays
            string[] miCadena = new String[10];
            int largo;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            // asignacion de valores
            miCadena[0] = "12/12/23";
            miCadena[1] = "pedro";
            miCadena[2] = "ahora voy";
            miCadena[3] = "1245";
            miCadena[4] = "estoy en 20 minutos";
            miCadena[5] = "34+45";
            miCadena[6] = "alicia12";
            miCadena[7] = "no fumar";
            miCadena[8] = "1234/56";
            miCadena[9] = "son las 12 hs";
            //mostrar por pantalla arrays
            Console.WriteLine(miCadena[0]);
            Console.WriteLine(miCadena[1]);
            Console.WriteLine(miCadena[2]);
            Console.WriteLine(miCadena[3]);
            Console.WriteLine(miCadena[4]);
            Console.WriteLine(miCadena[5]);
            Console.WriteLine(miCadena[6]);
            Console.WriteLine(miCadena[7]);
            Console.WriteLine(miCadena[8]);
            Console.WriteLine(miCadena[9]);
            /// para determinar registros pares e registros impares
            largo = miCadena.Length;
            for (int i = 0; i < largo; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(" las siguiente cadenas esta en posicion par   " + miCadena[i]);
                }
                else
                {
                    Console.WriteLine(" las siguiente cadenas esta en posicion impar   " + miCadena[i]);
                }
            }
        }
    }
}

