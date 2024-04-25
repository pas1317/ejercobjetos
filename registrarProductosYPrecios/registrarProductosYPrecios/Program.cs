namespace registrarProductosYPrecios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que le pida al usuario registrar productos y sus precios.
            //Cada vez que el usuario temine de regitrar un producto , el programa le debe
            //preguntar si desea registrr otro producto mas , si el usuario dice que si,
            //el programa debe registrr otro producto.-en caso contrario , el programa le mostrara
            //cuantos productos ha registrado y el `promedio de los precios y finalmente , terminara.-
            //Declaramos nuestras variables
            string nombreProducto;
            int contadorProducto =0;
            double precioProducto;
            double sumatoriaPrecioProducto = 0;
            double promedioPrecioProducto;
            char respuestaLetra='S';
            // Declaramos el bucle Do-While
            do
            {
                //Actualizamos los contadores
                contadorProducto = contadorProducto + 1;
                // Le pedimos los datos al usuario
                Console.WriteLine(" Producto n..:" + contadorProducto);
                Console.WriteLine(" Favor ingrese el nombre del producto:  ?  ");
                nombreProducto = Console.ReadLine();
                Console.WriteLine(" Favor ingrese el precio :  ? ");
                precioProducto = double.Parse(Console.ReadLine());
                // Sumamos los precios para encontrar la media
                //sumatoriaPrecioProducto += precioProducto;
                sumatoriaPrecioProducto = sumatoriaPrecioProducto + precioProducto;
                // Le preguntamos al usuario si quiere ingresar otro producto
                Console.WriteLine(" Desea ingresar otro producto : ? ");
                respuestaLetra = char.Parse(Console.ReadLine());
                //Convertimos a mayusculas para asegurarnos
                respuestaLetra = char.ToUpper(respuestaLetra);
            }
            while (respuestaLetra == 'S');

            // Si ya no desa registrar otro producto calculamos el precio promedio
            promedioPrecioProducto = sumatoriaPrecioProducto / contadorProducto;
            //Le mostramos al usuario informacion final
            Console.WriteLine("La cantidad de producto ingresado es de:   " + contadorProducto);
            Console.WriteLine(" El promedio de los precios es :...." + promedioPrecioProducto);
            
        }
    }
}
