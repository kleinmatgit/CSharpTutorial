using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Observer
    {
        public void OnChanged(object sender, SomethingChangedEventArgs e)
        {
            Console.WriteLine($"Observer: I'm catching the change: {e.Description}");
        }
    }
}
