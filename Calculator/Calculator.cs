using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        //variables for the class
        private decimal currentValue = 0;
        private decimal operand1 = 0;
        private Operator op = Operator.None;
        //enum list for the operators
        private enum Operator
        {
            Add,
            Subtract,
            Multiply,
            Divide,
            None
        }
        //empty constructor
        public Calculator() 
        {
            
        }
        //property of the calculator class. I needed it ot be setable for my program.
        public decimal CurrentValue { get; set; }

        /*
         * The next 4 methods for the class all do the same thing except they are each for there
         * own math operator to determine what to do with the information. 
         * 
         */
        public void Add(decimal displayValue)
        {
            this.operand1 = displayValue;
            this.currentValue = displayValue;
            this.op = Operator.Add;
        }
        public void Subtract(decimal displayValue)
        {
            this.operand1 = displayValue;
            this.currentValue = displayValue;
            this.op = Operator.Subtract;

        }
        public void Multiply(decimal displayValue)
        {
            this.operand1 = displayValue;
            this.currentValue = displayValue;
            this.op = Operator.Multiply;

        }
        public void Divide(decimal displayValue)
        {
            this.operand1 = displayValue;
            this.currentValue = displayValue;
            this.op = Operator.Divide;
            
        }


        //The equals method takes all of the information taken from the form and sent to the calculator class to do the equation.
        public void Equals()
        {
            switch (op)
            {
                case Operator.Add:

                    operand1 = operand1 + currentValue;
                    break;

                case Operator.Subtract:

                    operand1 = operand1 - currentValue;
                    break;

                case Operator.Multiply:

                    operand1 = operand1 * currentValue;
                    break;

                case Operator.Divide:

                    operand1 = operand1 / currentValue;
                    break;

                default:

                    this.operand1 = this.currentValue;
                    break;
            }

            //sets the answer to currentValue
            currentValue = this.operand1;
          
        }
        public void Equals(decimal displayValue)
        {
            //gets the second number 
            this.currentValue = displayValue;
            //sends the second number along with the first and the operator to the Equals method to process the equation.
            Equals();
            //sets the Calculator property current value to the result of the equation. So that the CurrentValue Property can be called on in the form. 
            CurrentValue = currentValue;

        }
        
        public void EqualsAgain(decimal displayValue)
        {
            /*a method I created becasue I could not for the life of me figure out how to keep pressing equals and redoing the equation with the new number. 
                It checks to see if the operator that was set prior was an additon or multiplication if it is then it will set the value returned back to operand1.
            and keep incromenting up until you decide to stop hitting the = sign.
                if it was a subtraction or division problem we need to switch the variables around and so if you set the display value to the current value you 
                can keep the same equation incimenting down. 
             */
            if (op == Operator.Add | op == Operator.Multiply )
            {
                this.operand1 = displayValue;
            }
            else
            {
                this.currentValue = displayValue;
                
            }
            
            Equals();
            CurrentValue = currentValue;
        }
        
        public void Reciprocal(decimal displayValue)
        {
            //gets the reciprocal or whatever 1 divided by the number would be. 
            this.currentValue = displayValue;
            
            CurrentValue = (1 / currentValue);
        }
        public void PositiveOrNegative(decimal displayValue)
        {
            this.currentValue = displayValue;
            // checks whether the value is positive or negative if its positive its multiplied by a -1 
            if (currentValue > 0)
            {
                CurrentValue = (currentValue * -1);
            }
            else
            {
                //if its negative it uses the absolute math function to give the positive of the number.
                CurrentValue = Math.Abs(currentValue);
            }
        }







    }
}
