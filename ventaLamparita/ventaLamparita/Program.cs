namespace ventaLamparita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string marca;
            double descuento;
            double precioTotal;
            double ibb;
            double precioFinal;
            double cantidadNum;
            double precio;
            double precioCDescuento;
            double descuentoPrecio;
            double descuentoIbb;
            precio = 150;
            descuentoIbb = 0.1;
            // proceso
            Console.WriteLine(" indique marca de lamparas a comprar:?  ( ArgentinaLuz,FelipeLamparas o otraMarca)");
            marca = Console.ReadLine();
            Console.WriteLine(" Indique cantidad de lamparas a comprar:?");
            cantidadNum = double.Parse(Console.ReadLine());
            precioTotal = cantidadNum * precio;
            if (cantidadNum >= 6)
            {
                descuento = 0.5;
                precioCDescuento = precioTotal * descuento;
                descuentoPrecio = precioTotal - descuento;
            }
            else
            {
                if (cantidadNum == 5)
                {
                    if (marca == "ArgentinaLuz")
                    {
                        descuento = 0.6;
                        precioCDescuento = precioTotal * descuento;
                        descuentoPrecio = precioTotal - descuento;
                    }
                    else if (marca != "ArgentinaLuz")
                    {
                        descuento = 0.7;
                        precioCDescuento = precioTotal * descuento;
                        descuentoPrecio = precioTotal - descuento;
                    }
                    else if (cantidadNum == 4)
                    {
                        if (marca == "ArgentinaLuz")
                        {
                            descuento = 0.75;
                            precioCDescuento = precioTotal * descuento;
                            descuentoPrecio = precioTotal - descuento;
                        }
                        else if (marca == "FelipeLamparas")
                        {
                            descuento = 0.75;
                            precioCDescuento = precioTotal * descuento;
                            descuentoPrecio = precioTotal - descuento;
                        }
                        else if (marca != "otraMarca")
                        {
                            descuento = 0.8;
                            precioCDescuento = precioTotal * descuento;
                            descuentoPrecio = precioTotal - descuento;
                        }
                        else if (cantidadNum == 3)
                        {
                            if (marca == "ArgentinaLuz")
                            {
                                descuento = 0.85;
                                precioCDescuento = precioTotal * descuento;
                                descuentoPrecio = precioTotal - descuento;
                            }
                            else if (marca == "FelipeLamparas")
                            {
                                descuento = 0.9;
                                precioCDescuento = precioTotal * descuento;
                                descuentoPrecio = precioTotal - descuento;
                                descuentoPrecio = precioTotal - descuento;
                            }
                            else
                            {
                                descuento = 0.95;
                                precioCDescuento = precioTotal * descuento;
                                descuentoPrecio = precioTotal - descuento;
                            }
                            Console.WriteLine($"descuento efectuado: " + descuentoPrecio + "pesos");
                            Console.WriteLine($"precio con descuento :  " + precioCDescuento + " Pesos");
                        }
                    }
                    Console.WriteLine($"se vendieron:  " + cantidadNum + "lamparitas , de marca" + marca);
                    Console.WriteLine($"precio total sin descuento" + precioTotal);
                    if (precioTotal > 950)
                    {
                        ibb = precioTotal * descuentoIbb;
                        precioFinal = precioTotal + ibb;
                        Console.WriteLine($"pago de ingresos brutos :" + ibb + "pesos");
                    }
                    else
                    {
                        precioFinal = precioTotal;
                    }
                    Console.WriteLine($" no pago ingresos brutos");
                    Console.WriteLine($"precio total a pagar , " + precioFinal + "pesos");
                }
            }
        }
    }
}








