using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    
    public partial class frmMemoryCalculator : Form
    {
        //variables for the class
        MemoryCalculator calc = new MemoryCalculator();
        decimal currentValue;
        bool keepEqual = false;

        public frmMemoryCalculator()
        {
            //made sure that the txtbox displayed 0 so that there was something there for my if statement.
            InitializeComponent();
            txtbxDisplay.Text = "0";
        }

        private void Digit_Clicked_EventHandler(object sender, EventArgs e)
        {
            //this event is for the numbers that are pressed except 0.
            //if there is a 0 still in the txtbox it will clear it and add the number pushed.
            //if there isnt a 0 in the txtbox it will just add the number.
            if (txtbxDisplay.Text != "0")
            {
                txtbxDisplay.Text += (sender as Button).Text;
            }
            else
            {
                ClearBox();
                txtbxDisplay.Text += (sender as Button).Text;
            }
            
            //This is a made up bool for my program to follow incase the equals sign is hit for a second time. 
            keepEqual = false;
           

        }

        private void Operator_Clicked_EventHandler(object sender, EventArgs e)
        {
            try 
            {
                //gets the value of the first number given
                currentValue = Convert.ToDecimal(txtbxDisplay.Text);
                Button operatorClicked = sender as Button;

                //These are the if statements for each operator.
                if (operatorClicked.Text == "+")
                {
                    calc.Add(currentValue);
                }
                if (operatorClicked.Text == "-")
                {
                    calc.Subtract(currentValue);
                }
                if (operatorClicked.Text == "*")
                {
                    calc.Multiply(currentValue);
                }
                if (operatorClicked.Text == "/")
                {
                    calc.Divide(currentValue);
                }

                //clears box after the operator has been selected.
                ClearBox();
            }
            catch (FormatException)
            {
                MessageBox.Show("You need to put a number in first.");
            }
            catch (Exception)
            {
                MessageBox.Show("You caused an error...");
            }
            
            

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //removes the last int added. but wont go past length of 0
            if (txtbxDisplay.TextLength != 0)
            {
                txtbxDisplay.Text = txtbxDisplay.Text.Remove(txtbxDisplay.Text.Length - 1);
            }
            else
            {
                
            }
            keepEqual = false;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clears the box
            ClearBox();
            //adds a 0 to the txtbox to make it look nice
            txtbxDisplay.Text = "0";
            //if you hit the clear you dont need to keep hiting equals so the bool resets.
            keepEqual = false;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            //try statement to catch a dividbyzero exception and a format exception.
            try 
            {  
                //this if statement checks the status of my flag variable (I think thats what its called)
                if (keepEqual == false)
                {
                    //sets the current value to whats displayed in the textbox
                    currentValue = Convert.ToDecimal(txtbxDisplay.Text);
                    //sends the value to the calculator class.
                    calc.Equals(currentValue);
                    //changes my flag to true so that it wont run this part anymore.
                    keepEqual = true;
                }
                else
                {
                    //if the program gets to this part it is because the equals sign was hit more then once. 
                    calc.EqualsAgain(currentValue);
                }


                //displays the calculated value given back from the calculator class.
                txtbxDisplay.Text = calc.CurrentValue.ToString();

            }
            catch (DivideByZeroException)
            {
                //displays the Error message in the text box display on the Calculator form
                txtbxDisplay.Text =("ERROR");
                //creates a message box to show you the error. I added this because I wanted to clear the box for the user but I couldnt get 
                //an if statement to work for if another digit or operator is hit so I put a messagebox because I know you have to do 
                //something with that before the program can move on. 
                MessageBox.Show("You cant divide by 0");
                    ClearBox();
                
            }
            catch (FormatException)
            {
                MessageBox.Show("You cant leave one of the operators blank.");
            }
            catch (Exception)
            {
                MessageBox.Show("You did something wrong...");
            }
            
        } 

        //method to clear text box
        private void ClearBox() 
        {

            txtbxDisplay.Clear();
        }

        private void btnPositiveOrNegative_Click(object sender, EventArgs e)
        {
            try
            {
                //converts the value to a variable 
                decimal currentValue = Convert.ToDecimal(txtbxDisplay.Text);
                //math part of problem moved to the calculator class.
                calc.PositiveOrNegative(currentValue);

                txtbxDisplay.Text = calc.CurrentValue.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Make sure you press the number you want before pressing the -/+ button.");
            }
          

        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            //check to see if a . is already in the txtbox.
            if (!txtbxDisplay.Text.Contains("."))
            {
                txtbxDisplay.Text += (sender as Button).Text;
            }
            //no need for a else because the button just wont work until the period goes away
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            //try statement to make sure the txtbox isnt empty or blank. 
            try
            {
                //converts the txtbox to a decimal and then a small about of math is done on the 
                currentValue = Convert.ToDecimal(txtbxDisplay.Text);

                //This is the math part of the problem done in the calc class
                calc.Reciprocal(currentValue);

                //displays the answer
                txtbxDisplay.Text = calc.CurrentValue.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("You cant get the reciprocal of nothing.");
            }
            catch (Exception)
            {
                MessageBox.Show("You did something wrong...");
            }



        }

        private void btn0_Click(object sender, EventArgs e)
        {
            //checks to see if there is a 0 in the txtbox.
            //if there isnt then it adds a zero.
            if(txtbxDisplay.Text != "0")
            {
                txtbxDisplay.Text += (sender as Button).Text;
            }
            else
            {
                //if the txtbox does have a zero it will clear the txtbox and then add the number. 
                ClearBox();
                txtbxDisplay.Text += (sender as Button).Text;
            }
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            try { 

            //this is a quick Math function to get the number and display it. 
            currentValue = Convert.ToDecimal(txtbxDisplay.Text);
            txtbxDisplay.Text = Math.Sqrt((double)currentValue).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("You need to put a number in first.");
            }
            catch (Exception)
            {
                MessageBox.Show("You caused an error...");
            }
        }






        //Memory Calc Additions below...
        //it helped that i had all the above done and working without bugs.
        //I placed the additions here to hopefuly help see the additions to the program.

        
        private void btnMemoryClear_Click(object sender, EventArgs e)
        {
            //uses the memory clear method from the new memory calc class.
            calc.MemoryClear();
            //clears the textbox
            ClearBox();
            //another clear to clear the m from the memory text box.
            txtbxMemoryActive.Clear();
        }

        private void btnMemoryStore_Click(object sender, EventArgs e)
        {
            //try statement so you can only store numbers. 
            try
            {
                //variable to store a decimal.
                decimal memory;
                
                //stores the current value displayed as the memory.
                memory = Convert.ToDecimal(txtbxDisplay.Text);

                //adds an M to the memory text box to show that there is a number stored in memory
                txtbxMemoryActive.Text = "M";
                //clears the text box.
                ClearBox();
                //sends all the info to the memory calc class.
                calc.MemoryStore(memory);
            }
             
            catch (FormatException)
            {
                MessageBox.Show("You cant store a . or leave the box empty before storing");
            }
            catch (Exception)
            {
                MessageBox.Show("You caused an error...");
            }

        }

        private void btnMemoryRecall_Click(object sender, EventArgs e)
        {
            //displays the number saved in memory.
            txtbxDisplay.Text = calc.MemoryRecall().ToString();
            
        }

        private void btnMemoryPlus_Click(object sender, EventArgs e)
        {
            //must use a number for this as well. 
            try
            {
                //gets the current value
                decimal current = Convert.ToDecimal(txtbxDisplay.Text);
                
                //sends the current value to the memory add method and stores it as a variable.
                decimal answer = calc.MemoryAdd(current);

                //displays the varibale the answer was stored in.
                txtbxDisplay.Text = answer.ToString();

            }
            catch (FormatException)
            {
                MessageBox.Show("Please select a number to add to the number in memory.");
            }
            catch (Exception)
            {
                MessageBox.Show("You caused an error...");
            }



        }
    }
}
