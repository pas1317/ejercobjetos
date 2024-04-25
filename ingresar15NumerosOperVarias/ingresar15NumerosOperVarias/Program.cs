namespace ingresar15NumerosOperVarias2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ingresar 15 numeros y determinar:
            //a.suma de los negativos
            //b.suma de los positivos
            //c.-cantidad positivos
            //d.- cantidad negativos
            //e.-cantidad de ceros
            //f.-cantidad de numeros pares.-
            // g.-promedio de positivos
            // h.- promedio de negativos
            // g.-diferencia entre positivos y negativos
            // h.- numero maximo
            // i de los negativos el minimo
            //Definir variables
            int i;
            string iN;
            int sumaPos = 0;
            int sumaNeg = 0;
            int cantPos = 0;
            int cantNeg = 0;
            int cantCeros = 0;
            int cantNPares = 0;
            int promPos = 0;
            int promNeg = 0;
            int difPosNeg = 0;
            int nMaximo  ;
            nMaximo = 0;
            int nMinNeg = 0;
            int nMinimo = 0;
            int nMax =0 ;
            bool maximo;
            bool minimo;
            maximo = true;
            minimo = true;
            int xi;
            int nM;
            for ( xi= 0; xi<15;xi++)
            { Console.WriteLine("favor ingrese un numero entre -1000 y + 1000 entero:?");
              iN = Console.ReadLine();
              i = int.Parse(iN);
              if(( i%2)==0)
              {
                cantNPares = cantNPares + 1;
              }
              if (i < 0)
                {
                    sumaNeg = sumaNeg + i;
                    cantNeg = cantNeg + 1;
                                      
                }
                else
                { if (i == 0)
                    {
                        cantCeros = cantCeros + 1;
                    }
                    else
                    {
                        cantPos = cantPos + 1;
                        sumaPos = sumaPos + i;
                    }
                }
            }
            promPos = sumaPos / cantPos;
            promNeg = sumaNeg / cantNeg; 
            difPosNeg = sumaPos - sumaNeg;
            Console.WriteLine("La suma de los numeros negativos es igual a:  " + sumaNeg);
            Console.WriteLine(" la suma de los  numeros positivos es igual a :   " + sumaPos);
            Console.WriteLine(" la cantidad de numeros positivos esigual a:  " + cantPos);
            Console.WriteLine("La cantidad de numeros negativos es igual a :  " + cantNeg);
            Console.WriteLine(" La cantidad dfe ceros es igual a .  " + cantCeros);
            Console.WriteLine(" La cantidad de numeros pares es igual a :  " + cantNPares);
            Console.WriteLine(" El promedio de numeros positivos es igual a:  " + promPos);
            Console.WriteLine(" El promedio de los numeros negativos es igual a :" + promNeg);
            Console.WriteLine(" La diferencia entre numeros positivos u negativos es igual a :  " + difPosNeg);
            Console.WriteLine(" El numero positivo maximo es igual a : " + nMaximo);
            Console.WriteLine("El numero menor de los negativos es igual a:  " + nMinimo);

        }
    }
}
