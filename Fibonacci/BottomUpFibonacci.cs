using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class BottomUpFibonacci: IFibonacci
    {
        public int Calculate(int position)
        {
            if(position < 0)
            {
                throw new ApplicationException("invalid position");
            }

            if(position == 1 || position == 2)
            {
                return 1;
            }

            int result = 1;
            int lastResult = 1;

            for(int currentPosition = 3; currentPosition <= position; currentPosition++)
            {
                int lastResultAux = result;

                result += lastResult;
                lastResult = lastResultAux;
            }

            return result;
        }
    }
}
