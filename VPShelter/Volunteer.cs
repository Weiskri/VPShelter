using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Volunteer : Employee
    {
        // fields are incognito
        // properties

        public int HoursAvailable { get; set; }
        public string VolunteerName { get; set; }

        // constructors

        public Volunteer ()
        {
            // default constructor
        }
        
        public Volunteer (int hoursAvailable, string volunteerName)
        {
            HoursAvailable = hoursAvailable;
            VolunteerName = volunteerName;
        }

        // methods
        public override string ClockIn()
        {
            return "Hello volunteer, you have uccessfully clocked in!";
        }
        public override double ShowID()
        {
            return EmployeeID;
        }

        public string feedPets ()
        {
            return "All pets have been fed.";
        }

        public string waterPets ()
        {
            return "All pets now have water.";
        }
    }
}
