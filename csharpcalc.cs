using System; //System namespace
using System.Text;
using System.Threading.Tasks;
 
namespace calculator_c_sharp //Container for classes
{
    class Program //created class
    {
        static void Main(string[] args) //static: Method does not belong to the Program class; void: Method does not have return value
        {
            string value;
            do
            {
                int res; //res = result variable
                Console.Write("Enter first number:");
                int num1 = Convert.ToInt32(Console.ReadLine()); // convert input to variable
                Console.Write("Enter second number:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter symbol(/,+,-,*):");
                string symbol = Console.ReadLine();
 
                switch (symbol) //switch case
                {
                    case "+":
                        res = num1 + num2;
                        Console.WriteLine("Addition:" + res);
                        break;
                    case "-":
                        res = num1 - num2;
                        Console.WriteLine("Subtraction:" + res);
                        break;
                    case "*":
                        res = num1 * num2;
                        Console.WriteLine("Multiplication:" + res);
                        break;
                    case "/":
                        res = num1 / num2;
                        Console.WriteLine("Division:" + res);
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
                Console.Write("Do you want to continue(y/n):");
                value = Console.ReadLine();
            }
            while (value=="y" || value=="Y");
        }
    }
 
}