namespace diasSemana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // hacer un programa en el cual ingresemos un numero del 1 al 7
            // y que me indique que dia de la semana es.-
            string numeroN;
            string dia;
            int numero;
            Console.WriteLine(" favor ingrese un numero del 1 al 7 :?");
            numeroN = Console.ReadLine();
            numero = int.Parse(numeroN);
            switch (numero)
            {
                case 1:
                    dia = " lunes";
                    break;
                case 2:
                    dia = "martes";
                    break;
                case 3:
                    dia = "miercoles";
                    break;
                case 4:
                    dia = "jueves";
                    break;
                case 5:
                    dia = "viernes";
                    break;
                case 6:
                    dia = "sabado";
                    break;
                case 7:
                    dia = "domingo";
                    break;
                default:
                    dia = "error ingrese un numeo solicitado";
                    break;
            }
                Console.WriteLine(" el numero   " + numeroN + "corresponde al dia   " + dia);
                 
    }
}
