using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
     abstract class Student : Human
    {
        public Student(string firstName, string lastName) : base (firstName, lastName)
        {

        }

        public abstract void Study();


    }
}
