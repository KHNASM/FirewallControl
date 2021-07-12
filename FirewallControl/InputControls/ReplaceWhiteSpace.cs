using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FirewallControl.InputControls
{
    public static class ReplaceWhiteSpace
    {
        public static string ReplaceSpaceWith(string text, string ReplaceWith)
       {
            return Regex.Replace(text, @"s", ReplaceWith);
       }
    }
}
