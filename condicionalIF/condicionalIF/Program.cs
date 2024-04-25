 namespace condicionalIF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string edadTexto; 
            
            
            Console.WriteLine(" favor ingrese su edad"); // LE PIDO POR PANTALLA QUE INGRESE LA EDAD
            edadTexto= Console.ReadLine();    // le pido por pantalla la edad
             
                     if(int.Parse(edadTexto) <18)       // Si (if) es menor a 18 años y transformo la variable string en numerica
                      {
                       Console.WriteLine(" Es menor de edad");      // si cumple escribe
                      }
                       else          // sino (else) cumple
                        { 
                        Console.WriteLine(" Es mayor de edad");   // SSi no cumple escribe
            }      
        }
    }
}
