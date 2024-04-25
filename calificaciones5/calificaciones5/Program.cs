namespace calificaciones5
    //leer 5 calificaciones , calcular el promedio,y decir si alumno aprobo o reprobo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;
            int n3;
            int n4;
            int n5;
            Console.WriteLine(" ingrese la 1er. nota :?");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" ingrese la 2da. nota:?");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Ingrese la 3er. nota;?");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Ingrese la 4ta. nota:?");
            n4 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Ingrese la 5ta. nota:?");
            n5 = int.Parse(Console.ReadLine());
            int promedio = (n1 + n2 + n3 + n4 + n5) / 5;
            Console.WriteLine(" el promedio es : " + promedio);
            if ( promedio < 7 )
            {
                Console.WriteLine(" reprobo");
            } 
            else
            {
                Console.WriteLine(" APROBO");
            }
        }
    }
}
