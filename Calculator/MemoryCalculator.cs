using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class MemoryCalculator : Calculator
    {
        private decimal memoryValue;


        public MemoryCalculator()
        {

        }

        public void MemoryStore(decimal displayValue)
        {
            this.memoryValue = displayValue;

        }

        public decimal MemoryRecall()
        {
            decimal value = this.memoryValue;

            return value;
        }
        public decimal MemoryAdd(decimal displayValue)
        {
            decimal addNumber = displayValue;

            decimal answer = addNumber + this.memoryValue;

            return answer;
        }
        public void MemoryClear()
        {
            this.memoryValue = 0;
            
        }



    }
}
