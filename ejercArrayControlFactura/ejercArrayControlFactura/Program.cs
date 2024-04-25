using System.Numerics;

namespace ejercArrayControlFactura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Control de una factura
            // Declaracion de variables
            string Productos;
            string CantidadP;
            int Cantidad = 0;
            int Fi = 0;
            double Precio = 0;
            double Total = 0;
            double Paga = 0;
            int op;
            string opN;
            string Linea;
            Fi = 9;
            Paga = 0;
            // Escribir encabesamiento
            Console.SetCursorPosition(5, 4);
            Console.Write(" PRODUCTO  CANTIDAD  PRECIO       PRECIO");
            Console.SetCursorPosition(5,5);
            Console.Write("             kg o    xkg o unit    total");
            Console.SetCursorPosition(5,6);
            Console.Write("  descrip   numero     en $         en $");
            Console.SetCursorPosition(5, 7);
            Console.Write("*******************************************");
            do
            {
                Console.SetCursorPosition(7, Fi);
                Productos = Console.ReadLine();
                Console.SetCursorPosition(17, Fi);
                CantidadP = Console.ReadLine();
                Cantidad = int.Parse(CantidadP);
                Console.SetCursorPosition(28, Fi);
                Linea = Console.ReadLine();
                Precio = int.Parse(Linea);
                Total = Cantidad * Precio;
                Console.SetCursorPosition(39, Fi);
                Console.Write(Total);
                Paga = Paga + Total;
                Fi = Fi + 1;
                Console.SetCursorPosition(5, 21);
                Console.WriteLine("*************************************");
                Console.SetCursorPosition(5, 23);
                Console.WriteLine(" ingresa otro producto ingrese un numero :  ");
                Console.WriteLine(" 1= SI , 2=No");
                opN = Console.ReadLine();
                op = int.Parse(opN);
            }
            while (op == 1);
            Console.SetCursorPosition(15, 27);
            Console.WriteLine(" Total A Pagar :   " + Paga);
            Console.SetCursorPosition(15, 29);
            Console.WriteLine(" Pulse una Tecla: ");
            Console.ReadLine();
        }
    }
}
