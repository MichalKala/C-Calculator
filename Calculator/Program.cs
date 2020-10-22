using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Schema;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            //variables declaration
            string firstNumberTest;
            string secondNumberTest;
            double firstNumber;
            double secondNumber;
            double result;
            bool firstNumberValid;
            bool secondNumberValid;
            bool OperationValid = false;


            //Let user input two numbers and store them into variables. 
            //For each number loop until input is correct to prevent errors
            do
            {
                Console.Write("Please enter first number: ");
                firstNumberTest = Console.ReadLine();
                firstNumberValid = Double.TryParse(firstNumberTest, out firstNumber);
               
            } while (firstNumberValid == false);
            
            
            do
            {
                Console.Write("Please enter second number: ");
                secondNumberTest = Console.ReadLine();
                secondNumberValid = Double.TryParse(secondNumberTest, out secondNumber);

            } while (secondNumberValid == false);



            //Inform user about available math operations
            Console.WriteLine("Below are available operations to select:");
            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Substraction");
            Console.WriteLine("3: Multiplication");
            Console.WriteLine("4: Division");

            //Let user select one of the operations above and store it into variable
            do
            {
                
                Console.Write("Enter selected operation: ");
                int selectedOperation = Convert.ToInt32(Console.ReadLine());

                //Perform selected math operation
                switch (selectedOperation)
                {
                    case 1:
                        result = MathOperations.Addition(firstNumber, secondNumber);
                        Console.WriteLine(firstNumber + " + " + secondNumber + " = " + result);
                        OperationValid = true;
                        break;

                    case 2:
                        result = MathOperations.Substraction(firstNumber, secondNumber);
                        Console.WriteLine(firstNumber + " - " + secondNumber + " = " + result);
                        OperationValid = true;
                        break;

                    case 3:
                        result = MathOperations.Multiplication(firstNumber, secondNumber);
                        Console.WriteLine(firstNumber + " * " + secondNumber + " = " + result);
                        OperationValid = true;
                        break;

                    case 4:
                        result = MathOperations.Division(firstNumber, secondNumber);
                        Console.WriteLine(firstNumber + " / " + secondNumber + " = " + result);
                        OperationValid = true;
                        break;

                    default:
                        Console.WriteLine("Invalid number! Please select one of the following:");
                        Console.WriteLine("1: Addition");
                        Console.WriteLine("2: Substraction");
                        Console.WriteLine("3: Multiplication");
                        Console.WriteLine("4: Division");
                        break;
                }
            } while (OperationValid == false);


            //Pause the script
            Console.ReadLine();
            
        }
    }
}
