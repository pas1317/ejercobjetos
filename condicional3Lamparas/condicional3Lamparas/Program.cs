using System.ComponentModel.Design;

namespace condicional3Lamparas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string marcaLamp;
            string cantidadTexto;
            double descuento;
            string precioUn;
             int precio;
            double precioTotal;
            double precioCDesc;
            double impuesto;
            double descEfect;
            double precioCImp;
            int cantidadNum;
            Console.WriteLine(" favor ingrese la marca");
            marcaLamp = Console.ReadLine();
            Console.WriteLine("favor ingrese la cantidad");
            cantidadTexto = Console.ReadLine();
            cantidadNum = int.Parse(cantidadTexto);
            Console.WriteLine("favor ingrese el precio unitario: ");
            precioUn = Console.ReadLine();
            precio = int.Parse(precioUn);
            if (cantidadNum >= 6)
            {
                descuento = 0.5;
            }
            else
                  if (cantidadNum == 5)
            {
                if (marcaLamp == "ArgentinaLuz")
                {
                    descuento = 0.4;
                }
                else
                    descuento = 0.3;
                if (cantidadNum == 4)
                {
                    if (marcaLamp == "ArgentinaLuz")
                    {
                        descuento = 0.25;
                    }

                }
                else
                           if (marcaLamp == "FelipeLamparas")
                {
                    descuento = 0.25;
                }
                else
                    descuento = 0.2;

                if (cantidadNum == 3)
                {
                    if (marcaLamp == " ArgentinaLuz")
                    {
                        descuento = 0.15;
                    }
                    else
                           if (marcaLamp == "FelipeLamparas")
                    {
                        descuento = 01;
                    }
                    else
                        descuento = 0.05;
                    precioTotal = precio * cantidadNum;
                    precioCDesc = precio * descuento;
                    descEfect = precioTotal - precioCDesc;
                    if (precioCDesc > 950)
                    {
                        impuesto = precioCDesc * 0.1;
                    }
                    else impuesto = 0;
                    precioCImp = precioCDesc + impuesto;
                    Console.WriteLine(" la cantidad de lamparas vendidas es : " + cantidadNum);
                    Console.WriteLine(" la marca de la lampara es:" + marcaLamp);
                    Console.WriteLine(" El Precio total es:" + precio + "pesos");
                    Console.WriteLine(" el descuento efectuado es:" + descEfect + "pesos");
                    Console.WriteLine(" El Precio con descuento es : " + precioCDesc + "pesos");
                    Console.WriteLine(" el precio final a pagar es :" + precioCImp + "pesos");
                    Console.WriteLine(" Ud. pago de impuestos :" + impuesto + "pesos");
                }

            }
        }
    }
}













































































































































































































































































































































 