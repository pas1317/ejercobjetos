// Por teclado se ingresa el valor de la hora de un empleado.
//Posteriormente , se ingresa nombre, antiguedad, y ctad horas
//trabajadas en el mes.Se pide calcular el importe a cobrar ,
// hay que sumarle al total  la cantidad de años trabajados 
//multiplicado  x $30 y al total restarle el 30$ en calidad de
//impuestos. Imprimir el recibo con el nombre , la antiguedad ,
//valor de hora , total a cobrar en bruto , Valor neto a cobrar.-
using System.Numerics;

namespace empleado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            float valorHora;
            float horasTrabajadas;
            float   antiguedad;
            float total;
            float netoACobrar;
            float descuento;
            Console.WriteLine(" Favor ingrese el nombre del empleado");
            nombre = Console.ReadLine();
            Console.WriteLine(" Favor ingrese el valor de la hora :?");
            valorHora = float.Parse(Console.ReadLine());
            Console.WriteLine("Favor ingrese la antiguedad ( en años) :?");
            antiguedad = int.Parse(Console.ReadLine());
            Console.WriteLine("favor ingrese las horas trabajadas:?");
            horasTrabajadas = float.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(" nombre del empleado     " + nombre);
            Console.WriteLine(" Antiguedad    " + antiguedad +"años");
            Console.WriteLine(" valor hora    " + valorHora  + "pesos");
            total = (valorHora * horasTrabajadas) + (30 * antiguedad);
            netoACobrar = (total * 87) / 100;
            Console.WriteLine(" el Total Bruto es de:    " + total + "pesos");
            Console.WriteLine("el NetoA cobrar es: "    + netoACobrar + "pesos");
            descuento = total - netoACobrar;
            Console.WriteLine("El descuento efectuado es de:     " + descuento + "pesos");
        }
    }
}
