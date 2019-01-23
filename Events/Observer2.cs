using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Observer2
    {
        public void OnUpdated(object sender, SomethingChangedEventArgs e)
        {
            Console.WriteLine($"Observer2: change catched: {e.Description}");
        }
    }
}
