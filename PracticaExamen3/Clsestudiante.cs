using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen3
{
    internal class Clsestudiante
    {

        // Atributos
        static private int cantidad = 2;
        static public string[] cedula = new string[cantidad];
        static public string[] nombre = new string[cantidad];
        static public int[] nota = new int[cantidad];


        // Constructor
        public Clsestudiante()
        {

        }


        // metodos

        public static void Inicializar()
        {
            cedula = Enumerable.Repeat("", cantidad).ToArray();
            nombre = Enumerable.Repeat("", cantidad).ToArray();
            nota = Enumerable.Repeat(20, cantidad).ToArray();


        }


        public static void Ingresar()
        {
            int cant = 1;
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Cedula {0}:", cant);
                cedula[i] = Console.ReadLine();
                Console.WriteLine("Nombre {0}:", cant);
                nombre[i] = Console.ReadLine();
                Console.WriteLine("Nota {0}:", cant);
                int.TryParse(Console.ReadLine(), out nota[i]);
                cant++;
            }
        }

        public static void Consultar( string id)
        {
            string ced = "";
            Console.Write("Digite la Cedula: ");
            ced = Console.ReadLine();

            for (int i = 0; i < cantidad; i++)
            {
                if (id.Equals(cedula[i]))
                {
                    Console.Write($"Nombre: {nombre[i]}");
                    Console.Write($"Nota: {nota[i]}");
                    break;
                }
            }
        }

        public static string Buscar()
        {
            string ced = "";
            Console.Write("Digite la Cedula: ");
            ced = Console.ReadLine();
            return ced;
        }

        public static void Modificar( string id)
        {
            
            for (int i = 0; i < cantidad; i++)
            {
                if (id.Equals(cedula[i]))
                {
                    Console.Write("Digite un nombre: ");
                    nombre[i] = Console.ReadLine();
                    Console.Write("Digite la nota: ");
                    int.TryParse(Console.ReadLine(), out nota[i]);
                    break;
                }
            }

        }



    }
}
