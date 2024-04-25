namespace programaNombreEdad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            string edadTexto;       //si bien es un n. hago navar string
            int edadNumerica;          //transformo la variable en numerica
            Console.WriteLine(" favor escriba su nombre");      // le pido por pantalla el nombre
            nombre = Console.ReadLine();          //le digo que guarde lo que ingreso en la variable nombre
            Console.WriteLine(" favor escriba su apellido");      // le pido por pantalla el apellido
            apellido = Console.ReadLine();        // le digo que guarde lo que ingreso en la variable apellido
            Console.WriteLine(" favor ingrese la edad ");  // le pido por pantalla que ingrese la edad
            edadTexto = Console.ReadLine();    // le digo que guarde lo que ingreso en la varible edadTexto(string)
            int.Parse(edadTexto);       // transformo la var. edadTexto(string) en edadNumerica (int)
            Console.WriteLine( $"Su nombre completo es :{nombre} {apellido}, ud. tiene : {edadTexto} años"); 
            /// le digo que escriba por pantalla  " Su nombre completo es : ............, ud. tiene .....años.-

        }
    }
}
