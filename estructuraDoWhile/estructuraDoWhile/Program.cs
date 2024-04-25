namespace estructuraDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // efectuar un programa do..while para contar el numero
            // de veces que se repite el bucle
            // 1.-declaracion de variables
            string linea;
            int x;
            int n;
            // 2.-iniciamos la variable
            x = 0;
            do // hacer como minimo una vez
            {
                // mostramos un mensaje por pantalla
                Console.WriteLine(" ingresar el numero para repetir bucle:?");
                // leemos el numero introducido
                linea=Console.ReadLine();
                //lo pasamos a int y lo guardamos en la variable
                x = int.Parse(linea);
                x = x + 1;
            }
            while (x > 10);
            { Console.WriteLine(" El bucle se repitio : " + (x - 1) + " veces");
             }
           
        }
    }
}
