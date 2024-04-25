namespace ejercArrayNombrePrimeraLetraMayuscula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result="";
            int cantidadLetras = 0;
            bool setUpper = true;
            Console.WriteLine(" favor ingrese su nombre:?");
            result = Console.ReadLine();
            cantidadLetras = result.Length;
            for (int i = 0; i < result.Length; i++)
            {
                if (!result[i].ToString().Equals("   "))
                {
                    result += setUpper ? result[0].ToString().ToUpper() : result[0].ToString();
                    setUpper = false;
                }
                else
                {
                    result += " ";
                    setUpper = true;
                }
                Console.WriteLine(result);

            }
        }
    } 
}