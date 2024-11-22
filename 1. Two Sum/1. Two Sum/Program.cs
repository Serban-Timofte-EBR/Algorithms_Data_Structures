// See the problem here: https://leetcode.com/problems/two-sum/description/
// Level: Easy

// Example 1:
//
// Input: nums = [2,7,11,15], target = 9
// Output: [0,1]
// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

// Example 2:
//
// Input: nums = [3,2,4], target = 6
// Output: [1,2]

// Example 3:
//
// Input: nums = [3,3], target = 6
// Output: [0,1]

public class Program
{
    public int[] TwoSum(int[] nums, int target)
    {
        // Create a dictionary (a hash map) to store number we seen and their indices
        Dictionary<int, int> dictionary = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            
            // Check the complement already exists in the map. In this way we go in the array only one time
          if (dictionary.ContainsKey(complement))
          {
              return new int[] { dictionary[complement], i };
          }
          
          // Store the current number and the index in case this number will become the complement in the future
          // Using the dictionary the avoid duplications
          if (!dictionary.ContainsKey(nums[i]))
          {
              dictionary.Add(nums[i], i);
          }
        }

        // No solution found
        return new int[] { };
    }
}