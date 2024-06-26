﻿namespace challenges_and_data_structures2
{
    internal class Program3
    {
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

        static void MostFrequentNumber()
        {
            int[] numbers = { 1, 1, 2, 2, 3, 3, 3, 1, 5, 5, 6, 6, 7, 8, 2, 1, 1 };
            

            int maxCount = 0;
            int mostFrequentNumber = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j] == numbers[i])
                    {
                        count++;
                    }
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    mostFrequentNumber = numbers[i];
                }
            }
            Console.WriteLine("The frequent number is : " + mostFrequentNumber);
        }

        static void MiddleValue() {

            Console.WriteLine("Please enter the length of the array:");
            int arrLength = Convert.ToInt16(Console.ReadLine());
            int[] arrNumber = new int[arrLength];

            Console.WriteLine("Please enter the array values:");
            for (int i = 0; i < arrLength; i++)
            {
                arrNumber[i] = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine("Please enter the value you want to enter in the middle of the array:");
            int newNumber = Convert.ToInt16(Console.ReadLine());

            int midIndex = arrLength / 2;
            int[] newArr = new int[arrLength + 1];
            string oddOrEven = arrLength % 2 == 0 ? "even" : "odd";

            for (int i = 0; i <= arrLength; i++)
            {
                if (i == midIndex && oddOrEven == "even")
                    newArr[i] = newNumber;
                else if (i > midIndex)
                    newArr[i] = arrNumber[i - 1];
                else if(i < midIndex)
                    newArr[i] = arrNumber[i];
                else if (i == midIndex && oddOrEven == "odd")
                {
                    newArr[i] = arrNumber[i];
                    newArr[i + 1] = newNumber;
                    i++;
                }
            }

            Console.Write("The new array with the new number : ");
            foreach (int num in newArr)
            {
                Console.Write(num + " ");
            }
        }

        static int[] FindDuplicates(int[] exampleArray)
        {   
            int n = exampleArray.Length;
            bool[] seen = new bool[n];
            bool[] added = new bool[n];
            int[] tempArray = new int[n];
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (exampleArray[i] == exampleArray[j] && !added[j])
                    {
                        if (!seen[i])
                        {
                            tempArray[count++] = exampleArray[i];
                            added[i] = true;
                        }
                        seen[j] = true;
                        added[j] = true;
                    }
                }
            }

            int[] resultArray = new int[count];
            for (int i = 0; i < count; i++)
            {
                resultArray[i] = tempArray[i];
            }

            return resultArray;
        }
    }
}