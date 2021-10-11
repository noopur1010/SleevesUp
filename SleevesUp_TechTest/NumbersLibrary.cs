using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SleevesUp_TechTest
{
    /* Nupur  */
    /* Static Logical Number functions */
    /* Include All these functions into Unit Test Cases */

    public static class NumbersLibrary
    {
        public static IOrderedEnumerable<int> GetUniqueNumbersInRange()
        {
            Random rnd = new Random();
            return Enumerable.Range(11111, 99999)
                      .Where(x => Check_Repeated_Digit(x) == 1)
                      .OrderBy(i => rnd.Next(1, 9));
        }

        public static int Check_Repeated_Digit(int n)
        {
            int originalNValue = n;
            HashSet<int> s = new HashSet<int>();
            while (n != 0)
            {
                int d = n % 10;
                if (s.Contains(d) || s.Contains(0))
                {
                    s = null;
                    return 0;
                }
                s.Add(d);
                n = n / 10;
            }

            s = null;
            if (originalNValue.ToString() == string.Join("", originalNValue.ToString().ToCharArray().OrderBy(x => x)))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public static int GetMinValueFromList(IOrderedEnumerable<int> numberList)
        {
            return numberList.Min();
        }

        public static int GetValueFromList(IOrderedEnumerable<int> numberList, int startDigit, int lastDigit)
        {
            return numberList.Where(x => NumbersLibrary.FirstDigit(x) == startDigit && NumbersLibrary.LastDigit(x) == lastDigit).FirstOrDefault();
        }


        public static int FirstDigit(int n)
        {
            while (n >= 10)
            {
                n /= 10;
            }
            return n;
        }

        public static int LastDigit(int n)
        {
            return (n % 10);
        }

        public static int ReverseNumber(int n)
        {
            int number = n;
            int reminder, reverse = 0;
            while (number > 0)
            {
                reminder = number % 10;             
                reverse = (reverse * 10) + reminder;                
                number = number / 10;
            }
            return reverse;
        }

        public static List<int> ConvertNumberToArray(int n)
        {
            var digits = new List<int>();
            while (n > 0)
            {
                digits.Add(n % 10);
                n /= 10;
            }
            digits.Reverse();
            return digits;
        }

    }
}
