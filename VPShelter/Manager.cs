using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Manager : Employee
    {
        // fields are incognito

        // properties
        public string ManagerName { get; set; }

        // constructors

        public Manager ()
        {
            // default constructor
        }

        public Manager (string managerName)
        {
            ManagerName = managerName;
        }

        // methods
        public override string ClockIn()
        {
            return "Hello manager, you have successfuly clocked in.";
        }

        public override double ShowID()
        {
            return EmployeeID;
        }

        public string AdoptPet ()
        {
            return "The pet has been adopted.";
        }
    }
}
