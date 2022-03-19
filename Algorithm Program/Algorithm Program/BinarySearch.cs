using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Program
{
    internal class BinarySearch
    {
        public void Search()
        {
            Console.WriteLine("Enter Size of Array:");
            int size= Convert.ToInt32(Console.ReadLine());
            int[] array= new int[size];
            Console.WriteLine("Enter Elements of Array:");
            for (int i = 0; i < size; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter Elements That want to find:");
            int SearchElement=Convert.ToInt32(Console.ReadLine());
            Algori utility = new Algori();
            int index= utility.BinarySearch(array,0, size -1, SearchElement);
            if (index == -1)
            {
                Console.WriteLine("Element is not Present");
            }
            else
            {
                Console.WriteLine("& index of an array is" + index);
            }
        }
    }
}
