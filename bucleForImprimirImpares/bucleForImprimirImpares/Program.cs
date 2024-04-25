namespace bucleForImprimirImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Crear un programa que solicite un valor inicial y uno final  y que
            // me imprima los numeros impares en el rango ingresado
            // Ademas si el rango ingresado es incorrecto , mostrar mensaje.-
            // declaracion de variables
            int inicial;
            int final;
            int contadorImpares;
            string inicialS;
            String finalS;
            int i;
            contadorImpares = 0;
            // Solicitamos datos al usuario
            Console.WriteLine(" favor ingrese  rango inicial (valor minimo):?  ");
            inicialS = Console.ReadLine();
            inicial = int.Parse(inicialS);
            Console.WriteLine(" favor ingrese rango final( calor maximo) : ?  ");
            finalS = Console.ReadLine();
            final = int.Parse(finalS);
            // Declaracion del for
            // el valor inicial sera inicial
            // el valor final sera final
            // el paso sera de a 1
            for (i= inicial; i < final; i++) 
            { if (i % 2 != 0)
                    { Console.Write(i + " , ");
                    contadorImpares = contadorImpares + 1;
                }
                if (contadorImpares == 0)
                { Console.WriteLine(" el rango ingresado es invalido");
                }
            }
            Console.WriteLine("hay un total de " + contadorImpares + " de numeros impares");
        }
    }
}
