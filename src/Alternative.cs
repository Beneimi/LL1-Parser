using System;
using System.Collections.Generic;
using System.Text;

namespace LL1
{
    public class Alternative
    {
        public char NonTerm { get; }
        public char Term { get; }
        public string Replacement { get; }

        public Alternative(char nonTerm, char term, string replacement)
        {
            this.Term = term;
            this.NonTerm = nonTerm;
            this.Replacement = replacement;
        }
    }
}
