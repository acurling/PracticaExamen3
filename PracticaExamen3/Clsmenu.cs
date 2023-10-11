using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen3
{
    internal class Clsmenu
    {
        // delimitadores de acceso public private protected
        // public = lo puedo visualizar en todas las demas clases
        // private = lo puedo visualizar en la clase en la que lo cree
        // protected = Lo puedo visual la clase que lo cree yla clase que hereda

        private static int opcion = 0;   // global

        // constructor
        public Clsmenu() { }
        public static void Desplegar()
        {

            do
            {
                Console.WriteLine("1- Inicializar arreglos");
                Console.WriteLine("2- Incluir Estudiantes");
                Console.WriteLine("3- Modificar Estudiantes");
                Console.WriteLine("4- Consultar Estudiantes");
                Console.WriteLine("5- Salir");
                int.TryParse(Console.ReadLine(), out opcion); // "a"==> "a"
                switch (opcion)
                {
                    case 1: Clsestudiante.Inicializar(); break;
                    case 2: Clsestudiante.Ingresar(); break;
                    case 3: Clsestudiante.Modificar(Clsestudiante.Buscar()); break;
                    case 4: Clsestudiante.Consultar(Clsestudiante.Buscar()); break;
                    default:
                        Console.WriteLine("caracter no valido");
                        break;
                }
            } while (opcion != 5);

        }
    }
}
