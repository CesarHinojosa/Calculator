using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH.Calculator.UI
{
    public class Calculator
    {
       public double FirstNum { get; set; }
       public double SecondNum { get; set; }
       public double Answer { get; set; }
       public string Op { get; set; }

       public string Error = "Can't Divide By 0";

       
        public double CalculateAnswer()
        {
            switch (Op)
            {
                case "+": 
                    return Answer = FirstNum + SecondNum;
                case "-":
                    return Answer = FirstNum - SecondNum;
                case "*":
                    return Answer = FirstNum * SecondNum;
                case "/":
                    if(SecondNum == 0)
                    {
                        throw new DivideByZeroException();
                    } 
                    else
                    {
                        return Answer = FirstNum / SecondNum;
                    }     
                default:
                    break;
                
            }
            return Answer;
        }

        public double CalculateEqual()
        {
            switch (Op) 
            {
                case "+":
                    return Answer = Answer + SecondNum;
                case "-":
                    return Answer = Answer - SecondNum;
                case "*":
                    return Answer = Answer * SecondNum;
                case "/":
                    if (SecondNum == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    else
                    {
                        return Answer = Answer / SecondNum;
                    }

                default:
                    break;
            }
            return Answer;
        }

        public double SquareRoot()
        {
            
            Answer = Math.Sqrt(FirstNum);
            return Answer;
        }

        public double SquareRoot2()
        {
            return Answer = Math.Sqrt(Answer);
            return Answer;
        }
        

        public double OneOverX()
        {
            Answer = 1 / FirstNum;
            return Answer;
        }

        public double AnsOverX() 
        {
            return Answer = 1 / Answer;
        }

        


      

       




    }


    
}
