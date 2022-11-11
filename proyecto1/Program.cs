using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarando las variables
            string nombreAlumno, primerApellido, segundoApellido, matricula;
            double califU4, califU1, califU2, califU3, califU5, califFinal;


            //Pidiendo la informacion al usuario
            Console.WriteLine("Ingrese su nombre y despues presione ENTER");
            nombreAlumno = Console.ReadLine();

            Console.WriteLine("Ingrese su primer apellido y despues presione ENTER");
            primerApellido = Console.ReadLine();

            Console.WriteLine("Ingrese su segundo apellido y despues presione ENTER");
            segundoApellido = Console.ReadLine();

            Console.WriteLine("Ingrese su Matricula y despues presione ENTER");
            matricula = Console.ReadLine();

            //cambiando el color de la consola y limpiandola
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();

            //Pidiendo las calificaciones del usuario
            Console.WriteLine("NOTA: Las calificaciones deberan ser ingrasadas en una escal del 1 al 10 \n");

            Console.WriteLine("Ingrese su calificacion en la unidad 1 y despues presione ENTER");
            califU1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese su calificacion en la unidad 2 y despues presione ENTER");
            califU2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese su calificacion en la unidad 3 y despues presione ENTER");
            califU3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese su calificacion en la unidad 4 y despues presione ENTER");
            califU4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese su calificacion en la unidad 5 y despues presione ENTER");
            califU5 = Convert.ToDouble(Console.ReadLine());

            //Sacar el promedio de las calificaciones
            califFinal = (califU1 + califU2 + califU3 + califU4 + califU5)/5;

            //comparando la calificacion
            if (califFinal >= 7)
            {

                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();

                Console.WriteLine("\n \t Felicidades, usted ha aprobado la materia!");

                Console.WriteLine("\n Nombre: {0}. \n Primer Apellido: {1}. \n Segundo Apellido: {2}. \n Matricula: {3}. \n Calificacion Final: {4}.", nombreAlumno, primerApellido, segundoApellido, matricula, califFinal);
                Console.ReadKey();

            }

            //por si no aprueba
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();

                Console.WriteLine("\n \t Lo sentimos, usten no alcanza a promediar, debera recursar la materia");
                Console.ReadKey();

            }


        }
    }
}
