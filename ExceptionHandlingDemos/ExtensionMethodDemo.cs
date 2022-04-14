using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemos
{
    class Practice
    {
         public void Func1()
        {
            Console.WriteLine("Inside Func1");
        }

        public void Func2()
        {
            Console.WriteLine("Inside Func2");
        }

        public void Func3()
        {
            Console.WriteLine("Inside Func3");
        }
    }

    // This is how we add extension Methods
    static class EnhancedPractice
    {
        public static void Func4(this Practice practice)
        {
            Console.WriteLine("Inside Func4");
        }
        public static void Func5(this Practice practice)
        {
            Console.WriteLine("Inside Func5");
        }
    }

    static class PracticeDemo
    {
         public static string ReturnFirstCharacter(this String str)
        {
            return str.Substring(1, 1);
        }
            }
    
    class ExtensionMethodDemo
    {
        static void Main()
        {
            Practice practice = new Practice();
            practice.Func1();
            practice.Func4();
            Console.WriteLine("Deepak".ReturnFirstCharacter());
        }
    }
}
