namespace challenges_and_data_structures2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayReversal();
            //MaximumValue();
            RemoveMiddleValue();
        }

        static void ArrayReversal()
        {
            Console.WriteLine("Please enter the length of the array you want to reverse:");
            int arrLength = Convert.ToInt16(Console.ReadLine());
            int [] arrNumber = new int[arrLength];

            Console.WriteLine("Please enter the array values:");
            for (int i = 0; i < arrLength; i++)
            {
                arrNumber[i] = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine("This is the reversed array:");
            int[] reverseArray = new int[arrNumber.Length];
            int j = 0;

            foreach (int i in arrNumber)
            {
                reverseArray[j] = arrNumber[arrNumber.Length - 1 - j];
                j++;
            }
            foreach (int i in reverseArray)
            {
                Console.WriteLine(i);
            }
        }

        static void MaximumValue()
        {
            Console.WriteLine("Please enter the length of the array:");
            int arrLength = Convert.ToInt16(Console.ReadLine());
            int[] arrNumber = new int[arrLength];

            Console.WriteLine("Please enter the array values:");
            for (int i = 0; i < arrLength; i++)
            {
                arrNumber[i] = Convert.ToInt16(Console.ReadLine());
            }

            int max = 0;
            foreach (int i in arrNumber)
            {
                if (max < i)
                {
                    max = i;
                }
            }
            Console.WriteLine("The max number:" + max);
        }

        static void RemoveMiddleValue()
        {
            Console.WriteLine("Please enter the length of the array:");
            int arrLength = Convert.ToInt16(Console.ReadLine());
            int[] arrNumber = new int[arrLength];

            Console.WriteLine("Please enter the array values:");
            for (int i = 0; i < arrLength; i++)
            {
                arrNumber[i] = Convert.ToInt16(Console.ReadLine());
            }

            int newLength = arrLength % 2 == 0 ? arrLength - 2 : arrLength - 1;
            int[] newArray = new int[newLength]; 

            // Find the middle index(es)
            int middleIndex1 = arrLength / 2;
            int middleIndex2 = (arrLength % 2 == 0) ? middleIndex1 - 1 : middleIndex1;

            for (int i = 0 , j = 0 ; i < arrLength; i++)
            {
                if (i != middleIndex1 && i != middleIndex2)
                {
                    newArray[j] = arrNumber[i];
                    j++;
                }
            }

            Console.Write("The new array : ");
            foreach (int value in newArray)
            {
                Console.Write(value + " ");
            }
        }
    }
}
