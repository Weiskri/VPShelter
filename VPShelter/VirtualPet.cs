using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class VirtualPet
    {
        // fields

        private string name;
        private string description;
        private string disposition;
        private bool isThirsty;
        private bool isHungry;
        private bool isSick;

        // properties

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public string Disposition
        {
            get { return this.disposition; }
            set { this.disposition = value; }
        }

        public bool IsThirsty
        {
            get { return this.isThirsty; }
            set { this.isThirsty = value; }
        }

        public bool IsHungry
        {
            get { return this.isHungry; }
            set { this.isHungry = value; }
        }

        public bool IsSick
        {
            get { return this.isSick; }
            set { this.isSick = value; }
        }

        // constructors

        public VirtualPet ()
        {
            // default constructor
        }

        public VirtualPet (string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public VirtualPet (string name, string description, string disposition, bool isThirsty, bool isHungry, bool isSick)
        {
            this.name = name;
            this.description = description;
            this.disposition = disposition;
            this.isThirsty = isThirsty;
            this.isHungry = isHungry;
            this.isSick = isSick;
        }

        // methods

        public string ShowDescription (string description)
        {
            return description;
        }

    }
}
