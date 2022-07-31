using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class MemoizedFibonacci: IFibonacci
    {
        private int[] memoizedPositions = new int[] {};
        public void initMemoizedArray(int length)
        {
            this.memoizedPositions = Enumerable.Repeat<int>(-1, length + 1).ToArray();
        }

        private int CalculatePosition(int position)
        {
            if (position < 0)
            {
                throw new ApplicationException("invalid position");
            }

            if (this.memoizedPositions[position] > 0)
            {
                return this.memoizedPositions[position];
            }
            
            int result = 1;

            if(position > 2)
            {
                result = CalculatePosition(position - 1) + CalculatePosition(position - 2);
            }

            this.memoizedPositions[position] = result;
            return result;
        } 

        public int Calculate(int position)
        {
            this.initMemoizedArray(position);

            return this.CalculatePosition(position);
        }
    }
}
