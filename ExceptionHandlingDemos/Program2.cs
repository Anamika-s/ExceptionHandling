using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemos
{
    class Program2
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter Name");
                string name = Console.ReadLine();
                if (name.Length < 10)
                    throw new CustomException("Min 10 characters needed");
                Console.WriteLine("Enter Age");
                int age = Byte.Parse(Console.ReadLine());
                if (age < 20 || age > 40)
                    throw new CustomException("Range for Age is 20 to 40");
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
           catch(CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
                {
                Console.WriteLine("I m in Finally block");

            }
        }
    }
}
