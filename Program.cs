using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_8_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            // nombre, carrera,facultad,edad,email,telefono 
            int cantidad;
            Console.WriteLine(" digite el numero de registros que decea digitar ");
            cantidad = int.Parse(Console.ReadLine());
            string[] nombres = new string[cantidad];
            string[] carrera = new string[cantidad];
            string[] facultad = new string[cantidad];
            int[] edad = new int[cantidad];
            string[] email = new string[cantidad];
            int[] telefono = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine(" digite el nombre ");
                nombres[i] = Console.ReadLine();
                Console.WriteLine(" digite la carrera ");
                carrera[i] = Console.ReadLine();
                Console.WriteLine(" digite la facultad ");
                facultad[i] = Console.ReadLine();
                Console.WriteLine(" digite la edad ");
                edad[i] =int.Parse( Console.ReadLine());
                Console.WriteLine(" digite el email ");
                email[i] = Console.ReadLine();
                Console.WriteLine(" digite el telefono");
                telefono[i] = int.Parse(Console.ReadLine());
                Console.Write(" ----nuevo----   ");


            }
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("nombre; " + nombres[i]+" | ");
                Console.Write("carreras " + carrera[i] + " | ");
                Console.Write("facultad " + facultad[i] + " | ");
                Console.Write("edad " + edad[i] + " | ");
                Console.Write("email " + email[i] + " | ");
                Console.Write("telefono " + telefono[i] + " | ");
                Console.Write("    ");


            }
            Console.ReadLine();
        }

    }
}
