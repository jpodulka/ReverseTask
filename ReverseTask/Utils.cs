using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseTask
{
    public static class Utils
    {
        public static string Reverse(string text)
        {
            var s = text.Split(' ');

            string ans = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                ans += s[i] + " ";
            }
            return ans;
        }
    }
}
