using System;
using static System.Console;

using System.Linq;

namespace Float_Multiplication_Assign
{
    
    partial class BinaryProductImplementation : IBinaryProductImplementation
    {
        BinaryAdditionImplementation _binaryAdditionObj = new BinaryAdditionImplementation();
        /// <summary>
        /// Converts input[float] to binary
        /// </summary>
        public void BinaryConvertion()
        {
            float firstNumber= Math.Abs(GetNumber("First"));
            
           
            float GetNumber(string whichNumber)
            {
                WriteLine($"Enter {whichNumber} Number");
                firstNumber = float.Parse(ReadLine());
                return firstNumber;

            }
            int firstIntegralNumber = (int)firstNumber;

            //Binary Conversion
            string firstIntegralBinary = Convert.ToString(firstIntegralNumber, 2);

            //String Interpolation feature [C# 6.0]
            WriteLine($"\nFirst Equalent Binary : {firstIntegralBinary}");

            //Finding Number of decimal places
            //14.345 =>decimal places are 3
            int firstDecimalPlaces = firstNumber.ToString().Split('.').Count() > 1
                  ? firstNumber.ToString().Split('.').ToList().ElementAt(1).Length
                  : 0;
            var firstFloatNumber = firstNumber - firstIntegralNumber;
            firstFloatNumber = firstFloatNumber * (int)Math.Pow(10, firstDecimalPlaces);
            int oneFloatNumber = (int)Math.Ceiling(firstFloatNumber);
            WriteLine($"\noneFloatNumber : {oneFloatNumber}");
            string firstFloatBinary = Convert.ToString(oneFloatNumber, 2);
            WriteLine($"\nFirst Equalent Binary : {firstFloatBinary}");


            float secondNumber = Math.Abs(GetNumber("Second"));
            

            int secondIntegralNumber = (int)secondNumber;
            string secondIntegralBinary = Convert.ToString(secondIntegralNumber, 2);
            WriteLine($"\nSecond Integral Binary {secondIntegralBinary}");

            //Finding Number of decimal places
            //14.345 =>decimal places are 3
            int secondDecimalPlaces = firstNumber.ToString().Split('.').Count() > 1
                  ? firstNumber.ToString().Split('.').ToList().ElementAt(1).Length
                  : 0;
            var secondFloatNumber = secondNumber - secondIntegralNumber;
            secondFloatNumber = secondFloatNumber * (int)Math.Pow(10, secondDecimalPlaces);
            int twoFloatNumber = (int)Math.Ceiling(secondFloatNumber);
            WriteLine($"\nTwo Float Number : {twoFloatNumber}");
            string secondFloatBinary = Convert.ToString(twoFloatNumber, 2);
            WriteLine($"\nSecond Equalent Binary : {secondFloatBinary}");

            int firstIBinary = Convert.ToInt32(firstIntegralBinary);
            int secondIBinary = Convert.ToInt32(secondIntegralBinary);
            int firstFBinary = Convert.ToInt32(firstFloatBinary);
            int secondFBinary = Convert.ToInt32(secondFloatBinary);
            int integralMultiply = BinaryCondition(firstIBinary, secondIBinary);
            int floatMultiply = BinaryCondition(firstFBinary, secondFBinary);
            WriteLine($"Product of two binary integralMultiply numbers: {integralMultiply}");
            WriteLine($"Product of two binary floatMultiply numbers: {floatMultiply}");
            string integralNumber = string.Empty;
            string fractionalNumber = string.Empty;
            integralNumber = Convert.ToString(integralMultiply);
            fractionalNumber = Convert.ToString(floatMultiply);

            // Conversion from string in int
            int floatFirstNumber = Convert.ToInt32(fractionalNumber, 2); 
            string sFirstNumber = Convert.ToString(floatFirstNumber);
            char retrieveFirstCharacter = sFirstNumber.ElementAt(0);
            int retrieveFirstElement = (int)char.GetNumericValue(retrieveFirstCharacter);
            string fractionNumber = Convert.ToString(retrieveFirstElement);

            //firstIntegralNumber
            
            string fractionNumberBinary = Convert.ToString(retrieveFirstElement, 2);

            string finalResult = _binaryAdditionObj.BinaryAddition(integralNumber, fractionNumberBinary);
            WriteLine($"Final Multiplied Value : {finalResult}");
            int finalValue = Convert.ToInt32(finalResult, 2); 
            WriteLine($"Final Multiplied Value : {finalValue}.{floatFirstNumber}");
            Console.ReadKey();
        }
        /// <summary>
        /// Passing two inputs which gets product from BinaryProduct function
        /// </summary>
        /// <param name="valueOne"></param>
        /// <param name="valueTwo"></param>
        /// <returns></returns>
        public int BinaryCondition(int valueOne, int valueTwo)
        {
            int firstBinary, secondBinary, multiply = 0;
            firstBinary = valueOne;
            secondBinary = valueTwo;
            int digit, factor = 1;
            while (secondBinary != 0)
            {
                digit = secondBinary % 10;
                if (digit == 1)
                {
                    firstBinary = firstBinary * factor;
                    multiply = BinaryProduct(firstBinary, multiply);
                }
                else
                {
                    firstBinary = firstBinary * factor;
                }
                secondBinary = secondBinary / 10;
                factor = 10;
            }
            return multiply;
        }
        /// <summary>
        /// Getting product of two numbers
        /// </summary>
        /// <param name="binaryValueOne"></param>
        /// <param name="binaryValueTwo"></param>
        /// <returns></returns>
        public int BinaryProduct(int binaryValueOne, int binaryValueTwo)
        {
            int start = 0, remainder = 0;
            int[] sum = new int[40];
            int binaryprod = 0;

            while (binaryValueOne != 0 || binaryValueTwo != 0)
            {
                sum[start++] = (binaryValueOne % 10 + binaryValueTwo % 10 + remainder) % 2;
                remainder = (binaryValueOne % 10 + binaryValueTwo % 10 + remainder) / 2;
                binaryValueOne = binaryValueOne / 10;
                binaryValueTwo = binaryValueTwo / 10;
            }
            if (remainder != 0)
            {
                sum[start++] = remainder;
            }
            --start;
            while (start >= 0)
            {
                binaryprod = binaryprod * 10 + sum[start--];
            }
            return binaryprod;
        }
        
    }
}
