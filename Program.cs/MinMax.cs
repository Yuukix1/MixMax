using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nyilvannem
{
    internal class MinMax
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[10]; 

           
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 101);
            }

            
            int minValue = array[0];
            int maxValue = array[0];

            
            foreach (int num in array)
            {
                if (num < minValue) minValue = num;
                if (num > maxValue) maxValue = num;
            }

            
            Console.WriteLine("Generált tömb: " + string.Join(", ", array));
            Console.WriteLine("Legkisebb elem: " + minValue);
            Console.WriteLine("Legnagyobb elem: " + maxValue);

            
            Console.WriteLine("Nyomj meg egy gombot a kilépéshez...");
            Console.ReadLine();
        }
    }
}

