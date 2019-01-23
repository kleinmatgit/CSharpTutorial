using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnippetsTest
{
    enum MyEnum
    {
        orange,
        apple
    }

    interface IMyInterface
    {
        void DoSomething();
    }

    class MySnippet : IMyInterface
    {
        public MySnippet()
        {

        }
        
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public void DoSomething()
        {
            Console.WriteLine("I'm doing something");
        }
    }
}
