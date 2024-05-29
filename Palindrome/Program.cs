using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var arg in args)
            {
                try
                {
                    bool IsPalindromeInside = Logic_Palindrome(arg);
                    Console.WriteLine($"{arg} -> {IsPalindromeInside}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"{arg} -> Exception: {ex.Message}");
                }
            }
            
        }

        public static bool Logic_Palindrome(string word)
        {
            if (word == null)
            {
                throw new ArgumentNullException(nameof(word),"String cannot be null");
            }

            if (word.Length < 2)
            {
                return true;
            }

            return IsPalindromeInside(word);

            bool IsPalindromeInside(string str)
            {
                int left = 0;
                int right = str.Length - 1;

                while (left < right)
                {
                    if (str[left] != str[right])
                    {
                        return false;
                    }
                    left++;
                    right--;
                }
                return true;

            }

        }

    }
}
