using System;

namespace ProjectEuler_LargestPalindromeProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int product, largestPalindrome = 0;

            for (int x = 100; x < 1000; x++)
            {
                for (int y = 100; y < 1000; y++)
                {
                    product = x * y;
                    
                    if (isPalindrome(product))
                    {
                        if (product > largestPalindrome)
                            largestPalindrome = product;
                        Console.WriteLine(x + " * " + y + " = " + product);
                    }
                }
            }
            Console.WriteLine("Largest palindrome: " + largestPalindrome);
            Console.ReadKey();
        }

        static bool isPalindrome(int n)
        {
            char[] chars = n.ToString().ToCharArray();
            Array.Reverse(chars);
            string reverseString = new string(chars);

            if (n.ToString() == reverseString)
                return true;
            return false;
        }
    }
}
