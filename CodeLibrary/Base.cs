using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeLibrary
{
    public class Base
    {
        public int Factorial(int input)
        {
            int sum = 1;
            for (int i = 1; i <= input; i++)
            {
                sum = i * sum;
            }
            return sum;
        }

        public string NoOfOccurence_Integer(int[] input)
        {
            int length = input.Length;
            int[] result = new int[length];
            StringBuilder resultString = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                if (result.Contains(input[i]))
                { continue; }
                int count = 0;
                for (int j = 0; j < length; j++)
                {
                    if (input[i] == input[j])
                    { count++; }

                }
                result[i] = input[i];
                resultString.Append(input[i] + " is present " + count + " times" + "\n");
            }
            return resultString.ToString();
        }

        public dynamic NoOfOccurence_Integer2(int[] input)
        {
            dynamic result = input.GroupBy(x => x).Select(x => new { key = x.Key, val = x.Count() });
            return result;
        }
        public void NoOfOccurence_Char(string input)
        {
            while (input.Length > 0)
            {
                char temp = input[0];
                int count = 0;
                for (int j = 0; input.Length > j; j++)
                {
                    if (temp == input[j])
                    {
                        count++;
                    }

                }
                input = input.Replace(temp.ToString(), null);
            }
        }
        public string StringReverse_InBuild(string input)
        {
            string[] temp = input.Split(new char[] { ' '});
            Array.Reverse(temp);
            string result= String.Join("-", temp);
            return result;
        }
        public string StringReverse(string input)
        {
            char[] chars = input.ToCharArray();
            int length = input.Length;
            for (int i = 0, j = length - 1; i < length / 2; i++,j--)
            {
                chars[i] = input[j];
                chars[j] = input[i];
            }
            return new string(chars);
        }
        public string IsPalindrom(string input)
        {
            int length = input.Length;
            for (int i = 0, j = length - 1; length / 2 > i; i++, j--)
            {
                if (input[i] != input[j])
                    return "Not palindrome";
            }
            return "Palindrome";
        }
    }
}
