using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemos
{
    abstract class Mammal
    {
        public abstract void Get();

    }
    class Bird : Mammal
    {
        public override void Get()
        {
            Console.WriteLine("Bird Class");
        }
    }
    class Animal : Mammal
    {
        public override void Get()
        {
            Console.WriteLine("Animal Class");
        }
    }
    class Decide
    {
        public Decide(object obj)
        {
            if (obj is Animal)
            {
                obj = new Animal();
               


            }
            else
                obj = new Bird();

        }
    }
    class IsAsDemo
    {
        static void Main()
        {
            Console.WriteLine("Enter Number");
            //int x = Byte.Parse(Console.ReadLine());
            byte x1;
           
            Byte.TryParse(Console.ReadLine(), out x1);
            Console.WriteLine(x1);
            int num = 90;
            Console.WriteLine((byte)num is byte);
            Console.WriteLine(byte.MaxValue);
            //Console.WriteLine(byte.MinValue);
            //Console.WriteLine(Int32.MinValue);
            //Mammal mammal = new Animal();
            //Console.WriteLine(mammal is Animal);
            ////if (mammal is Animal)
            ////{
            //    Console.WriteLine("true");
            //    Decide decide = new Decide(mammal);
            //mammal.Get();
            ////}
            ////else
            ////    Console.WriteLine(false);


            ArrayList list = new ArrayList();
            list.Add("Ajay");
            list.Add(1);
        list.Add(2);
            list.Add("2");
            foreach (var x in list)
            {  
                string res = x as string;
                if (res != null)
                    Console.WriteLine(res);
                else
                    Console.WriteLine("Can not convert");
            }
        }
    }
}
