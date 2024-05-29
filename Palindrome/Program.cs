using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static bool Logic_Palindrome(string word)
        {
            if (word == null)
            {
                throw new ArgumentNullException("String cannot be null");
            }

            if (word.Length < 2)
            {
                return true;

            }

            return Logic_Palindrome(word);

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
                    right++;
                }
                return true;

            }

        }



    }
}
