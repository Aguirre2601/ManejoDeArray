
using System;
namespace ManejoDeArray
{
    public class ordenar
    {
        public static void ordena(int f, int c)
        {
            Variables.Array[f, c] = Variables.var_random_num.Next(1, 7);
            Variables.var_suma = Variables.var_suma + Variables.Array[f, c];
            Console.Write(" " + Variables.Array[f, c]);
        }
    }
}