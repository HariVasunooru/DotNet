
using System.Linq;

namespace Float_Multiplication_Assign
{
    partial class BinaryProductImplementation
    {
        public class BinaryAdditionImplementation
        {
            /// <summary>
            /// Adding integral and fractional data
            /// </summary>
            /// <param name="integralNumber"></param>
            /// <param name="fractionalNumber"></param>
            /// <returns></returns>
            public string BinaryAddition(string integralNumber, string fractionalNumber)
            {
                int integralLength = integralNumber.Length;
                int fractionalLength = fractionalNumber.Length;
                int lengthDiff = Padding();

                int Padding()
                {
                    if (integralLength >= fractionalLength)
                    {
                        lengthDiff = integralLength - fractionalLength;
                        for (int i = 1; i <= lengthDiff; i++)
                        {
                            fractionalNumber = '0' + fractionalNumber;
                        }
                    }
                    else
                    {
                        lengthDiff = fractionalLength - integralLength;
                        for (int i = 1; i <= lengthDiff; i++)
                        {
                            integralNumber = '0' + integralNumber;
                        }
                    }
                    return lengthDiff;
                }
                char firstCharacter, secondCharacter;
                int firstDigit, secondDigit;
                string finalString = string.Empty;
                for (int i = fractionalNumber.Length - 1; i >= 0; i--)
                {
                    firstCharacter = integralNumber.ElementAt(i);
                    firstDigit = (int)char.GetNumericValue(firstCharacter);
                    secondCharacter = fractionalNumber.ElementAt(i);
                    secondDigit = (int)char.GetNumericValue(secondCharacter);
                    int nextDigit, carry = 0, digit;

                    digit = firstDigit + secondDigit + carry;
                    if (i != 0)
                    {
                        if (digit == 2)
                            digit = 10;
                        if (digit == 3)
                            digit = 11;
                        if (digit >= 10)
                        {
                            nextDigit = digit % 10;
                            carry = digit / 10;

                        }
                        else
                        {
                            nextDigit = digit;
                            carry = 0;
                        }

                    }
                    else
                    {
                        if (digit == 2)
                        {
                            digit = 10;
                        }
                        if (digit == 3)
                        {
                            digit = 11;
                        }
                        nextDigit = digit;
                    }
                    finalString = nextDigit + finalString;

                }
                return finalString;
            }

        }
        
    }
}
