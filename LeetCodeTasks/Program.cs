
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static bool IsPalindrome(int num)
    {
        List<int> digitsList = new List<int>();

        string numberString = num.ToString();
        int length = numberString.Length;
        int[] digitArray = new int[numberString.Length];

        for (int i = 0; i < length / 2; i++)
        {
            if (numberString[i] != numberString[length - 1 - i])
                return false;
        }

        for (int i = 0; i < numberString.Length; i++)
        {
            digitArray[i] = int.Parse(numberString[i].ToString());
        }

        for (int i = digitArray.Length - 1; i >= 0; i--)
        {
            digitsList.Add(digitArray[i]);
        }

        string mirroNumString = string.Join("", digitsList);
        int mirrorNum = int.Parse(mirroNumString);

        return (num == mirrorNum) ? true : false;
    }

    static int RomanToInt(string s)
    {
        Dictionary<char, int> romanVal = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int result = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (i < s.Length-1 && romanVal[s[i]] < romanVal[s[i+1]])
            {
                result -= romanVal[s[i]];
            }
            else
            {
                result += romanVal[s[i]];
            }
        }

        return result;
    }

    static void Main(string[] args)
    {
        //Task1
        //IsPalindrome(212);
        //Task2 
        //Console.WriteLine(RomanToInt("IV"));
        //Task3
    }
}