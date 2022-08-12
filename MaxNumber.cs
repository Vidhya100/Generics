using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMaxNumber
{
    public class MaxNumber
    {
        public float first, second, third;

        public MaxNumber(float first, float second, float third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
        public float GetMaxNum()
        {
            if (first.CompareTo(second) == 1 && first.CompareTo(third) ==1)
                return first;
            else if (second.CompareTo(first) == 1 && second.CompareTo(third) == 1)
                return second;
            else
                return third;
        }
    }
}
