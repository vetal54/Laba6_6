using System;
using System.Collections.Generic;
using System.Text;

namespace Laba6
{
    class Letters : Lines
    {
        private string a;
        
        public Letters(string a) :base(a)
        {
            this.a = a;
        }

        public string DeletSimbolA(string a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 'a')
                {
                    a = a.Remove(i, 1);
                    i = i - 1;
                }
            }
            return a;
        }

        override public string ToString()
        {
            return "Length - " + a.Length + " " + "Line - " + a;
        }
    }
}
