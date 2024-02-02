using System;
using System.Linq;

/*
* Problem: Two Sum
* URL: https://www.codewars.com/kata/52c31f8e6605bcc646000082/train/csharp
* Status: AC
*/
public class Kata
{
    public static int[] TwoSum(int[] numbers, int target)
    {
        // Dictionary to store the index of the numbers
        var dict = new System.Collections.Generic.Dictionary<int, int>();
        for (var i = 0; i < numbers.Length; i++)
        {
            var complement = target - numbers[i];
            if (dict.ContainsKey(complement))
            {
                return new int[] { dict[complement], i };
            }
            dict[numbers[i]] = i;
        }
        return new int[] { };
    }
}
