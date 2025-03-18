using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4Q2
{
    public class student
    {
        // Private data members
        private int _studentId;
        private string _studentFname;
        private string _studentLname;
        private char _studentGrade;

        // Public properties to encapsulate the private fields
        public int StudentId
        {
            get { return _studentId; }
            set { _studentId = value; }
        }

        public string StudentFname
        {
            get { return _studentFname; }
            set { _studentFname = value; }
        }

        public string StudentLname
        {
            get { return _studentLname; }
            set { _studentLname = value; }
        }

        public char StudentGrade
        {
            get { return _studentGrade; }
            set { _studentGrade = value; }
        }
    }
}
