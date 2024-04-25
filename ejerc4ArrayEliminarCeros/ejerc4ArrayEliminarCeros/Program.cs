namespace ejerc4Array 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Como se iniciala un string
            string palabra;
            string palabraModificada = string.Empty;
            // ingreso palabra
            Console.WriteLine(" Favor escriba una palabra:?   ");
            palabraModificada = Console.ReadLine();
            //escribo la palabra ingresada
            Console.WriteLine( " la palabra escrita es :" );
            // el string palabraModificada luego de entrar la palabra continua vacio
            Console.WriteLine( " la palabra modificada es :  " + palabraModificada);
        }
    }
}
