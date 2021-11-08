using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxNum
{
    class MaxNum
    {
        public static  int Find3MaxNum(int firstvalue,int secondvalue,int thirdvalue)
        {
            if(firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) > 0)
            {
                return firstvalue;
            }
            else if(secondvalue.CompareTo(firstvalue) > 0 &&secondvalue.CompareTo(thirdvalue) > 0)
            {
                return secondvalue;
            }
            else if(thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) > 0)
            {
                return thirdvalue;
            }
            else
            {
                Console.WriteLine("two are more numbers are equal");
            }
            return 0;
        }
        //uc2 given three floats find the max (overloading method)
        public static float Find3MaxNum(float firstvalue, float secondvalue,float thirdvalue)
        {
            if(firstvalue.CompareTo(secondvalue)> 0 && firstvalue.CompareTo(thirdvalue) > 0)
            {
                return firstvalue;
            }
            else if(secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) > 0)
            {
                return secondvalue;
            }
            else if (thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) > 0)
            {
                return thirdvalue;
            }
            else
            {
                Console.WriteLine("two are more numbers are equal");
            }
            return 0;
        }
    }


}
