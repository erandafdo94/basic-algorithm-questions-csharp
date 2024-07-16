using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

class Program
{
    static void Main()
    {

        RemoveDuplicatesFromString("Habbit");

    }

    public static void RemoveDuplicatesFromString(string word)
    {
        //habbit

        string result = string.Empty;

        for (int i = 0; i < word.Length; i++)
        {
            if (!result.Contains(word[i]))
            {
                result += word[i];
            }
        }
        Console.WriteLine(result);
    }

    public static int FibonacciNumber(int n)
    {
        if (n <= 0)
        {
            return 0;
        }

        if (n == 1)
        {
            return 1;
        }

        int a = 0;
        int b = 1;
        int results = 0;

        //0,1,1,2,3,5

        for (int i = 2; i <= n; i++)
        {
            results = a + b;
            a = b;
            b = results;
        }

        return results;
    }

    public static int MultipicationWithouthMultipicationOperator(int x, int y)
    {
        bool isNegative = false;
        if (x < 0)
        {
            x = -x;
            isNegative = !isNegative;
        }

        if (y < 0)
        {
            y = -y;
            isNegative = !isNegative;
        }


        int result = 0;
        for (int i = 0; i < y; i++)
        {
            result += x;
        }

        if (isNegative)
        {
            result = -result;
        }

        return result;

    }

    public static bool CheckPalindrome(string word)
    {
        int left = 0;
        int right = word.Length - 1;

        while (left < right)
        {
            if (char.ToLower(word[left]) != char.ToLower(word[right]))
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }

    public static string ReverseString(string word)
    {
        char[] array = word.ToCharArray();
        StringBuilder a = new StringBuilder();

        for (int i = array.Length - 1; i >= 0; i--)
        {
            a.Append(array[i]);
        }

        return (a.ToString());
    }
}

