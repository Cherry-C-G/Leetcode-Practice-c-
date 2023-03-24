//Given a binary array nums, return the maximum number of consecutive 1's in the array.

//Example 1:

//Input: nums = [1, 1, 0, 1, 1, 1]
//Output: 3
//Explanation: The first two digits or the last three digits are consecutive 1s.
//The maximum number of consecutive 1s is 3.
//Example 2:

//Input: nums = [1, 0, 1, 1, 0, 1]
//Output: 2


//Constraints:

//1 <= nums.length <= 105
//nums[i] is either 0 or 1.
//https://www.youtube.com/watch?v=PLa4tYQhqoU

public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        //Initialize two integer variables max and curr both set to 0.
        //max will store the maximum number of consecutive 1's found,
        //and curr will store the current count of consecutive 1's.
        var max = 0;
        var curr = 0;
        //Iterate through the input array nums.
        for (var i = 0; i < nums.Length; i++)
        {
            //If the current element of nums is 0,
            //compare the value of curr to max. 
            //If curr is greater than max, set max to the value of curr. Then reset curr to 0.
            if (nums[i] == 0)
            {
                if (curr > max)
                {
                    max = curr;
                }
                curr = 0;
            }
            //If the current element of nums is 1, increment the value of curr.
            else
            {
                curr++;
            }
        }
        //After the loop, check if curr is greater than max and, if so, update the value of max accordingly.
        if (curr > max)
            max = curr;
        //Return the value of max.
        return max;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

       // int[] nums = { 1, 1, 0, 1, 1, 1 };
        int[] nums = { 1, 0, 1, 1, 0, 1 };
        int result = solution.FindMaxConsecutiveOnes(nums);

        Console.WriteLine($"Maximum number of consecutive 1's: {result}");
    }
}
