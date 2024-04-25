namespace estructuraBucleFor
{
    // estructura bucle for
    // crear un programa qure muestre los primeros 15 multiplos de 4.-
    internal class Program

    {
        static void Main(string[] args)
        {
            // Declaramos las variables
            int resultado;
            int i;
            // Solicitamos los datos al usuario
            Console.WriteLine("los primeros numeros multiplos de 4 son ,.");
            // nuestro indice empezara en 1 y terminara en 15 y su valor
            // se incremetara de a 1.-
            for (i = 1; i <= 15; i++)
            {
                resultado = i * 4;
                Console.WriteLine(resultado.ToString());
            }
        }

    }
}


             

