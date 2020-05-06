using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Net_Quiz3
{
    class Student
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Boolean isRegistered { get; set; }

        public Student(int id, string fName, string lName, Boolean isReg)
        {
            this.Id = id;
            this.FirstName = fName;
            this.LastName = lName;
            this.isRegistered = isReg;
        }
    }
}
