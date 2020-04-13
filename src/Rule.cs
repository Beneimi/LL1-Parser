using System;
using System.Collections.Generic;
using System.Text;

namespace LL1
{
    public class Rule
    {

        private static int IDCount = 0;

        public int ID;
        public char Left { get; }
        public string Right { get; }

        public Rule(char left, string right)
        {
            this.ID = IDCount;
            IDCount++;
            this.Left = left;
            this.Right = right;
        }
    }

}
