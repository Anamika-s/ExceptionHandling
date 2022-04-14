using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemos
{

    class SortedListDemo
    {
static void Main()
        {
            SortedList<int, string> list = new SortedList<int, string>()
            {
                { 1, "Ajay" },
                {2,"Deepak" },
                {10, "Lalit" },
                {3, "Parul" }
            };
           foreach(int key in list.Keys)
                Console.WriteLine($"{key} : {list[key]}");
        }
    }
}
