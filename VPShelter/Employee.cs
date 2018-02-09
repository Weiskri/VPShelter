using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public abstract class Employee
    {
        // fields are incognito

        // properties
        public double EmployeeID { get; set; }

        // constructors
       

        // methods -- these are all abstract methods
        public abstract double ShowID();
        public abstract string ClockIn();
    }
}
