using static  System.Console;

namespace Float_Multiplication_Assign
{
    class Program
    {
        static void Main(string[] args)
        {
            IBinaryProductImplementation _binaryObj;
            _binaryObj= new BinaryProductImplementation();
            _binaryObj.BinaryConvertion();

            ReadKey();
        }
    }
}
