using System;

namespace L1_JLDRL_1247723
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo soy Ruano");
                Console.ReadKey();

            Console.WriteLine();
                Console.WriteLine("Hola mundo");
                Console.WriteLine("soy Ruano");
            /*Cambia de línea al finalizar la sentencia*/
            Console.WriteLine();
                Console.Write("Hola Mundo");
                Console.Write(" soy Ruano");
            /*Lo escribe todo seguido, puede ser reemplazada si se escribe de forma seguida otra línea*/
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Ingrese su nombre: ");
                String NOMBRE = Console.ReadLine();
                Console.ReadKey();

            Console.WriteLine();
                Console.WriteLine("Hola mundo");
                Console.WriteLine("soy "+NOMBRE);
            /*Cambia de línea al finalizar la sentencia*/
            Console.WriteLine();
                Console.Write("Hola Mundo");
                Console.Write(" soy "+NOMBRE);
            /*Lo escribe todo seguido*/
                Console.ReadKey();



        }
    }
}
