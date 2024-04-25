// Una tienda ha puesto en oferta la venta de ciertos productos
// ofreciendo un descuento del 15%  por la compra de mas de 3 docenas
// 10% en caso contrario.-
//Ademas se obsequia una unidad del producto por docena a partir de 3.-
// Determinar el monto de la compra, el monto del descuento , el monto a pagar.-
//El numero de unidades de obsequio.-
namespace tiendaProductoDescuento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cantidad;
            double precio;
            double total;
            double pago;
            double descuento;
            double regalo;
            //float producto;
            string nombre;
            Console.WriteLine(" Ingrese el nombre del producto");
             nombre=Console.ReadLine();
            Console.WriteLine("ingrese el precio unitario del producto");
            precio = double.Parse(Console.ReadLine());
            Console.WriteLine(" Ingrese la cantidad vendida");
            cantidad = double.Parse(Console.ReadLine());
            total = precio * cantidad;
            Console.WriteLine("el importe es : " + total);
            if (cantidad >= 36)
            {
                Console.WriteLine(" tiene descuento de un " + "nombre");
                descuento = total * 0.15;
                Console.WriteLine(" El descuento es de 15%" + descuento + "pesos");
                regalo = (cantidad / 12) - 3;
                Console.WriteLine(" ademas se le regalaron :" + regalo + "unidades");
            }
            else
            {
                Console.WriteLine(" tiene  regalo de un " + "nombre");
                descuento = total * 0.1;
                Console.WriteLine(" El descuento es de 10% " + descuento + "pesos");
            }
            pago = total - descuento;
            Console.WriteLine(" El total a pagar es: " + pago + " pesos");
             
        }
    }
}





