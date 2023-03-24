//Given an integer numRows, return the first numRows of Pascal's triangle.

//In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:

//Example 1:

//Input: numRows = 5
//Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
//Example 2:

//Input: numRows = 1
//Output: [[1]]


//Constraints:

//1 <= numRows <= 30
//https://www.youtube.com/watch?v=nPVEaB3AjUM

//The Solution class has a method Generate,
//which takes an integer numRows as input and returns the first numRows of Pascal's triangle.
public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        //Initialize the result list res with the first row of Pascal's triangle, which is always [1].
        IList<IList<int>> res = new List<IList<int>>() { new List<int>() { 1 } };

//        Loop from 2 to numRows(inclusive), using the loop variable i to represent the row number.


        for (int i = 2; i <= numRows; i++)
        {
            //Create a new list cur for the current row, and add the first element 1 to it.
            List<int> cur = new List<int>() { 1 };

            //For each element in the current row(excluding the first and last elements),
            //calculate its value by summing the two numbers directly above it in the previous row.
            //Use a loop with variable j to iterate through the positions in the current row.
            
          
            for (int j = 1; j < i - 1; j++)
                cur.Add(res[i - 2][j - 1] + res[i - 2][j]);
            //Add the last element 1 to the current row.
            cur.Add(1);
            //Add the current row to the result list res.
            res.Add(cur);
        }
        //Return the result list res.
        return res;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();

        // Test case 1: numRows = 5
        int numRows1 = 5;
        IList<IList<int>> result1 = solution.Generate(numRows1);
        Console.WriteLine("Test case 1: numRows = 5");
        PrintPascalsTriangle(result1);

        // Test case 2: numRows = 1
        int numRows2 = 1;
        IList<IList<int>> result2 = solution.Generate(numRows2);
        Console.WriteLine("Test case 2: numRows = 1");
        PrintPascalsTriangle(result2);
    }

    private static void PrintPascalsTriangle(IList<IList<int>> triangle)
    {
        foreach (var row in triangle)
        {
            Console.Write("[");
            for (int i = 0; i < row.Count; i++)
            {
                Console.Write(row[i]);
                if (i < row.Count - 1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine("]");
        }
        Console.WriteLine();
    }
}
