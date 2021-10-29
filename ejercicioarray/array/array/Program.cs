using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros;
            Console.WriteLine("Indique el tamaño del array: ");
            int tamano = int.Parse(Console.ReadLine());
            numeros = new int[tamano];
            Console.WriteLine("Indique el número: ");
            int num = int.Parse(Console.ReadLine());
            int multi = 1;

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i]= multi * num;
                Console.Write(numeros[i] + ",");
                multi++;
            }
            Console.ReadKey();





        }
    }
}
