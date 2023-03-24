//Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

//You may assume that each input would have exactly one solution, and you may not use the same element twice.

//You can return the answer in any order.



//Example 1:

//Input: nums = [2, 7, 11, 15], target = 9
//Output: [0,1]
//Explanation: Because nums[0] +nums[1] == 9, we return [0, 1].
//Example 2:

//Input: nums = [3, 2, 4], target = 6
//Output: [1,2]
//Example 3:

//Input: nums = [3, 3], target = 6
//Output: [0,1]


//Constraints:

//2 <= nums.length <= 104
//- 109 <= nums[i] <= 109
//- 109 <= target <= 109
//Only one valid answer exists.


//Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?
//https://www.youtube.com/watch?v=KLlXCFG5TnA&t=9s

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        //checks if the input array nums is null or has a length less than 2.
        //If either of these conditions is met, it returns an array of size 2 with default values (0),
        //as it wouldn't be possible to find a valid pair of indices.

        if (nums == null || nums.Length < 2)
            return new int[2];

        // dictionary is used to store the values in the input array nums as keys, and their corresponding indices as values.
        Dictionary<int, int> dic = new Dictionary<int, int>();

        //iterates over the input array nums using a for loop.
        //For each value in nums, it checks if the dictionary dic contains a key equal to the difference between the target
        //and the current value in nums.
        //This is done because if such a key exists,
        //it means that the current value and the value corresponding to the key in the dictionary add up to the target value.
        for (int i = 0; i < nums.Length; i++)
        {
            //If the dictionary contains the required key,
            //the method returns an array containing the current index (i)
            //and the index corresponding to the key in the dictionary (dic[target - nums[i]]).
            if (dic.ContainsKey(target - nums[i]))
                return new int[] { i, dic[target - nums[i]] };

            //If the dictionary doesn't contain the required key,
            //it checks if the current value is not already a key in the dictionary.
            //If it's not, it adds the current value and its index as a key-value pair in the dictionary.
            //This ensures that the dictionary has all the unique values in nums with their indices.
            else if (!dic.ContainsKey(nums[i]))
                dic.Add(nums[i], i);
        }
        //If no pair of indices is found that satisfies the condition (adding up to the target value),
        //the method returns an array of size 2 with default values (0).
        return new int[2];
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();

        int[] nums = { 2, 7, 11, 15 };

        int target = 9;

        //int[] nums = { 3,2,4 };
        //int target = 6;

        //int[] nums = { 3,3 };
        //int target = 6;

        int[] result = solution.TwoSum(nums, target);

        Console.WriteLine("The indices of the two numbers that add up to the target are: ");
        Console.WriteLine("Index 1: " + result[0]);
        Console.WriteLine("Index 2: " + result[1]);
    }
}