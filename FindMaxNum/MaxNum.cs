using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FindMaxNum
{
    class GenericArrayMax<T> where T: IComparable
    {
        public T[] array;
        public GenericArrayMax(T[] array)
        {
            this.array = array;
        }
        /// <summary>
        /// here im sorting the values
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        /// <summary>
        /// i am returning the maximum value
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public T MaxValue(params T[] values)
        {
            var Sorted_values = Sort(values);
            return Sorted_values[^1];
        }
        
        public  void  displayMaxValue()
        {
            var max = MaxValue(this.array);
            Console.WriteLine("display maximum value:" + max);
        }
        
    }
}
