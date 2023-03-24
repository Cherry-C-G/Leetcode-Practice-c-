//Given an integer array nums sorted in non-decreasing order,
//remove the duplicates in-place such that each unique element appears only once.
//The relative order of the elements should be kept the same.

//Since it is impossible to change the length of the array in some languages,
//you must instead have the result be placed in the first part of the array nums.
//More formally, if there are k elements after removing the duplicates,
//then the first k elements of nums should hold the final result. It does not matter what you leave beyond the first k elements.

//Return k after placing the final result in the first k slots of nums.

//Do not allocate extra space for another array. You must do this by modifying the input array in-place with O(1) extra memory.

//Custom Judge:

//The judge will test your solution with the following code:

//int[] nums = [...]; // Input array
//int[] expectedNums = [...]; // The expected answer with correct length

//int k = removeDuplicates(nums); // Calls your implementation

//assert k == expectedNums.length;
//for (int i = 0; i < k; i++)
//{
//    assert nums[i] == expectedNums[i];
//}
//If all assertions pass, then your solution will be accepted.



//Example 1:

//Input: nums = [1, 1, 2]
//Output: 2, nums = [1, 2, _]
//Explanation: Your function should return k = 2, with the first two elements of nums being 1 and 2 respectively.
//It does not matter what you leave beyond the returned k (hence they are underscores).
//Example 2:

//Input: nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4]
//Output: 5, nums = [0, 1, 2, 3, 4, _, _, _, _, _]
//Explanation: Your function should return k = 5, with the first five elements of nums being 0, 1, 2, 3, and 4 respectively.
//It does not matter what you leave beyond the returned k (hence they are underscores).


//Constraints:

//1 <= nums.length <= 3 * 104
//- 100 <= nums[i] <= 100
//nums is sorted in non - decreasing order.

//https://www.youtube.com/watch?v=DEJAZBq0FDA 

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        //If the input array nums is null or has a length of 0, return 0.
        //This ensures that the function handles edge cases where the input is invalid or empty.
        if (nums == null || nums.Length == 0)
            return 0;

        //Initialize an integer variable i with the value 0.
        //This variable will act as an index for the unique elements in the modified array.
        int i = 0;

        //Iterate through the input array nums using a for loop with the index variable j.
        //For each iteration:
        for (int j = 0; j < nums.Length; j++)
        {
            //a.Assign the value of nums[j] to nums[i] and increment i.
            //This step copies the current element to the unique elements section of the array.
            nums[i++] = nums[j];

            //b. Use a while loop to check if the current element nums[j] is equal to the next element nums[j + 1].
            //If they are equal, increment j to skip the duplicate element.
            //This step ensures that only unique elements are copied to the unique elements section of the array.
            while (j < nums.Length - 1 && nums[j] == nums[j + 1])
                j++;
        }

        return i;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();

        // Test Case 1
        int[] nums1 = { 1, 1, 2 };
        int[] expectedNums1 = { 1, 2 };
        TestRemoveDuplicates(solution, nums1, expectedNums1);

        // Test Case 2
        int[] nums2 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        int[] expectedNums2 = { 0, 1, 2, 3, 4 };
        TestRemoveDuplicates(solution, nums2, expectedNums2);
    }

    private static void TestRemoveDuplicates(Solution solution, int[] nums, int[] expectedNums)
    {
        int k = solution.RemoveDuplicates(nums);

        Console.WriteLine("Returned k: " + k);
        Console.WriteLine("Expected k: " + expectedNums.Length);

        Console.Write("Modified array: ");
        for (int i = 0; i < k; i++)
        {
            Console.Write(nums[i] + " ");
        }

        Console.WriteLine();

        Console.Write("Expected array: ");
        foreach (int num in expectedNums)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("\n------------------------");
    }
}
