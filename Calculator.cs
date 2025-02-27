using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_Class_C__Pro
{
    public class Calculator
    {

        private int sumIntegers = 0;
        private double sumDouble = 0;

        //Метод додавання
        public int Addition(int num1, int num2) => sumIntegers = num1 + num2;

        //Метод віднімання
        public int Subtraction(int num1, int num2) => sumIntegers = num1 - num2;

        //Метод ділення
        public double Division(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Ділення на 0 не можливе");
            }
            return sumIntegers = num1 / num2;
            
        }

        //Метод множення
        public int Multiplication(int num1, int num2) => sumIntegers = num1 * num2;

        //Метод косінуса за допомогою класу Math який входить в бібліотеку .Net Framework
        public double Cosinus(int num) => sumDouble = Math.Cos(num);

        //Метод сінуса
        public double Sinus(int num) => sumDouble = Math.Sin(num);


        public void ToString() => Console.WriteLine($"Сумма : {sumIntegers}");

        public void ToStringDouble() => Console.WriteLine($"Cума : {sumDouble:F2}");



    }
}
