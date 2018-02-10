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

        public string FeedPets ()
        {
            return "All pets have been fed.";
        }

        public string WaterPets ()
        {
            return "All pets now have water.";
        }

        public string CleanCages()
        {
            return "All pets' cages have been cleaned!";
        }

        public string Vet()
        {
            return "All pets are now healthy!";
        }

        public string PlayWithPet(string petName, bool isHungry, bool isThirsty, bool isSick, bool isDirty)
        {
            if ((isHungry == true) || (isThirsty == true) || (isSick == true) || (isDirty == true))
            {
                return petName + " does not want to play.";
            }
            else
            {
                return petName + " is binkying!";
            }
        }
    }
}
