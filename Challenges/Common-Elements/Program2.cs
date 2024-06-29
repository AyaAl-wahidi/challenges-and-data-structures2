
namespace challenges_and_data_structures2.Challenges.Common_Elements
{
    public static class Program2
    {
        public static int[] CommonElements(int[] arr1, int[] arr2)
        {
            int[] newArr = new int[Math.Min(arr1.Length, arr2.Length)];
            int count = 0;

            if (arr1 == null || arr2 == null)
            {
                Console.WriteLine("Invalid Inputs!");
                return new int[0];
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        newArr[count] = arr1[i];
                        count++;
                    }
                }
            }

            int[] resultArray = new int[count];
            for (int i = 0; i < count; i++)
            {
                resultArray[i] = newArr[i];
            }

            return resultArray;
        }
    }
}