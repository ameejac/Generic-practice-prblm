using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxNum
{
    class PrintGenericMethod<E>
    {
        public E[] array;
        public PrintGenericMethod(E[] array)
        {
            this.array = array;
        }
        public void Toprint()
        {
            Console.WriteLine("displaying the array elements");
            foreach(var element in array)
            {
                Console.WriteLine(element);
            }
        }
    }
}
