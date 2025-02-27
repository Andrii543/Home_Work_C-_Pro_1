using System.Text;

namespace Home_Work_Class_C__Pro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = UTF8Encoding.UTF8;


            Console.Write("1 число: ");
            int userInpuntNumberOne = Convert.ToInt32(Console.ReadLine());

            Console.Write("2 число: ");
            int userInputNumberTwo = Convert.ToInt32(Console.ReadLine());

            var cal = new Calculator();

            cal.Division(userInpuntNumberOne, userInputNumberTwo);

            cal.ToString();

            cal.Cosinus(userInpuntNumberOne);

            cal.ToStringDouble();

        }
    }
}
