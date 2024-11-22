Here is a C# console application that solves the problem:

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a digit string: ");
        string digits = Console.ReadLine();
        Console.WriteLine("Number of ways to decode: " + CountDecoding(digits, digits.Length));
    }

    static int CountDecoding(string digits, int n)
    {
        int[] count = new int[n + 1];
        count[0] = 1;
        count[1] = 1;

        if (digits[0] == '0')
            return 0;

        for (int i = 2; i <= n; i++)
        {
            count[i] = 0;

            if (digits[i - 1] > '0')
                count[i] = count[i - 1];

            if (digits[i - 2] == '1' || (digits[i - 2] == '2' && digits[i - 1] < '7'))
                count[i] += count[i - 2];
        }

        return count[n];
    }
}
```

This program reads a digit string from the console, then calculates the number of ways to decode the string using the `CountDecoding` method. The `CountDecoding` method uses dynamic programming to count the number of ways to decode the string. It creates an array `count` where `count[i]` is the number of ways to decode the string up to the `i`-th digit. It then iterates over the string, updating `count[i]` based on the current and previous digits. If the current digit is not zero, it adds `count[i - 1]` to `count[i]`. If the current and previous digits form a number between 10 and 26, it adds `count[i - 2]` to `count[i]`. The number of ways to decode the entire string is `count[n]`.