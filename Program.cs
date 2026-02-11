using System; 

namespace ManejoDeArray
{
    class Program
    {
        public static void Main(string[] args)
        {
            Variables.Array = new int[4, 4];
            Variables.var_random_num = new Random();
            Variables.var_suma = 0;
            Console.WriteLine("Ejercicio Número 1: ");
            for (int f = 0; f < 4; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    ordenar.ordena(f, c);
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            Console.WriteLine("{0}", Variables.var_suma);
            Console.WriteLine("Presione cualquier tecla para SALIR");
            Console.ReadKey();
        }
    }
}
