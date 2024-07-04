using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine(ReverseString("abcde"));
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

