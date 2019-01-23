using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Observable
    {
        public event EventHandler<SomethingChangedEventArgs> SomethingChanged;

        public void Run()
        {
            SomethingChanged?.Invoke(this, new SomethingChangedEventArgs("fire in the hole!!"));
        }
    }

    public class SomethingChangedEventArgs : EventArgs
    {
        public SomethingChangedEventArgs(string descr)
        {
            Description = descr;
        }

        public string Description { get; private set; }
    }
}
