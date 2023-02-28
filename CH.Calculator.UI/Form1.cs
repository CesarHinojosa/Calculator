namespace CH.Calculator.UI
{
    public partial class Form1 : Form
    {
        Calculator calculator = new Calculator();
        public Form1()
        {
            InitializeComponent();
            
            
        }
        private bool IsOperatorClicked = false;
        private bool IsAnswered = false;
        private bool IsDecimalClicked = false;
        
        //this grabs the text of the button 
        //then sends it to the PrintNumber method to display on the Display
        public void NumberEntered(object sender, EventArgs e)
        {
            Button? btnNum = sender as Button;
            if (btnNum != null) 
            {
                string strNum = btnNum.Text;
                PrintNumber(strNum);
            }
            
        }

        //This prints the text of the button onto the display 
        public void PrintNumber(string strNum)
        {
            string num = txtDisplay.Text + strNum;
            txtDisplay.Text = num;
            Operation();
            
        }
       
        //helps convert the number to a double and sends it to the class
        public void Operation()
        {
            double firstNum;
            double secondNum;
            
            if (IsOperatorClicked == false)
            {
                if (double.TryParse(txtDisplay.Text, out firstNum))
                {
                    calculator.FirstNum = firstNum;
                }
            }
            else
            {
                if (double.TryParse(txtDisplay.Text, out secondNum))
                {
                    
                    calculator.SecondNum = secondNum;
                    
                }
            }
        }

        //this gets the text of the operation pressed
        //the operation text gets sent to the class
        public void OperationEntered(object sender, EventArgs e)
        {  
            Button? btnOperator = sender as Button;
                if (btnOperator != null)
                {
                    string strOperator = btnOperator.Text;
                    calculator.Op = strOperator; 
                    txtDisplay.Text = ""; 
                    IsOperatorClicked = true;
                //after operation entered the Decimal goes back to default value
                    IsDecimalClicked = false;
                }  
        }

        //grabs both numbers and operation and calculates the answer
        //if the Equal button is clicked again it redoes the calculation
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (IsAnswered == false)
            {

                try
                {
                    txtDisplay.Text = calculator.CalculateAnswer().ToString();
                    IsAnswered = true;
                }
                catch(DivideByZeroException)
                {
                    
                    txtDisplay.Text = "Error";
                }
            }
            else
            {
                try
                {
                    txtDisplay.Text = calculator.CalculateEqual().ToString();
                }
                catch(DivideByZeroException)
                {
                    
                    txtDisplay.Text = "Error";

                }
                  
            }     
        }

        private void btnPosNeg_Click(object sender, EventArgs e)
        {
            double dblNumber;
            if (double.TryParse(txtDisplay.Text, out dblNumber)) 
            {
                txtDisplay.Text = string.Empty;
                dblNumber = dblNumber * -1;
                PrintNumber(dblNumber.ToString());
            }    
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            IsOperatorClicked = false;
            IsAnswered = false;
            IsDecimalClicked = false;
        }

        //goes to the end of the string if the button is pressed deletes character one by one
        
        private void btnBack_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            Operation();
        }

        //grabs the text of the Decimal button and displays it to the text
        //once the Decimal button is clicked it does not allow the user to re-enter the decimal 
        private void btnDecimal_Click(object sender, EventArgs e)
        {    
            Button? btnNum = sender as Button;
            if (btnNum != null)
            {
                string strDec = btnNum.Text;
                if(IsDecimalClicked == false) 
                {
                    PrintNumber(strDec);
                    IsDecimalClicked = true;   
                }         
            } 
        }

        //grabs the number(s) and finds the SquareRoot 
        //if the SquareRoot button is clicked again it redoes the calculation
        private void btnSquareRoot_Click(object sender, EventArgs e)
        {

            IsOperatorClicked = true;
            
            if(IsAnswered == false)
            {
                IsAnswered = true;
                txtDisplay.Text = calculator.SquareRoot().ToString();
                
            }
            else
            {
                txtDisplay.Text = calculator.SquareRoot2().ToString();
            }
            
        }

        //grabs the number entered and does the calculation
        //if the reciprocal button is pressed again it does the calculation again
        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            IsOperatorClicked = true;

            if (IsAnswered == false)
            {
                IsAnswered = true;
                txtDisplay.Text = calculator.OneOverX().ToString();

            }
            else
            {
                txtDisplay.Text = calculator.AnsOverX().ToString();
            }

        }
    }
}