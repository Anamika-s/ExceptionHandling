using System;

namespace ExceptionHandlingDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = 0;
            try {
                int[] nums = new int[10];
                Console.WriteLine("Enter Numerator");
                int num = Byte.Parse(Console.ReadLine());
                Console.WriteLine("Enter Denominator");
                int den = Byte.Parse(Console.ReadLine());
                res= num / den;
                Console.WriteLine("Result is " + res);
                nums[20] = 100;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by 0");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter number only");
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Please enter numbers within a range");
            }
               catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine($"Result is {res}");
            }
    }
}
