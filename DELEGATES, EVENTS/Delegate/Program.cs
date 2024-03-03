using System;
namespace D
{
    public delegate int CalcDelegate(int num1, int num2, char sign);
    class CalcProgram
    {
        public static int Calc(int num1, int num2, char sign)
        {
            switch (sign)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    if (num2 == 0) return 0;
                    return num1 / num2;
                default: return 0;
            }
        }
        public CalcDelegate funcCalc = new CalcDelegate(Calc);
    }
}
