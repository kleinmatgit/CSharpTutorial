using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesTutorial
{
    class Program
    {
        private delegate int dlAdd(int x, int y);
        private delegate void dlRun(string s);

        static void Main(string[] args)
        {
            var dl = new dlAdd(MyAdd);
            Console.WriteLine($"Result: {dl(2,5)}");

            var dl2 = new dlRun(MyRun);
            dl2("something");
        }

        static int MyAdd(int x, int y)
        {
            return x + y;
        }

        static void MyRun(string s)
        {
            Console.WriteLine($"Running {s}");
        }
    }
}
