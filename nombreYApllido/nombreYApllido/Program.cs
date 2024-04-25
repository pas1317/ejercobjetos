namespace nombreYApllido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string apellido;
            string nombre;
            string edad;
            int edadNum;
            Console.WriteLine(" favor ingrese su apellido");
            apellido = Console.ReadLine();
            Console.WriteLine(" favor ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("favor ingrese su edad");
            edad = Console.ReadLine();
            edadNum = int.Parse(edad);
            Console.WriteLine(" su nombre es completo es" + nombre + " " + apellido);
            Console.WriteLine(" uds. tiene :  " + edad + "de edad");
        }
    }
}
