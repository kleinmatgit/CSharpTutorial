using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public class Developer : IDeveloper
    {
        public string CodingLanguage()
        {
            return "C#";
        }

        public string GetName()
        {
            return "Tof";
        }
    }
}
