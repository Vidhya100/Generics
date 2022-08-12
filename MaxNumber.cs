using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMaxNumber
{
    public class MaxNumber
    {
        public int first, second, third;

        public MaxNumber(int first, int second, int third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
        public int GetMaxNum()
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
