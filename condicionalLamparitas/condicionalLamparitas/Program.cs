namespace condicionalLamparitas
{
    internal class Program
    {
        static void Main(string[] Args)
        { 

              //venta lamparas. registra marca y cantidad precio lampara=150
             //calcular el precio total de venta aplicando un descuento si corresponde
             // si compra 6 lamparas o mas descuento 50%
             // si compra 5 lamparas  ArgentinaLuz descuento 40% ,otra marca 30%
             // si conmpra 4 lamparas argentinaLuz  0 FelipeLamparas 25% , otra marca 20%
            // si compra 3 lamparas argentinaLuz 15% , FelipeLamparas 10% otra marca 5%
            //si el importe final c descuento es mayor a $950 paga impusto 10%
            // informar cantidad vendida , marca , total s desc, desc, tot c desc si paga impuesto y total a pagar
            int cantLampNum;
            string marca;
            string cantLamp = " ";
            int precioTotal;
            int precio;
            double descuento;
            double descuentoPrecio;
            double precioTotalCDescuento;
            double precioFinal;
            double impuesto;
            descuento = 0; 
            precio = 150;
              
            Console.WriteLine(" favor indique marca de lampara:?");
            marca = Console.ReadLine();
            Console.WriteLine("favor indique cantidad de lamparas:?");
            cantLamp = Console.ReadLine();
            cantLampNum = int.Parse(cantLamp);
            if (cantLampNum >= 6)
            {
                descuento = 0.5;
            }
            else
            {
                if (cantLampNum == 5)
                {
                    if (marca == "ArgentinaLuz")
                    {
                        descuento = 0.6;
                    }
                    else
                    {
                        descuento = 0.7;
                    }
                }
                else
                {
                    if (cantLampNum == 4)
                    {
                        if ((marca == "ArgentinaLuz")||(marca=="FelipeLamparas"))
                        {
                            descuento = 0.75;
                        }
                        else
                        {
                            descuento = 0.8;
                        }
                    }
                    else
                    {
                        if (cantLampNum == 3)
                        {
                            if (marca == "ArgentinaLuz")
                            {
                                descuento = 0.85;
                            }
                            else
                            {
                                if (marca == "FelipeLamparas")
                                {
                                    descuento = 0.9;
                                }
                                else
                                {
                                    descuento = 0.95;
                                }
                            }
                        }
                    }
                }
            }
            precioTotal = cantLampNum * precio;
            descuentoPrecio = (1 - descuento) * precioTotal;
            precioTotalCDescuento = precioTotal - descuentoPrecio;
            if (precioTotalCDescuento > 950)
            {
                 impuesto = precioTotalCDescuento * 0.1;
                 precioFinal = precioTotalCDescuento + impuesto;
            }
            else
            {
                impuesto = 0;
                precioFinal = precioTotalCDescuento;
            }
            Console.WriteLine ($"se vendieron: " + (cantLampNum) + "lamparas , de marca:  " +(marca));
            Console.WriteLine($" precio total sin descuento   " + (precioTotal) + "pesos");
            Console.WriteLine($"el descuento efectuado fue :   " + (descuentoPrecio) + "pesos");
            Console.WriteLine($"precio con descuento :   " + (precioTotalCDescuento) + "pesos");
            Console.WriteLine($" ud. pago de impuestos .   " + (impuesto) + "pesos");
            Console.WriteLine($"precio total a pagar :  " + (precioFinal) + "pesos");
        }
    }
}
   



































































