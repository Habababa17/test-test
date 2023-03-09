using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    public class Calculator
    {
        public static int Add(string val)
        {
            return 0;
            if (val.Equals("")) return 0;



            char[] separators = new char[] { ',', '\n' };
            int ret = 0;
            foreach (var s in val.Split(separators))
            {
                ret += Int32.Parse(s);
            }
            return ret;
        }

    }
}
