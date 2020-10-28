namespace Palindrome_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            PalindromeDescendant(12344321);
        }
        static bool PalindromeDescendant(int num)
        {
            int palindromeDescentdantToCheck = num;

            while (!IsPalindrome(palindromeDescentdantToCheck) && palindromeDescentdantToCheck.ToString().Length != 2)
            {
                if (palindromeDescentdantToCheck.ToString().Length % 2 != 0)
                {
                    return false;
                }

                palindromeDescentdantToCheck = GetDescendants(palindromeDescentdantToCheck);
            }

            return IsPalindrome(palindromeDescentdantToCheck);
        }

        static bool IsPalindrome(int palindrome)
        {
            string stringPalindrome = palindrome.ToString();
            int halfPalindromeLength = stringPalindrome.Length / 2;

            for (int i = 0, j = stringPalindrome.Length - 1; i < halfPalindromeLength; i++, j--)
            {
                if (stringPalindrome[i] != stringPalindrome[j])
                {
                    return false;
                }
            }

            return true;
        }

        static int GetDescendants(int valueToGetDescendantFrom)
        {
            char[] stringValueToGetDescendantFrom = valueToGetDescendantFrom.ToString().ToCharArray();
            string stringDescendant = "";

            for (int i = 0; i < stringValueToGetDescendantFrom.Length; i += 2)
            {
                stringDescendant += int.Parse(stringValueToGetDescendantFrom[i].ToString()) +
                    int.Parse(stringValueToGetDescendantFrom[i + 1].ToString());
            }

            return int.Parse(stringDescendant);
        }
    }
}
