//Given an integer array nums,
//return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

//The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

//You must write an algorithm that runs in O(n) time and without using the division operation.

//Example 1:

//Input: nums = [1, 2, 3, 4]
//Output: [24,12,8,6]
//Example 2:

//Input: nums = [-1, 1, 0, -3, 3]
//Output: [0,0,9,0,0]


//Constraints:

//2 <= nums.length <= 105
//- 30 <= nums[i] <= 30
//The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.


//Follow up: Can you solve the problem in O(1) extra space complexity?
//(The output array does not count as extra space for space complexity analysis.)
//https://www.youtube.com/watch?v=tSRFtR3pv74

public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        //Check if the input array nums is null or has zero length. If so, return null.
        if (nums == null || nums.Length == 0)
            return null;

        //Initialize an integer array result of the same length as nums.
        //This array will store the products of all elements in nums except the element at the same index.
        int[] result = new int[nums.Length];
        //Initialize an integer variable temp set to 1, which will be used to calculate the products.
        int temp = 1;

        //Iterate through the array nums from the beginning to the end,
        //updating the result array.
        //For each element, store the current value of temp in the result array
        //and then multiply temp by the value of the current element in nums.
        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = temp;
            temp *= nums[i];
        }
        //Reset the temp variable to 1.
        temp = 1;

        //Iterate through the array nums from the end to the beginning,
        //updating the result array. For each element,
        //multiply the value at the same index in the result array by the current value of temp,
        //then multiply temp by the value of the current element in nums.
        for (int i = result.Length - 1; i >= 0; i--)
        {
            result[i] *= temp;
            temp *= nums[i];
        }
        //Return the result array.
        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        //int[] nums = { 1, 2, 3, 4 };
        int[] nums = { -1, 1, 0, -3, 3};
        int[] result = solution.ProductExceptSelf(nums);

        Console.WriteLine($"Product of elements except self: [{string.Join(", ", result)}]");
    }
}
