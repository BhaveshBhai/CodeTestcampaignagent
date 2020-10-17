using System;
using System.Collections.Generic;
using System.Text;

namespace CodeTest
{
   public class Utility
    {
        public static double ObjToDouble(object obj)
        {
            if (obj == null)
                return 0;
            if (obj.ToString() == "")
                return 0;
            return Convert.ToDouble(obj.ToString());
        }
    }
}
