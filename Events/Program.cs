using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSimpleEvent();
            TestObserverPattern();
        }

        /* Event Handler function */
        static void OnNameUpdated(object sender, NameUpdatedEventArgs e)
        {
            Console.WriteLine($"Name updated to {e.Name}");
        }

        static void TestSimpleEvent()
        {
            var people = new People("Mat");
            people.NameUpdated += OnNameUpdated;
            people.Name = "Pierre";
        }

        static void TestObserverPattern()
        {
            var observable = new Observable();
            var observer = new Observer();
            var observer2 = new Observer2();
            observable.SomethingChanged += observer.OnChanged;
            observable.SomethingChanged += observer2.OnUpdated;
            observable.Run();
        }
    }
}
