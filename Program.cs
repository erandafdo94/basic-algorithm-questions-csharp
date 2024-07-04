using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine(CheckPalindrome("madam"));
        Console.WriteLine(ReverseString("abcde"));
    }



    /// <summary>
    /// Check if the word is a palindrome or not
    /// </summary>
    /// <param name="word"></param>
    /// <returns></returns>
    public static bool CheckPalindrome(string word)
    {
        int left = 0;
        int right = word.Length - 1;

        //madam
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


    /// <summary>
    /// How to reverse a string in c#
    /// </summary>
    /// <param name="word"></param>
    /// <returns></returns>
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

