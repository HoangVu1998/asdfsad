using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> InputSet = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (InputSet.ContainsKey(target - nums[i]))
                {
                    return new int[] { InputSet[target - nums[i]], i };
                }
                else
                {
                    InputSet[nums[i]] = i;
                }
            }
            return null;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 1, 2, 3, 4, 5, 6, 0 };
            int target = 5;
            Solution test1 = new Solution();
            test1.TwoSum(input, target);
        }
    }
}
