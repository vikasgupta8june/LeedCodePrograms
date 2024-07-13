using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodePrograms
{
    public class TwoSumCode
    {
        //O(n^2)
        //{ 2, 7, 11, 15 }  target 9
        //2 i
        //2 + 7
        //2 + 11
        //2 + 15
        //7
        //7 + `11
        public static int[] TwoSumBruteApproach(int[] nums, int target)
        {
            // Outer loop to iterate through each element in the array
            for (int i = 0; i < nums.Length; i++) //nums = { 2, 7, 11, 15 }
            {
                // Inner loop to check the sum of the current[i] element with every subsequent[j] element
                for (int j = i + 1; j < nums.Length; j++)
                {
                    // Check if the sum of the current pair equals the target
                    if (nums[i] + nums[j] == target) // target = 9// 2(i) + 7(j) = 9
                    {
                        // If so, return the indices of the elements that add up to the target
                        return new int[] { i, j };
                    }
                }
            }

            // If no such pair is found, return an empty array
            return new int[] { };
        }

        //O(n)
        //2[key]-0[index] //7[key]-1[index] //11[key]-2[index] //15[key]-3[index]
        public static int[] TwoSumOptimizedApproach(int[] nums, int target)
        {
            // Dictionary to store the numbers and their indices as we iterate through the array
            //number as key and index as value
            Dictionary<int, int> numberAndIndexDict = new Dictionary<int, int>();                        

            // Loop through each element in the array
            for (int i = 0; i < nums.Length; i++) //nums = { 2, 7, 11, 15 }
            {
                // Calculate the remaining value needed to reach the target
                int rem = target - nums[i]; //target = 9 // rem = 9-2 = 7(add to numberAndIndexDict),9-7=2

                // Check if the remaining value is already in the dictionary
                if (numberAndIndexDict.ContainsKey(rem))
                {
                    // If it is, return the indices of the elements that add up to the target
                    return new int[] { numberAndIndexDict[rem], i };
                }

                // If the remaining value is not in the dictionary, add the current number
                // and its index to the dictionary
                numberAndIndexDict.Add(nums[i], i);
            }

            // If no such pair is found, return an empty array
            return new int[] { };
        }

      
    }
}
