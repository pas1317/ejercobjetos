namespace funcionesEjerc3
{
    internal class Program
    {
        static void Main(string[] Pedir, string valor, string porcentaje, string esAumento)
        {
            //Se requiere la creacion de una funcion que cumpla con los
            //siguientes requisitos: debe recibir 3 parametros . valor(numerico),
            //porcentaje(numerico) y esAumento (Booleano).Si EsAumento es verdadero
            //la funcion debe aumentar el porcentaje al valor.
            //Si esAumento es falso  debe disminuir el valor.
            // El  valor una vez obtenido se debe retornar a la funcion.-

            bool esAumen;
            int val;
            int por;

            Console.WriteLine(" favor ingrese el valor :  ? ");
            valor = Console.ReadLine();
            val = int.Parse(valor);
            Console.WriteLine(" favor ingrese el porcentaje :   ?");
            porcentaje = Console.ReadLine();
            por = int.Parse(porcentaje);
            Console.WriteLine("favor ingrese esAumento): ? ");
            esAumento = Console.ReadLine();
            esAumen = bool.Parse(esAumento);
            if (esAumento == esAumento)
            {
                val = val + val * por;
            }
            else
            {
                val = val - val * por;
            }
            Console.WriteLine(" el nuevo valor es igual", val);




        }
    }
}
