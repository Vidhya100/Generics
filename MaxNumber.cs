using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMaxNumber
{
    public class MaxNumber<T> where T : IComparable<T>
    {
        public T first, second, third;

        public MaxNumber(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
        public T GetMaxNum()
        {
            if (first.CompareTo(second) == 0)
            {
                if (first.CompareTo(third) == 1)
                    return first;
                else
                    return third;
            }
            else if (first.CompareTo(third) == 0)
            {
                if (first.CompareTo(second) == 1)
                    return first;
                else
                    return second;
            }

            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
                return first;
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
                return second;
            else
                return third;
        }
    }
}
