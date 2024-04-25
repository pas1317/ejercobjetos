namespace switchingreseVocal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // crear un programa que permita ingresar una vocal
            // y te devuelva una palabra que empieze con esa vocal
            //definicion de variables
            string vocal;
            string palabra = "    "; 
            // Entrada de datos
            Console.WriteLine(" favor ingrese una vocal ");
            vocal= Console.ReadLine();
           switch (vocal)
            {
                case "A" or "a":
                    palabra = "Avion";
                    break;
                case "E" or "e":
                    palabra = "Enano";
                    break;
                case "I" or "i":
                    palabra = "Iman";
                    break;
                case "O" or "o":
                    palabra = "Objeto";
                    break;
                case "U" or "u":
                    palabra = "Union";
                    break;
                default:
                    Console.WriteLine(" Ingrese una vocal");
                    break;
            }
            Console.WriteLine("la vocal ingresada es   " + vocal);
            Console.WriteLine("   la palabra creada es " + palabra);
            
        }
    }
}
