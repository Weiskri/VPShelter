using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public abstract class VirtualPetShelter
    {
        // fields are incognito

        // properties
        public List<VirtualPet> ShelterPets { get; set; }
        public List<Employee> ShelterEmployees { get; set; }

        // constructors 
        // none because this is an abstract class!

        // methods
        // empty thus far 
    }
}
