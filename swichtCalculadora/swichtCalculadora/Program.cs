namespace swichtCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Diseñar una calculadora que permita sumar , RESTAR,
            // MULTIPLICAR , DIVIDIR Y ELEVAR A LA POTENCIA 2 NUMEROS
            // recordar que no se puede dividir por " 0"
            //declaracion de variables
            int opcion;
            double numUno;
            double numDos;
            double resultado;
            string mensaje;
            string opcionN;
            string numUnoN;
            string numDosN;
            // pantalla de presentacion
            Console.WriteLine(" ******CALCULADORA******");
            Console.WriteLine(" 1.- SUMAR");
            Console.WriteLine(" 2.- RESTAR");
            Console.WriteLine(" 3.- MULTIPLICAR ");
            Console.WriteLine("4.- DIVIDIR ");
            Console.WriteLine("5.- Elevar a una potencia");
            Console.WriteLine("**************************");
            // Ingreso de datos -opcion
            Console.WriteLine(" Elija una opcion del 1 al 5 :? ");
            opcionN = Console.ReadLine();
            opcion = int.Parse(opcionN);
            //Pedimos ahora los numeros a operar
            Console.WriteLine("favor ingrese el 1er numero:?  ");
            numUnoN = Console.ReadLine();
            numUno = double.Parse(numUnoN);
            Console.WriteLine(" Favor ingrese el 2do numero: ? ");
            numDosN = Console.ReadLine();
            numDos = double.Parse(numDosN);
            // Desarrollo evaluamos las opciones
            switch (opcion)
                {
                case 1:
                    resultado = numUno + numDos;
                    Console.WriteLine(" el resultado de la suma es: " + resultado);
                    break;
                case 2:
                    resultado = numUno - numDos;
                    Console.WriteLine(" el resultado de la resta es: " + resultado);
                    break;
                case 3:
                    resultado = numUno * numDos;
                    Console.WriteLine(" el resultado de la multiplicacion es: " + resultado);
                    break;
                case 4:
                    resultado = numUno / numDos;
                    Console.WriteLine(" el resultado de la division es: " + resultado);
                    break;
                case 5:
                    resultado = Math.Pow(  numUno, numDos);
                    Console.WriteLine(" el resultado de elevar  es: " + resultado);
                    break;
                default:
                    Console.WriteLine(" seleccione una opcion correcta");
                    break;
                }

        }
    }
}
