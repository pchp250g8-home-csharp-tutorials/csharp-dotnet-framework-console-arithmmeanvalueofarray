using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmMeanValueOfArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Input a count of elements");
            Int32.TryParse(Console.ReadLine(), out var nElems);
            var iArray = new int[nElems];
            var oRnd = new Random();
            for (int i = 0; i < nElems; i++)
            {
                var nItem = oRnd.Next(1, 100);
                iArray[i] = nItem;
            }
            var nSum = 0;
            for (int i = 0; i < nElems; i++)
            {
                nSum += iArray[i];
                Console.Write(iArray[i] + " ");
            }
            float fltMeanVal = (float)nSum / nElems;
            Console.WriteLine($"\r\nThe Sum of {nElems} elements of the array is:{nSum}");
            Console.WriteLine($"The Mean Value of {nElems} elementns of array is:{fltMeanVal}");
            Console.Read();
        }
    }
}
