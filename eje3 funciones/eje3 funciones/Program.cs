using System.Reflection.PortableExecutable;

namespace eje3_funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Se requiere la creacion de una funcion que cumpla con los
            //siguientes requisitos: debe recibir 3 parametros . valor(numerico),
            //porcentaje(numerico) y esAumento (Booleano).Si EsAumento es verdadero
            //la funcion debe aumentar el porcentaje al valor.
            //Si esAumento es falso  debe disminuir el valor.
            // El  valor una vez obtenido se debe retornar a la funcion.-
            string[] pedirDatos = new string[3];

            ///string[] pedirDatos = new string[3];
            //    pedirDatos[0] = "valor";
            //   pedirDatos[1] = "porcentaje";
            //  pedirDatos[3] = "esAumento";
            string valor;
            string porcentaje;
            string esAumento;

            bool esAumen = true;
            double val;
            double por;

            Console.WriteLine(" favor ingrese el valor :  ? ");
            valor = Console.ReadLine();
            val = double.Parse(valor);
            Console.WriteLine(" favor ingrese el porcentaje :   ?");
            porcentaje = Console.ReadLine();
            por = double.Parse(porcentaje);
            Console.WriteLine("favor ingrese esAumento): ? ");
            esAumento = Console.ReadLine();
            esAumen = bool.Parse(esAumento); 

            if (esAumen == true)
            {
                val = val + (val * por);
            }
            else
            {
                val = val - val * por;
            }
            Console.WriteLine(" el nuevo valor es igual" + val);
        }
    }
}
        