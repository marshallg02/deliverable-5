using System;

namespace deliverable5methods
{
    class Program

    {
        static int[] PopulateArray(int length)
        {

            int[] array = new int[length];
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(10, 50);
            }
            return array;
        }

        static int SumArrayElements(int[] array)
        {
            int sum = 0;
            foreach (int element in array)
            {
                sum += element;
            }
            return sum;

       }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an intege num between 5 and 15:");
            int arrayLength;
            try
            {
                arrayLength = int.Parse(Console.ReadLine());

                if (arrayLength < 5 || arrayLength > 15)
                {
                    Console.WriteLine("Error Invalid input. enter a num between 5 and 15.");
                    return;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error Invalid input. enter a valid integer num.");
                return;
            }
            int[] array = PopulateArray(arrayLength);
            Console.WriteLine("The elements of the array are: " + string.Join(" ", array));
            int sum = SumArrayElements(array);
            Console.WriteLine("The sum is: " + sum);
        }
    }
}
