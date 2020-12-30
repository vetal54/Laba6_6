using System;
using System.Collections.Generic;
using System.Text;

namespace Laba6
{
    class Figures : Lines
    {
        private string a;

        public Figures(string a) : base(a)
        {
            this.a = a;
        }

        public string DeletSimbol5(string a)
        {
            for(int i =0;i<a.Length;i++)
            {
                if (a[i] == '5')
                {
                    a = a.Remove(i, 1);
                    i = i - 1;
                }
            }
            return a;
        }

        override public string ToString()
        {
            return "Length - " + a.Length + " " + "Line - " + a ;
        }
    }
}
