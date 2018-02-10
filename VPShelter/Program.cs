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
            Manager managerOne = new Manager("Amelia");
            Volunteer volunteer = new Volunteer();
            Volunteer volunteerOne = new Volunteer(30, "Abby");
            Volunteer volunteerTwo = new Volunteer(20, "Gregg");
            Volunteer volunteerThree = new Volunteer(15, "Will");

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
            rabbitOne.TickInitial();
            rabbitTwo.TickInitial();
            rabbitThree.TickInitial();
            rabbitFour.TickInitial();

            // user main menu (initial greeting)

            int userChoice = 0;
            do {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Title = "ASCII Art Rabbit";
                string title = @"

               (`.         ,-,        Welcome to the small pet rescue!
               `\ `.    ,;' /
                \`. \ ,'/ .'
          __     `.\ Y /.'
       .-'  ''--.._` ` (
     .'            /   `
    ,           ` '   Q '
    ,         ,   `._    \
    |         '     `-.;_'
    `  ;    `  ` --,.._;
    `    ,   )   .'
     `._ ,  '   /_
        ; ,''-,;' ``-
         ``-..__\``--` 


                ";
                Console.WriteLine(title);
                Console.WriteLine("To get started, please select what type of employee you are:");
                Console.WriteLine("If you are a manager, press 1.");
                Console.WriteLine("If you are a volunteer, press 2.");
                Console.WriteLine();
                Console.WriteLine("To exit, press 3.");
                userChoice = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (userChoice == 1)
                {
                    do
                    {
                        Console.Clear();
                        Console.Title = "ASCII Art Manager Menu";
                        title = @" 
                                   /\ /|
                                   \ V/
                                   | "")
                                   /  |
                                  /  \\    
                                *(__\_\

                            ";
                        Console.WriteLine(title);
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
                                Console.WriteLine("{0}  {1} {2}", volunteerOne.VolunteerName, volunteerOne.EmployeeID, volunteerOne.HoursAvailable);
                                Console.WriteLine("{0} {1} {2}", volunteerTwo.VolunteerName, volunteerTwo.EmployeeID, volunteerTwo.HoursAvailable);
                                Console.WriteLine("{0}  {1} {2}", volunteerThree.VolunteerName, volunteerThree.EmployeeID, volunteerThree.HoursAvailable);
                                Console.WriteLine();
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey();
                                break;
                            case 2:
                                Console.WriteLine(managerOne.ClockIn());
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey();
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
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey();
                                break;
                            case 4:
                                Console.WriteLine("Which pet is the adopter interested in?");
                                Console.WriteLine("Available pets: {0}, {1}, {2}, {3}", rabbitOne.Name, rabbitTwo.Name, rabbitThree.Name, rabbitFour.Name);
                                string adopterPet = Console.ReadLine().ToLower();
                                if (adopterPet == "nietzsche")
                                {
                                    Console.WriteLine("Nietzsche is a 8 year old male chestnut agouti Continental Giant.");
                                }
                                else if (adopterPet == "hegel")
                                {
                                    Console.WriteLine("Hegel is a 5 year old male broken chocolate Lionhead.");
                                }
                                else if (adopterPet == "simone")
                                {
                                    Console.WriteLine("Simone is a 2 year old female sable Netherland Dwarf.");
                                }
                                else
                                {
                                    Console.WriteLine("Kant is a 4 year old male black Holland Lop.");
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
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey();
                                break;
                        }
                    } while (userChoice != 5);

                }
                else
                {
                    do
                    {
                        Console.Clear();
                        rabbitOne.TickReg(rabbitOne.IsHungry, rabbitOne.IsThirsty, rabbitOne.IsDirty, rabbitOne.IsSick);
                        rabbitTwo.TickReg(rabbitTwo.IsHungry, rabbitTwo.IsThirsty, rabbitTwo.IsDirty, rabbitTwo.IsSick);
                        rabbitThree.TickReg(rabbitThree.IsHungry, rabbitThree.IsThirsty, rabbitThree.IsDirty, rabbitThree.IsSick);
                        rabbitFour.TickReg(rabbitFour.IsHungry, rabbitFour.IsThirsty, rabbitFour.IsDirty, rabbitFour.IsSick);
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
                        Console.WriteLine("To take sick pets to the vet, press 5.");
                        Console.WriteLine("To play with a pet, press 6.");
                        Console.WriteLine("To give a pet a treat, press 7.");
                        Console.WriteLine("To exit and return to the main menu, press 8.");
                        userChoice = int.Parse(Console.ReadLine());
                        switch (userChoice)
                        {
                            case 1:
                                Console.WriteLine(volunteer.ClockIn());
                                Console.WriteLine("Press a key to continue.");
                                Console.ReadKey();
                                break;
                            case 2:
                                rabbitOne.HungerStatus();
                                rabbitTwo.HungerStatus();
                                rabbitThree.HungerStatus();
                                rabbitFour.HungerStatus();
                                Console.WriteLine(volunteer.FeedPets());
                                Console.WriteLine("Press a key to continue.");
                                Console.ReadKey();
                                break;
                            case 3:
                                rabbitOne.ThirstStatus();
                                rabbitTwo.ThirstStatus();
                                rabbitThree.ThirstStatus();
                                rabbitFour.ThirstStatus();
                                Console.WriteLine(volunteer.WaterPets());
                                Console.WriteLine("Press a key to continue.");
                                Console.ReadKey();
                                break;
                            case 4:
                                rabbitOne.CageStatus();
                                rabbitTwo.CageStatus();
                                rabbitThree.CageStatus();
                                rabbitFour.CageStatus();
                                Console.WriteLine(volunteer.CleanCages());
                                Console.WriteLine("Press a key to continue.");
                                Console.ReadKey();
                                break;
                            case 5:
                                rabbitOne.HealthStatus();
                                rabbitTwo.HealthStatus();
                                rabbitThree.HealthStatus();
                                rabbitFour.HealthStatus();
                                Console.WriteLine(volunteer.Vet());
                                Console.WriteLine("Press a key to continue.");
                                Console.ReadKey();
                                break;
                            case 6:
                                Console.WriteLine("Which pet would you like play with?");
                                string playPet = Console.ReadLine().ToLower();
                                if (playPet == "nietzsche")
                                {
                                    Console.WriteLine(volunteer.PlayWithPet(playPet, rabbitOne.IsHungry, rabbitOne.IsThirsty, rabbitOne.IsSick, rabbitOne.IsDirty));
                                }
                                else if (playPet == "hegel")
                                {
                                    Console.WriteLine(volunteer.PlayWithPet(playPet, rabbitTwo.IsHungry, rabbitTwo.IsThirsty, rabbitTwo.IsSick, rabbitTwo.IsDirty));
                                }
                                else if (playPet == "simone")
                                {
                                    Console.WriteLine(volunteer.PlayWithPet(playPet, rabbitThree.IsHungry, rabbitThree.IsThirsty, rabbitThree.IsSick, rabbitFour.IsDirty));
                                }
                                else if (playPet == "kant")
                                {
                                    Console.WriteLine(volunteer.PlayWithPet(playPet, rabbitFour.IsHungry, rabbitFour.IsThirsty, rabbitFour.IsSick, rabbitFour.IsDirty));
                                }
                                else
                                {
                                    Console.WriteLine("This is not a valid pet.");
                                }
                                Console.WriteLine("Press a key to continue.");
                                Console.ReadKey();
                                break;

                            case 7:
                                Console.WriteLine("To which pet would you like to offer a treat?");
                                string petName = Console.ReadLine().ToLower();
                                if (petName == "nietzsche")
                                {
                                    Console.WriteLine(rabbitOne.FeedTreat("nietzsche", rabbitOne.IsThirsty));
                                }
                                else if (petName == "hegel")
                                {
                                    Console.WriteLine(rabbitTwo.FeedTreat("hegel", rabbitTwo.IsThirsty));
                                }
                                else if (petName == "simone")
                                {
                                    Console.WriteLine(rabbitThree.FeedTreat("simone", rabbitThree.IsThirsty));
                                }
                                else if (petName == "kant")
                                {
                                    Console.WriteLine(rabbitFour.FeedTreat("kant", rabbitFour.IsThirsty));
                                }
                                else
                                {
                                    Console.WriteLine("This is not a valid pet.");
                                }
                                Console.WriteLine("Press a key to continue.");
                                Console.ReadKey();
                                break;
                        }

                    } while (userChoice != 8);
                }

            } while (userChoice !=3);
        }
    }

}
