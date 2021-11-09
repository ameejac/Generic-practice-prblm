using System;

namespace FindMaxNum
{
    class Program
    {
        static void Main(string[] args)
        {
            //uc1 find  the maximum integer
            //Console.WriteLine("the maximum int value is:"+MaxNum.Find3MaxNum(10,15,40));

            //uc2 given three floats find the maximum
            //Console.WriteLine("the maximum float value is:" + MaxNum.Find3MaxNum(10f, 2f, 3f));

            //uc3 find the maximum string
            //Console.WriteLine("the maximum string is:" + MaxNum.Find3MaxNum("apple", "peach", "banana"));

            //uc4 Extend method
            int[] array = { 1, 3, 6, 7 };
            GenericArrayMax<int> generic = new GenericArrayMax<int>(array);
            generic.displayMaxValue();
        }
    }
}
