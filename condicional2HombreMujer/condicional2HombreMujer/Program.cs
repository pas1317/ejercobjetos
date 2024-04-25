using System.ComponentModel.Design;
namespace condicional2HombreMujer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string edad;   // defino variables string
            string genero;
            int edadNum;   // defino a variable numerica edadNum
            Console.WriteLine("favor ingrese la edad");
            Console.WriteLine("en numeros");
            edad = Console.ReadLine();
            Console.WriteLine(" favor ingrese genero");
            Console.WriteLine("hombre o mujer ");
            genero = Console.ReadLine();
            edadNum = int.Parse(edad);                  // transformo edad de string a int(numerica)
            if (genero == "mujer" && edadNum <18)      // condicional if (else)     && and logico  variable string  entre""   
            {                                          //     variable num sin ""
                Console.WriteLine(" es mujer y menor de edad");
            }
            else
                   if (genero == "mujer" && edadNum > 18)
                   {
                           Console.WriteLine(" Es mujer y mayor de edad");
                    }
                    else
                          if (genero == "hombre" && edadNum>18)
                          {
                                Console.WriteLine(" es hombre y mayor de edad ");
                          }
                          else 
                                Console.WriteLine(" es hombre y menor de edad");
        }-

    }
                 
}
 