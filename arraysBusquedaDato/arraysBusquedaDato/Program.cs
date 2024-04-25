namespace arraysBusquedaDato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // diseñar una programa , que dado un arrays de caracteres
            // pueda buscar y encontrar un caracterdeterminado
            //  Declaracion de variables
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            int largo;
            string[] Palabra = new String[8];
            Palabra[0] = " alberto";
            Palabra[1] = " pedro";
            Palabra[2] = " alfonso";
            Palabra[3] = " mabel";
            Palabra[4] = " mirta";
            Palabra[5] = " graciela";
            Palabra[6] = "anabela";
            Palabra[7] = " francisco";
            //defino ctad de caracteres delñ sring
            largo = Palabra.Length;
            int contador = 0;
            for (int i = 0; i < largo; i++)
            {
                Console.WriteLine(Palabra[i]);
                foreach (string dato in Palabra)
                {
                    if (dato == " mabel")
                    {
                        Palabra[contador] = ("mabel te encontre");
                    }
                    contador++;

                }
            }
                     
        }
    }

}
