using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class Lesson3
    {
        public static string ReverseStr(string str)
        {
            string reversedStr = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversedStr += str[i];
            }
            return reversedStr;
        }
    }
}
