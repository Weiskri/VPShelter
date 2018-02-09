using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Rabbit : VirtualPet
    {
        // fields are incognito

        // properties
        public string RabbitBreed { get; set; }
        public string FoodType { get; set; }

        // constructors

        public Rabbit ()
        {
            // default constructor
        }

        public Rabbit (string rabbitBreed, string foodType)
        {
            RabbitBreed = rabbitBreed;

        }
    }
}
