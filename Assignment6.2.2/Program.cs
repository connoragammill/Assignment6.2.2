using System.Globalization;

namespace Assignment6._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [1, 2, 3, 4];

			int[] answer = new int[nums.Length];
			int product = 0;

			for (int i = 0; i < nums.Length; i++)
			{
				product = 1;
				for (int j = 0; j < nums.Length; j++)
				{
					if (j != i)
					{
						product *= nums[j];
					}
				}
				answer[i] = product;
			}
			foreach (int num in answer)
			{
				Console.Write(num + " ");
			}
		}
    }
}
