using System;
using System.Text;

namespace Text
{
    /// <summary>Provides methods to work with strings.</summary>
    public class Str
    {
        /// <summary>Checks if a srting is palindrome or not.</summary>
        /// <returns>True if a string is palindrome, otherwhise False.</returns>
        public static bool IsPalindrome(string s)
        {
            StringBuilder newString = new StringBuilder();
            string lower;

            foreach (char item in s)
            {
                if (!Char.IsPunctuation(item))
                {
                    if (!Char.IsWhiteSpace(item))
                    {
                        newString.Append(item);
                    }
                }
            }

            lower = newString.ToString().ToLower();

            int j = lower.Length - 1;
            for (int i = 0; i < lower.Length; i++, j--)
            {
                if (lower[i] != lower[j])
                    return false;
            }

            return true;
        }
    }
}
