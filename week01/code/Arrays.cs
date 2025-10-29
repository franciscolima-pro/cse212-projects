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

        //*** MY COMMENTS ***
        //1 - Create an array of the same type as 'number' to store the results
        //2 - Create a loop to iterate over the length and calculate the multiples of 'number' by multiplying 'number' by the loop index + 1
        //3 - Store each multiple in the array
        //4 - Return the array of results

        List<double> multiples = new List<double>();
        
        for (double i = 0; i < length; i++)
        {
            // calcular o multiplo
            double multiple = number * (i + 1);
            multiples.Add(multiple);
            // armazenar no array
        }

        return multiples.ToArray(); // replace this return statement with your own
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //*** MY COMMENTS ***
        //1 - Check if the list is not empty and the amount is less than or equal to the count of the list
        //2 - Calculate the index where the rotation will occur (data.Count - amount)
        //3 - Split the list into two parts: the first part from the start to the rotation index, and the second part from the rotation index to the end
        //4 - Clear the original list
        //5 - Add the second part to the original list followed by the first part

        if (data.Count > 0 && amount <= data.Count)
        {

            var firstPartCount = data.Count - amount;
            var firstPart = data.GetRange(0, firstPartCount);
            var secondPart = data.GetRange(firstPartCount, data.Count - firstPartCount);
            data.Clear();
            data.AddRange(secondPart);
            data.AddRange(firstPart);
        }
    }
}
