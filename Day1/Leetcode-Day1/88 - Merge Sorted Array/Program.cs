//You are given two integer arrays nums1 and nums2,
//sorted in non-decreasing order, and two integers m and n,
//representing the number of elements in nums1 and nums2 respectively.

//Merge nums1 and nums2 into a single array sorted in non-decreasing order.

//The final sorted array should not be returned by the function,
//but instead be stored inside the array nums1.
//To accommodate this, nums1 has a length of m + n,
//where the first m elements denote the elements that should be merged,
//and the last n elements are set to 0 and should be ignored. nums2 has a length of n.


//Example 1:

//Input: nums1 = [1, 2, 3, 0, 0, 0], m = 3, nums2 = [2, 5, 6], n = 3
//Output: [1,2,2,3,5,6]
//Explanation: The arrays we are merging are [1,2,3] and[2, 5, 6].
//The result of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.
//Example 2:

//Input: nums1 = [1], m = 1, nums2 = [], n = 0
//Output: [1]
//Explanation: The arrays we are merging are [1] and[].
//The result of the merge is [1].
//Example 3:

//Input: nums1 = [0], m = 0, nums2 = [1], n = 1
//Output: [1]
//Explanation: The arrays we are merging are [] and[1].
//The result of the merge is [1].
//Note that because m = 0, there are no elements in nums1. The 0 is only there to ensure the merge result can fit in nums1.


//Constraints:

//nums1.length == m + n
//nums2.length == n
//0 <= m, n <= 200
//1 <= m + n <= 200
//- 109 <= nums1[i], nums2[j] <= 109



//Follow up: Can you come up with an algorithm that runs in O(m + n) time ?
//https://www.youtube.com/watch?v=P1Ic85RarKY

//merges two sorted integer arrays, nums1 and nums2, into a single sorted array.
//The final sorted array should be stored inside the nums1 array.
public class Solution
{
    //nums1: The first sorted integer array.
    //m: The number of elements in nums1.
    //nums2: The second sorted integer array.
    //n: The number of elements in nums2.
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        //Initialize three pointers:
    //i: Points to the last element in nums1(m - 1).
    //j: Points to the last element in nums2(n - 1).
    //k: Points to the last element in the merged array(m + n - 1).
        int i = m - 1;
        int j = n - 1;
        int k = m + n - 1;

        //Loop through the arrays using a while loop until either i or j becomes negative.
        while (i >= 0 && j >= 0)
        {
            //If nums1[i] is greater than nums2[j],
            //place the element at nums1[i] in the position pointed by k in nums1 and decrement both i and k.
            //Otherwise, place the element at nums2[j] in the position pointed by k in nums1 and decrement both j and k.
            if (nums1[i] > nums2[j])
            {
                nums1[k--] = nums1[i--];
            }
            else
            {
                nums1[k--] = nums2[j--];
            }
        }
        //If there are still elements left in nums2, the loop will copy them into nums1.
        while (j >= 0)
        {
            nums1[k--] = nums2[j--];
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();

        // Test case 1
        int[] nums1 = { 1, 2, 3, 0, 0, 0 };
        int m = 3;
        int[] nums2 = { 2, 5, 6 };
        int n = 3;
        solution.Merge(nums1, m, nums2, n);
        Console.WriteLine("Test case 1 result: [" + string.Join(", ", nums1) + "]");

        // Test case 2
        nums1 = new int[] { 1 };
        m = 1;
        nums2 = new int[] { };
        n = 0;
        solution.Merge(nums1, m, nums2, n);
        Console.WriteLine("Test case 2 result: [" + string.Join(", ", nums1) + "]");

        // Test case 3
        nums1 = new int[] { 0 };
        m = 0;
        nums2 = new int[] { 1 };
        n = 1;
        solution.Merge(nums1, m, nums2, n);
        Console.WriteLine("Test case 3 result: [" + string.Join(", ", nums1) + "]");
    }
}

