namespace BlazorAlgorithms.utils;

public class ArrayUtility
{
    public static (int[]? Numbers, String ErrorMessage) ParseArray(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return (null, "Please enter some numbers.");
        }
        try
        {
            int[] parsedArray = input.Split(',')
                .Select(s => int.Parse(s.Trim()))
                .ToArray();
            return (parsedArray, "");
        }
        catch (FormatException)
        {
            return (null, "Invalid input. Please use only numbers and commas.");
        }
        catch (OverflowException)
        {
            return (null, "A number is too large or small. Please use standard integers");
        }
    }
}