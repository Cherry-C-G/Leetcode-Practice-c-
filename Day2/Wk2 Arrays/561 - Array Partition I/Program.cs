//Given an integer array nums of 2n integers,
//group these integers into n pairs (a1, b1), (a2, b2), ..., (an, bn)
//such that the sum of min(ai, bi) for all i is maximized.Return the maximized sum.

//Example 1:

//Input: nums = [1, 4, 3, 2]
//Output: 4
//Explanation: All possible pairings(ignoring the ordering of elements) are:
//1. (1, 4), (2, 3)->min(1, 4) + min(2, 3) = 1 + 2 = 3
//2. (1, 3), (2, 4)->min(1, 3) + min(2, 4) = 1 + 2 = 3
//3. (1, 2), (3, 4)->min(1, 2) + min(3, 4) = 1 + 3 = 4
//So the maximum possible sum is 4.
//Example 2:

//Input: nums = [6, 2, 6, 5, 1, 2]
//Output: 9
//Explanation: The optimal pairing is (2, 1), (2, 5), (6, 6).min(2, 1) + min(2, 5) + min(6, 6) = 1 + 2 + 6 = 9.


//Constraints:

//1 <= n <= 104
//nums.length == 2 * n
//- 104 <= nums[i] <= 104
//https://www.youtube.com/watch?v=Qmh3k8l-bIc
//https://www.youtube.com/watch?v=wDU72F6dhS4

public class Solution
{
    public int ArrayPairSum(int[] nums)
    {
        //Initialize an integer variable sum set to 0,
        //which will store the maximized sum of the minimum values of the pairs.
        int sum = 0;

        //Sort the input array nums in non-decreasing order.
        Array.Sort(nums);

        //Iterate through the sorted array nums,
        //incrementing the loop index by 2 for each iteration.
        //This is done because we want to access every other element in the sorted array.
        for (var i = 0; i < nums.Length; i += 2)

            // Add the value of the current element to the sum.
            sum += nums[i];

        //Return the value of sum.
        return sum;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        //int[] nums = { 1, 4, 3, 2 };
         int[] nums = { 6, 2, 6, 5, 1, 2 };
        int result = solution.ArrayPairSum(nums);

        Console.WriteLine($"Maximized sum of minimum values of pairs: {result}");
    }
}
