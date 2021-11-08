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

        public static string Find3MaxNum(string first, string second, string third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                return third;
            }
            else
            {
                Console.WriteLine("all are equal");
            }
            return null;
        }
    }


}
