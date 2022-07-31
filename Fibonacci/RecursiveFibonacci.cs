using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class RecursiveFibonacci: IFibonacci
    {
        public int Calculate(int position)
        {
            if(position < 0)
            {
                return 0;
            }

            if(position <= 2)
            {
                return 1;
            }

            return Calculate(position - 1) + Calculate(position - 2);
        }
    }
}
