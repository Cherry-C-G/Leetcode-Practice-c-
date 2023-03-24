//Given an array nums of n integers where nums[i] is in the range[1, n],
//return an array of all the integers in the range [1, n] that do not appear in nums.

//Example 1:

//Input: nums = [4, 3, 2, 7, 8, 2, 3, 1]
//Output: [5,6]
//Example 2:

//Input: nums = [1, 1]
//Output: [2]

//Constraints:

//n == nums.length
//1 <= n <= 105
//1 <= nums[i] <= n

//Follow up: Could you do it without extra space and in O(n) runtime?
//You may assume the returned list does not count as extra space.
//https://www.youtube.com/watch?v=JlsNBKqdln8
//https://www.youtube.com/watch?v=jSfDPVIYe1s&t=22s

using System.Linq;
public class Solution
{
    //The method takes an integer array nums as input.
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        //It uses the Enumerable.Range method to generate a range of integers from 1 to nums.Length.
        //The Except method is used to remove the distinct elements of nums from the generated range.
        // the result is converted to a list and returned.
        return Enumerable.Range(1, nums.Length).Except(nums.Distinct()).ToList();
    }
}
class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        //int[] nums = { 4, 3, 2, 7, 8, 2, 3, 1 };
        int[] nums = { 1,1 };
        IList<int> result = solution.FindDisappearedNumbers(nums);

        Console.WriteLine("Disappeared numbers in the given array:");
        foreach (int num in result)
        {
            Console.Write($"{num} ");
        }
    }
}
