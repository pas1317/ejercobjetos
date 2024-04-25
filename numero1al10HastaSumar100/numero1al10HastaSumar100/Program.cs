namespace numero1al10HastaSumar100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que vaya sumando numeros aleatorios entre 1 y 10 ,
            //hasta que la suma sea igual o mayor a 100.;
            //Definicion de variables
            int suma;
            int numeroRandom = 0;
            Random rnd = new Random();
            suma = 0;

            // declaramos nuestro d0-while
            do
            {
                //Asignamos un valor aleatorio
                numeroRandom = rnd.Next(1, 10);
                // Los mostramos por pantalla
                Console.WriteLine(" numero aleatorio generado:" + numeroRandom);
                // Procedemos a  sumar el valor
                suma += numeroRandom;
                // evaluamos que la suma sea menor a 100
                //si es verdadero este bloque se volvera a ejecutar
            }
            while (suma < 100);
            //si la condicion es falsa , continuara con el programa restante
            // mostramos la suma final
            Console.WriteLine(" La suma final es: " + suma);
        }
    }
}



