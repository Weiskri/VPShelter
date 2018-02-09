using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiating objects
            Manager managerOne = new Manager("Kelly");
            Volunteer volunteer = new Volunteer();
            Volunteer volunteerOne = new Volunteer(30, "Lisa");
            Volunteer volunteerTwo = new Volunteer(20, "Greg");
            Volunteer volunteerThree = new Volunteer(15, "Eric");

            Rabbit rabbit = new Rabbit();
            Rabbit rabbitOne = new Rabbit("Continental Giant", "Oat hay");
            Rabbit rabbitTwo = new Rabbit("Lionhead", "Timothy hay");
            Rabbit rabbitThree = new Rabbit("Netherland dwarf", "Meadowgrass hay");
            Rabbit rabbitFour = new Rabbit("Holland lop", "Timothy hay");

            // setting ID numbers for employees
            managerOne.EmployeeID = 15695;
            volunteerOne.EmployeeID = 22506;
            volunteerTwo.EmployeeID = 74513;
            volunteerThree.EmployeeID = 39600;

            // setting rabbit names

            rabbitOne.Name = "Nietzsche";
            rabbitTwo.Name = "Hegel";
            rabbitThree.Name = "Simone";
            rabbitFour.Name = "Kant";

            // setting rabbit tick values when menu is first opened
            rabbitOne.Tick();
            rabbitTwo.Tick();
            rabbitThree.Tick();
            rabbitFour.Tick();

            // user main menu (initial greeting)

            Console.WriteLine("Welcome to the Small Pet Rescue!");
            Console.WriteLine("To get started, please select what type of employee you are:");
            Console.WriteLine("If you are a manager, press 1.");
            Console.WriteLine("If you are a volunteer, press 2.");
            int userChoice = int.Parse(Console.ReadLine());
            if (userChoice == 1)
            {
                do
                {
                    Console.WriteLine("Manager menu:");
                    Console.WriteLine("To view volunteer information, press 1.");
                    Console.WriteLine("To clock in, press 2.");
                    Console.WriteLine("To view the status of the pets, press 3.");
                    Console.WriteLine("To initiate the adoption process for a pet, press 4.");
                    Console.WriteLine("To exit and return to the main menu, press 5.");
                    userChoice = int.Parse(Console.ReadLine());
                    switch (userChoice)
                    {
                        case 1:
                            Console.WriteLine("Employee information:");
                            Console.WriteLine("Name   ID   Hours");
                            Console.WriteLine("-------------------");
                            Console.WriteLine("{0} {1} {2}", volunteerOne.VolunteerName, volunteerOne.EmployeeID, volunteerOne.HoursAvailable);
                            Console.WriteLine("{0} {1} {2}", volunteerTwo.VolunteerName, volunteerTwo.EmployeeID, volunteerTwo.HoursAvailable);
                            Console.WriteLine("{0} {1} {2}", volunteerThree.VolunteerName, volunteerThree.EmployeeID, volunteerThree.HoursAvailable);
                            break;
                        case 2:
                            Console.WriteLine(managerOne.ClockIn());
                            break;
                        case 3:
                            
                            Console.Clear();
                            Console.WriteLine("Name      Breed             Disposition Thirsty? Hungry? Sick? Cage dirty?");
                            Console.WriteLine("--------------------------------------------------------------------------");
                            Console.WriteLine("{0} {1} {2}      {3}     {4}   {5}  {6}", rabbitOne.Name, rabbitOne.RabbitBreed, rabbitOne.Disposition, rabbitOne.IsThirsty, rabbitOne.IsHungry, rabbitOne.IsSick, rabbitOne.IsDirty);
                            Console.WriteLine();
                            Console.WriteLine("{0}     {1}          {2}      {3}     {4}   {5}  {6}", rabbitTwo.Name, rabbitTwo.RabbitBreed, rabbitTwo.Disposition, rabbitTwo.IsThirsty, rabbitTwo.IsHungry, rabbitTwo.IsSick, rabbitTwo.IsDirty);
                            Console.WriteLine();
                            Console.WriteLine("{0}    {1}  {2}      {3}     {4}   {5}  {6}", rabbitThree.Name, rabbitThree.RabbitBreed, rabbitThree.Disposition, rabbitThree.IsThirsty, rabbitThree.IsHungry, rabbitThree.IsSick, rabbitThree.IsDirty);
                            Console.WriteLine();
                            Console.WriteLine("{0}      {1}       {2}      {3}     {4}   {5}  {6}", rabbitFour.Name, rabbitFour.RabbitBreed, rabbitFour.Disposition, rabbitFour.IsThirsty, rabbitFour.IsHungry, rabbitFour.IsSick, rabbitFour.IsDirty);
                            Console.WriteLine();
                            Console.WriteLine();

                            break;
                        case 4:
                            Console.WriteLine("Which pet is the adopter interested in?");
                            Console.WriteLine("Available pets: {0}, {1}, {2}, {3}", rabbitOne.Name, rabbitTwo.Name, rabbitThree.Name, rabbitFour.Name);
                            string adopterPet = Console.ReadLine().ToLower();
                            if (adopterPet == "nietzsche")
                            {
                                Console.WriteLine("Nietzsche is a chestnut agouti 8 year Continental Giant.");
                            }
                            else if (adopterPet == "hegel")
                            {
                                Console.WriteLine("Hegel is a 5 year old broken chocolate-colored Lionhead.");
                            }
                            else if (adopterPet == "simone")
                            {
                                Console.WriteLine("Simone is a 2 year old silver Netherland Dwarf.");
                            }
                            else
                            {
                                Console.WriteLine("Kant is a 4 year old black Holland Lop.");
                            }

                            Console.WriteLine();
                            Console.WriteLine("Would the adopter like to adopt this pet? Type \"yes\" or \"no\".");
                            string adoptPet = Console.ReadLine().ToLower();
                            if (adoptPet == "yes")
                                Console.WriteLine(managerOne.AdoptPet());
                            else
                            {
                                Console.WriteLine("The pet has not been adopted.");
                            }
                            break;
                    }
                } while (userChoice != 5);

            }
            else
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Name      Breed             Disposition Thirsty? Hungry? Sick? Cage dirty?");
                    Console.WriteLine("--------------------------------------------------------------------------");
                    Console.WriteLine("{0} {1} {2}      {3}     {4}   {5}  {6}", rabbitOne.Name, rabbitOne.RabbitBreed, rabbitOne.Disposition, rabbitOne.IsThirsty, rabbitOne.IsHungry, rabbitOne.IsSick, rabbitOne.IsDirty);
                    Console.WriteLine();
                    Console.WriteLine("{0}     {1}          {2}      {3}     {4}   {5}  {6}", rabbitTwo.Name, rabbitTwo.RabbitBreed, rabbitTwo.Disposition, rabbitTwo.IsThirsty, rabbitTwo.IsHungry, rabbitTwo.IsSick, rabbitTwo.IsDirty);
                    Console.WriteLine();
                    Console.WriteLine("{0}    {1}  {2}      {3}     {4}   {5}  {6}", rabbitThree.Name, rabbitThree.RabbitBreed, rabbitThree.Disposition, rabbitThree.IsThirsty, rabbitThree.IsHungry, rabbitThree.IsSick, rabbitThree.IsDirty);
                    Console.WriteLine();
                    Console.WriteLine("{0}      {1}       {2}      {3}     {4}   {5}  {6}", rabbitFour.Name, rabbitFour.RabbitBreed, rabbitFour.Disposition, rabbitFour.IsThirsty, rabbitFour.IsHungry, rabbitFour.IsSick, rabbitFour.IsDirty);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Volunteer menu:");
                    Console.WriteLine("To clock in, press 1.");
                    Console.WriteLine("To feed the pets, press 2.");
                    Console.WriteLine("To refill the pets' water bottles, press 3.");
                    Console.WriteLine("To clean the pets' cages, press 4.");
                    Console.WriteLine("To take the pets to the vet, press 5.");
                    Console.WriteLine("To exit and return to the main menu, press 6.");
                    userChoice = int.Parse(Console.ReadLine());
                    switch (userChoice)
                    {
                        case 1:
                            Console.WriteLine(volunteer.ClockIn());
                            break;
                        case 2:
                            rabbitOne.HungerStatus();
                            rabbitTwo.HungerStatus();
                            rabbitThree.HungerStatus();
                            rabbitFour.HungerStatus();
                            Console.WriteLine(volunteer.FeedPets());
                            break;
                        case 3:
                            rabbitOne.ThirstStatus();
                            rabbitTwo.ThirstStatus();
                            rabbitThree.ThirstStatus();
                            rabbitFour.ThirstStatus();
                            Console.WriteLine(volunteer.WaterPets());
                            break;
                        case 4:
                            break;
                    }

                } while (userChoice !=6);
            }
        }
    }

}
