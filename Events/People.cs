using System;

namespace Events
{
    /* simple class which raised an event when its property is updated  */
    class People
    {
        public event EventHandler<NameUpdatedEventArgs> NameUpdated;

        private string _name;

        public People(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                NameUpdated?.Invoke(this, new NameUpdatedEventArgs(this._name));
            }
        }
    }

    class NameUpdatedEventArgs : EventArgs
    {
        public NameUpdatedEventArgs(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }

}
