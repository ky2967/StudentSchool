using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibModel
{
    public class Student
    {
        public School school = null;

        public Student(string sName)
        {
            Name = sName;
            school = new School();
        }

        public string Name
        {
            get;
            set;
        }
    }
}
