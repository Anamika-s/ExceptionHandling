using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemos
{
    class PracticeIndexer
    {
        private string[] names = new string[10];
        // Declare indexer
        public string this[int index]
        {
            get
            {
                return names[index];
            }
            set
            {
                names[index] = value;
            }
        }

    }
    class IndexerDemo
    {
        static void Main()
        {
            PracticeIndexer practiceIndexer = new PracticeIndexer();
            practiceIndexer[0] = "Ajay";
            practiceIndexer[1] = "Deepak";
            Console.WriteLine(practiceIndexer[0]);

        }
    }

}
