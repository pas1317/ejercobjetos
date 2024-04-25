using System.ComponentModel.Design;

namespace loginUsuarioContraseña
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que simule un login para el usuario.-
            //en primer lugar el usuario debera crear una contraseña y luego
            //debera iniciar seccion: El usuario tendra 3 oportunidades para
            //escribir correctamente la contraseña, si no lo hace el programa
            //terminara en caso contrario le dara un mensaje de bienvenida
            // Declaracion de variables.-
            string nombreUsuarioGuardado;
            string contraseñaUsuarioGuardado;
            string nombreUsuario;
            string contraseñaUsuario;
            int intentos = 0;
            bool accesoOK = false;

            // En primer lugar le pedimos al usuario que registre una clave
            Console.WriteLine("*****Nueva cuenta de usuario*******");
            Console.WriteLine(" Favor ingrese su nombre y contraseña para iniciar seccion");
            Console.WriteLine(" USUARIO :   ");
            nombreUsuarioGuardado = Console.ReadLine();
            Console.WriteLine(" CONTRASEÑA ( 6 caracteres)");
            contraseñaUsuarioGuardado = Console.ReadLine();
            Console.WriteLine(" *** Cuenta creada Correctamente***");
            //Ahora vamos a simular el inicio de seccion
            //Declaramos nuestro bucle do..While
            do
            {
                Console.WriteLine("***bienvenido al programa....***");
                Console.WriteLine(" Ingrese su nombre y contraseña ");
                Console.WriteLine(" USUARIO : ");
                nombreUsuario = Console.ReadLine();
                Console.WriteLine(" CONTRASEÑA ");
                contraseñaUsuario = Console.ReadLine();
                // validamos si el nombre de usuario y contraseña son correctos
                if (nombreUsuario.Equals(nombreUsuarioGuardado) && contraseñaUsuario.Equals(contraseñaUsuarioGuardado))

                { //si esta ok , actualizamos nuestra variable
                    accesoOK = true;
                    Console.WriteLine(" Iniciaste seccion correctamente ");
                }
                else
                {
                    // en caso contrario , actualizamos nuestro contador de intentos
                    intentos = intentos + 1;
                    // ( o podemos colocar  intentos++;
                    Console.WriteLine(" usuario y/o Contraseñas incorrectos , vuelva a intentarlo? ..");
                }
                // En el pmo While tendremos que evaluar , si el intento fue exitoso y si el usuario
                // supero el numero de intentos
            }
            while ((!accesoOK) && (intentos < 3));
            // continuamos con el programa .Vamos a validar el 1er escenario
            if (accesoOK)
            {
                Console.WriteLine(" Bienvenido al sistema ");
            }
            else
            {
            }
            // validamos el 2do escenario
            if (intentos >= 3)
            {
                Console.WriteLine("ha realizado el maximo de intentos posibles permitidos ");

            }
        }
    }
}



