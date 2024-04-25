namespace bucleForSerieFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cree un programa que muestre loa n primeros numeros de la serie Fibonacci
            // donde n sera definido por el usuario
            // Fibonassi es una serie de 2 numeros  que empieza o y 1 y el
            // siguiente numero es la suma de los 2 anteriores.
            // ej : 0,1,2,3,5,8,13,21,34,....
            //Definimos nuestras variable
            int currentValor = 0;
            int proximoValor = 1;
            int final;
            int ffinal;
            int i;
            int auxiliar = 0;
            string inicialN;
            string finalN;
             //Entrada de datos
            Console.WriteLine(" Cuantos numeros de la serie Fibonasi quiere ver ");
            finalN = Console.ReadLine();
            final = int.Parse(finalN);
            ffinal = final + 2;
            // nuestro indice va a empesar con 3 y finaliza con el ultimo".-
            Console.Write("serie Fibonassi " );
            Console.WriteLine(currentValor + " , " + proximoValor + " , ");
            for (i = 3; i <= ffinal; i++)
            {
                // guardamos el valor actual en el auxiliar
                auxiliar = currentValor;
                //actualizamos el valor actual con el siguiente
                currentValor = proximoValor;
                // por ultimo sumamos el valor anterior
                proximoValor = auxiliar + currentValor;
             Console.Write(proximoValor.ToString() + " , ");
            }
            // primera interaccion
            // auxiliar = 0 , currentValor=1 ,proximoValor=1
            // segunda interaccion
            // auxiliar=1 , CurrentValor=1 , proximoValor=2
            // tercera interaccion
            //auxiliar=1 , currentValor=2 , proximoValor=3
            // y asi sucesivamente
        }
    }
}
