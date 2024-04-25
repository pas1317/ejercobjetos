namespace funciones3CreacionFuncion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Se requiere la creacion de una funcion que cumpla con los
            // siguientes requisitos.debe recibir 3 parametros "valor numerico"
            // , "porcentaje"(numerico) y es aumento (booleano)
            // si es aumento es falso la funcion debe disminuir el cvalor
            // original aplicando el porcentaje dado
            // si es verdadero lo debe aumentar de identica forma
            // El resultado obtenido despues de aplicar el porcentaje
            // debe ser retornado a la funcion.-
            //definicion de variables
            int valNumerico;
            int vi;
            string valNumericoN;
            int porcentajeNum;
            string porcentajeNumN;
            bool esAumento = false;
            int cantidad =3;
            int veces ;
            string vecesN;
            int[]funcion = new int[cantidad];
            Console.WriteLine(" Favor escriba la cantidad de veces de la  funcion en la pantalla");
            vecesN = Console.ReadLine();
            veces = int.Parse(vecesN);
                        //creacion arrays
            for (int i = 0; i <= veces; i++)
            {

                //Ingreso de datos 
                Console.WriteLine(" Favor ingrese el valor numerico :.?   ");
                Console.ReadLine();
                funcion[cantidad] = funcion[cantidad] + 1;
                Console.WriteLine(" Favor ingrese el porcentaje :.?   ");
                Console.ReadLine();
                funcion[cantidad + 1] = funcion[cantidad + 1] + 1;
                Console.WriteLine(" Favor ingrese si es aumento ( true/false) :?   ");
                Console.ReadLine();
                funcion[cantidad + 2] = funcion[cantidad + 2] + 1;
                funcion[cantidad] =cantidad;
            }
        }
    }
}
