//Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.

//Example 1:

//Input: nums = [1, 2, 3, 4, 5, 6, 7], k = 3
//Output: [5,6,7,1,2,3,4]
//Explanation:
//rotate 1 steps to the right: [7,1,2,3,4,5,6]
//rotate 2 steps to the right: [6,7,1,2,3,4,5]
//rotate 3 steps to the right: [5,6,7,1,2,3,4]
//Example 2:

//Input: nums = [-1, -100, 3, 99], k = 2
//Output: [3,99,-1,-100]
//Explanation:
//rotate 1 steps to the right: [99,-1,-100,3]
//rotate 2 steps to the right: [3,99,-1,-100]


//Constraints:

//1 <= nums.length <= 105
//- 231 <= nums[i] <= 231 - 1
//0 <= k <= 105


//Follow up:

//Try to come up with as many solutions as you can. There are at least three different ways to solve this problem.
//Could you do it in-place with O(1) extra space?
//https://www.youtube.com/watch?v=BHr381Guz3Y

public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        // Solution 1 -- Time: O(n), Space: O(n)
        //Create a new integer array called output with the same length as the input array nums.
        int[] output = new int[nums.Length];
        int length = nums.Length;

        //Iterate through the input array nums and calculate the new position
        //of each element in the rotated array using the formula (i + k) % length,
        //where i is the current index, k is the number of steps to rotate, and length is the length of the input array.
        for (int i = 0; i < nums.Length; i++)
        {
            //Assign the value of the current element in the input array to the new position in the output array.
            output[(i + k) % length] = nums[i];
        }
        //After calculating the new positions for all elements,
        //iterate through the output array and copy its elements back to the input array nums.
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = output[i];
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();

        // Test case 1: nums = [1, 2, 3, 4, 5, 6, 7], k = 3
        int[] nums1 = { 1, 2, 3, 4, 5, 6, 7 };
        int k1 = 3;
        solution.Rotate(nums1, k1);
        Console.WriteLine("Test case 1: nums = [1, 2, 3, 4, 5, 6, 7], k = 3");
        Console.WriteLine("Output: [" + string.Join(", ", nums1) + "]");

        // Test case 2: nums = [-1, -100, 3, 99], k = 2
        int[] nums2 = { -1, -100, 3, 99 };
        int k2 = 2;
        solution.Rotate(nums2, k2);
        Console.WriteLine("Test case 2: nums = [-1, -100, 3, 99], k = 2");
        Console.WriteLine("Output: [" + string.Join(", ", nums2) + "]");
    }
}