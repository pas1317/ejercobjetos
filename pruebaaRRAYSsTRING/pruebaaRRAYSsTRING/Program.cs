namespace pruebaaRRAYSsTRING
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Florencia345";
            int largo;
            largo = nombre.Length;
            Console.WriteLine($"la palabra Florencia tiene {largo} letras");
            for ( int i=0; i<largo; i++)
            { 
                if (char.IsDigit(nombre[i]))
                {
                    Console.WriteLine(" Es una Digito");
                }
                else
                {
                    Console.WriteLine(" Es una letra");
                }
    
            }
            foreach ( char digito in nombre)
            {
                Console.Write(digito);
            }




























        }
    }
}
