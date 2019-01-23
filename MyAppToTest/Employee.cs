using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppToTest
{
    public class Employee
    {
        public Employee(string name, int age)
        {
            if(age < 16 || age > 59)
            {
                throw new ArgumentOutOfRangeException();
            }

            this._name = name;
            this._age = age;
        }

        private string _name;
        private int _age;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }


    }
}
