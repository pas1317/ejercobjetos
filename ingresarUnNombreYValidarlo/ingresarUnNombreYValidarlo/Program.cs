namespace ingresarUnNombreYValidarlo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// ingresar por teclado un nombre y validarlo
            ///  Declaracion de variables
            string nombre;
            bool esIncorrecto;
            //desarrollo
            do
            {
                esIncorrecto = false;
                Console.WriteLine(" favor ingrese su nombre:       ");
                nombre = Console.ReadLine();
                for (int i = 0; i < nombre.Length; i++)
                {
                    if (!char.IsLetter(nombre[i]))
                    {
                        Console.WriteLine("el nombre debe tener solo letras");
                        esIncorrecto = true;
                        break;
                    }
                }
            }
            while (esIncorrecto);
            Console.WriteLine($"el nombre validado es:    {nombre}");
        }
    }
}