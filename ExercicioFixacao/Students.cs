using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoSeis
{
    class Students
    {
        string StudentName;
        string StudentEmail;

        public Students(string name, string email)
        {
            StudentName = name;
            StudentEmail = email;
        }

        public override string ToString()
        {
            return StudentName + ", " + StudentEmail;
        }
    }
}