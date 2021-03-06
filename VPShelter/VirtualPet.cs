﻿using System;
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
        private bool isDirty;

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

        public bool IsDirty
        {
            get { return this.isDirty; }
            set { this.isSick = value; }
        }

        // constructors

        public VirtualPet()
        {
            // default constructor
        }

        public VirtualPet(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public VirtualPet(string name, string description, string disposition, bool isThirsty, bool isHungry, bool isSick)
        {
            this.name = name;
            this.description = description;
            this.disposition = disposition;
            this.isThirsty = isThirsty;
            this.isHungry = isHungry;
            this.isSick = isSick;
        }

        // methods

        public void TickInitial()
        {
            Random r = new Random();
            List<bool> boolList = new List<bool>() { true, false };
            int dirtyIndex = r.Next(boolList.Count);
            isDirty = boolList[dirtyIndex];
            int hungryIndex = r.Next(boolList.Count);
            isHungry = boolList[hungryIndex];
            int thirstyIndex = r.Next(boolList.Count);
            isThirsty = boolList[thirstyIndex];
            if ((isDirty == true) && ((isHungry == true)))
            {
                isSick = true;
            }
            else
            {
                isSick = false;
            }

            // initial disposition

            if ((isDirty == true) && ((isSick == true)))
            {
                disposition = "angry";
            }
            else if ((isDirty == false) && ((isHungry == false) && (isThirsty == false)))
            {
                disposition = "happy";
            }
            else
            {
                disposition = "grumpy";
            }
        }

        // method to change the value of isHungry for each pet that is fed

        public void HungerStatus()
        {
            isHungry = false;
            isThirsty = true;
            isDirty = true;
        }

        // method to change the value of isThirsty for each pet that is fed

        public void ThirstStatus()
        {
            isThirsty = false;
        }

        // method to change isDirty to false when cleaning

        public void CageStatus() // this is really silly that I have to do this!
        {
            isDirty = false;
        }

        // method to change isSick to false when taking pets to vet

        public void HealthStatus()
        {
            isSick = false;
        }

        // another tick method to ensure that values properly update
        public void TickReg(bool isHungry, bool isThirsty, bool isDirty, bool isSick)
        {
            if ((isDirty == true) && ((isHungry == true)))
            {
                isSick = true;
            }
            else
            {
                isSick = false;
            }

            // disposition

            if ((isDirty == true) && ((isSick == true)))
            {
                disposition = "angry";
            }
            else if ((isDirty == false) && ((isHungry == false) && (isThirsty == false)))
            {
                disposition = "happy";
            }
            else
            {
                disposition = "grumpy";
            }
        }

        public string FeedTreat(string petName, bool isThirsty)
        {

            isThirsty = true;
            List<string> foodList = new List<string>() { "cilantro", "kale", "banana", "parsley", "basil", "romaine lettuce" };
            Random r = new Random();
            int foodIndex = r.Next(foodList.Count);
            string food = foodList[foodIndex];
            switch (petName)
            {
                case "nietzsche":
                    return "Nietzsche refused the " + food + " and bit you.";
                    break;

                case "hegel":
                    if ((food == "banana") || (food == "parsley") || (food == "romaine lettuce"))
                    {
                        return "Hegel ate the " + food + " happily.";
                    }
                    else
                    {
                        return "Hegel refused the " + food + " and thumped.";
                    }
                case "simone":
                    return "Simone sniffed the " + food + " inquisitively and devoured it.";
                    break;
                case "kant":
                    if (food == "banana")
                    {
                        return "Kant refused the banana.";
                    }
                    else
                    {
                        return "Kant ate the " + food + ".";
                    }
                default:
                    return "The pet refused the food.";
                    break;
            }

        }

    }
}
