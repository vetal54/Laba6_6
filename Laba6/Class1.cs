using System;
using System.Collections.Generic;
using System.Text;

namespace Laba6
{
    class Lines
    {
        private string a;

        public Lines(string a_)
        {
            this.a = a_;
        }
        public string a1
        {
            get
            {
                return a;
            }
            set
            {
                if (a.Length != 0) a = value;
            }
        }
            override public string ToString()
            {
            return "Lina - "+ a +  " " + "Length - " + a.Length;
            }
    }

    
}
