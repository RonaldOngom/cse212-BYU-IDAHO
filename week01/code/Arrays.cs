using System.Collections.Generic;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // PLAN:
        // 1. Create a new array of type double with a size equal to length.
        // 2. Use a loop that runs from 0 to length - 1.
        // 3. For each index i, calculate the multiple by multiplying
        //    the starting number by (i + 1).
        // 4. Store the calculated value in the array at index i.
        // 5. After the loop finishes, return the filled array.

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // PLAN:
        // 1. Determine how many elements will be moved from the end of the list.
        //    This value is given by the amount parameter.
        // 2. Calculate the index where the split should occur.
        //    This is data.Count - amount.
        // 3. Use GetRange to copy the last 'amount' elements into a temporary list.
        // 4. Remove those elements from the original list using RemoveRange.
        // 5. Insert the copied elements at the beginning of the list using InsertRange.
        // 6. The list is now rotated to the right by the given amount.

        int splitIndex = data.Count - amount;

        // Get the elements that will move to the front
        List<int> tail = data.GetRange(splitIndex, amount);

        // Remove those elements from the end
        data.RemoveRange(splitIndex, amount);

        // Insert them at the beginning
        data.InsertRange(0, tail);
    }
}
