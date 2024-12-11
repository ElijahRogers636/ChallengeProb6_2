namespace ChallengeProb6_2
{
    internal class Program
    {
        //Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range that is missing from the array

        /// <summary>
        /// Since we have a range of numbers starting at 0 and ending at n, we must know that 0 and n are meant to be in the array
        /// We also know that all numbers leading from 0 to n are meant to be in the array
        /// All thats left is to calulate the true value of the array (summation of all values of i to n+1 to account for missing value)
        /// then calculate summation of array values
        /// subtract num2 from num to get missing value
        /// </summary>

        static void Main(string[] args)
        {
            int[] nums = { 0,2};
            Console.WriteLine("The Array used");
            Print(nums);
            Console.WriteLine($"The missing number is: { FindMissingNum(nums)}");
        }

        // Loop and increment i and add each value of i to a num variable to track array's true sum value
        // if i is less than length of array then add nums[i] to a second num variable to get the sum of the array with the missing value
        // Subtract num2 from num to find the missing value.
        static int FindMissingNum(int[] nums)
        {
            int n = nums.Length;
            int num = 0;
            int num2 = 0;
            for (int i = 0; i < n + 1; i++)
            {
                num += i;
                if (i < n)
                {
                    num2 += nums[i];
                }
            }
            return num-num2;
        }

        static void Print(int[] arr)
        {
            Console.Write("|");
            foreach (int i in arr)
            {
                Console.Write($" {i} |");
            }
            Console.WriteLine();
        }
    }
}
