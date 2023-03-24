//Given an integer array nums, return the third distinct maximum number in this array.
//If the third maximum does not exist, return the maximum number.

//Example 1:

//Input: nums = [3, 2, 1]
//Output: 1
//Explanation:
//The first distinct maximum is 3.
//The second distinct maximum is 2.
//The third distinct maximum is 1.
//Example 2:

//Input: nums = [1, 2]
//Output: 2
//Explanation:
//The first distinct maximum is 2.
//The second distinct maximum is 1.
//The third distinct maximum does not exist, so the maximum (2) is returned instead.
//Example 3:

//Input: nums = [2, 2, 3, 1]
//Output: 1
//Explanation:
//The first distinct maximum is 3.
//The second distinct maximum is 2 (both 2's are counted together since they have the same value).
//The third distinct maximum is 1.


//Constraints:

//1 <= nums.length <= 104
//- 231 <= nums[i] <= 231 - 1
//https://www.youtube.com/watch?v=Rulq5ru7wrs
//https://www.youtube.com/watch?v=e9ONJpkYmm8


public class Solution
{
    public int ThirdMax(int[] nums)
    {
        //If the input array has only one element, return that element.
        if (nums.Length == 1) return nums[0];
        //If the input array has two elements, return the maximum of the two.
        if (nums.Length == 2) return Math.Max(nums[0], nums[1]);

        //Initialize three variables to store the three distinct maximum values (m1, m2, m3), set to int.MinValue initially.
        int m1 = int.MinValue, m2 = int.MinValue, m3 = int.MinValue;

        //Iterate through the input array, and for each element:
        for (var i = 0; i < nums.Length; i++)
        {
            //a. If the current element is greater than m1 and not equal to m2 or m3, set m1 to the current element.
            if (nums[i] > m1 && nums[i] != m2 && nums[i] != m3) m1 = nums[i];
            //b. If m1 is greater than m2, swap m1 and m2.
            if (m1 > m2) Swap(ref m1, ref m2);
            //c. If m2 is greater than m3, swap m2 and m3.
            if (m2 > m3) Swap(ref m2, ref m3);
        }
        //If m1 is not equal to int.MinValue, return m1.
        if (m1 != int.MinValue) return m1;
        //If m1 is equal to int.MinValue and m2 is not equal to int.MinValue,
        //and the input array contains int.MinValue, return m1.
        if (m1 == int.MinValue && m2 != int.MinValue && nums.Contains(int.MinValue)) return m1;
        //Otherwise, return the maximum of m3 and m2.
        return Math.Max(m3, m2);
    }

    private void Swap(ref int a, ref int b)
    {
        var h = a;
        a = b;
        b = h;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        int[] nums = { 2, 2, 3, 1 };
        int result = solution.ThirdMax(nums);

        //int[] nums = { 1, 2 };
        //int result = solution.ThirdMax(nums);

        //int[] nums = { 3, 2, 1 };
        //int result = solution.ThirdMax(nums);

        Console.WriteLine($"Third maximum in the given array: {result}");
    }
}
