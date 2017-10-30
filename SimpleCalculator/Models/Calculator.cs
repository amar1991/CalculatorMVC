using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleCalculator.Models
{
    public class Calculator
    {
        private int number1 { get; set; }
        private int number2 { get; set; }
        public dynamic outcome { get; set; }
        

        public Calculator(int num1, int num2) 
        {
            this.number1 = num1;
            this.number2 = num2;
        
        }


        public int Add() 
        {
            return outcome = number1 + number2;
        
        }

        public int Subtract()
        {
            return outcome = number1 - number2;

        }
        public int Multiply()
        {
            return outcome = number1 * number2;

        }

        public double Divide()
        {
            return (outcome) = number1 / number2;

        }




    }
}