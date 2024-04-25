namespace estrutWhile8NumSumaYProm
{
    internal class Program
    {
        static void Main(string[] args)
        {   //realizar un programa que permita ingresar 8 numeros y
            //nos muestre la suma y el promedio de dichos numeros.-
            int x;
            int suma;
            int valor;
            int promedio;
            string valorX;
            suma = 0;
            promedio = 0;
            x = 0;
            while (x <= 8)
            {
                Console.WriteLine(" favor ingrese un numero");
                valorX = Console.ReadLine();
                valor = int.Parse(valorX);
                x = x + 1;
                suma = suma + valor;
            }
            promedio = suma / x;
            Console.WriteLine(" la suma de los 8 numeros es:    " + suma);
            Console.WriteLine(" el promedio de los 8 numeros es :   " + promedio);
        }
    }
}

