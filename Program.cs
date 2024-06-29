using challenges_and_data_structures2.Challenges.Common_Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Common-Elements
            int[] newArr = { 5, 10, 15, 20};
            int[] newArr2 = { 10, 15, 25};

            int[] output =  Program2.CommonElements(newArr, newArr2);
            Console.WriteLine("Input: [5, 10, 15, 20]");
            Console.WriteLine("Output: [" + string.Join(", ", output) + "]");

            // Find-Duplicates
            //int[] input1 = { 1, 2, 3, 1, 2, 3 };
            //int[] output1 = FindDuplicates(input1);
            //Console.WriteLine("Input: [16, 8 ,31, 17, 15, 23, 17, 8]");
            //Console.WriteLine("Output: [" + string.Join(", ", output1) + "]");

            //ArrayReversal();
            //MaximumValue();
            //RemoveMiddleValue();
            //MostFrequentNumber();
            //MiddleValue();
        }
    }
}
