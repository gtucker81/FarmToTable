using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P4_GarrettTucker
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection;
            FarmCollection farmCollect = new FarmCollection();

            //Loops until Exit (selecion #5)
            do
            {
                bool valid = false;
                //Loops until valid input is received
                do
                {
                    //Display Menu
                    Console.WriteLine("Select an option below:");
                    Console.WriteLine("0) Clear and Load");
                    Console.WriteLine("1) Add Item");
                    Console.WriteLine("2) Modify Item");
                    Console.WriteLine("3) Search");
                    Console.WriteLine("4) Display Item Count");
                    Console.WriteLine("5) Exit");

                    selection = Convert.ToInt32(Console.ReadLine());

                    if (selection < 0 || selection > 5)
                        Console.WriteLine("Invalid Input: Enter an integer between 0 and 5.\n");
                    else
                        valid = true;

                } while (!valid);

                //Implementation
                switch (selection)
                {
                    case 0:
                        farmCollect.ClearAndLoad();
                        farmCollect.DisplayFarms();
                        break;

                    case 1:
                        string input, fName, fAddress, fCity, fState;
                        int fZip;
                        //loops until user is happy with input
                        do
                        {
                            Console.WriteLine("Enter the farm name: ");
                            fName = Console.ReadLine();
                            Console.WriteLine("Enter the street address: ");
                            fAddress = Console.ReadLine();
                            Console.WriteLine("Enter the city: ");
                            fCity = Console.ReadLine();
                            Console.WriteLine("Enter the state: ");
                            fState = Console.ReadLine();
                            Console.WriteLine("Enter the zip: ");
                            fZip = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\n{0}\n{1}\n{2}, {3} {4}", fName, fAddress, fCity, fState, fZip);
                            Console.WriteLine("\nIs the above information correct (Y/N)?\n(If so, the farm will be added to the list)");
                            input = Console.ReadLine().ToUpper();

                            //checks for correct input
                            while (!(input.Equals("Y") || input.Equals("N")))
                            {
                                Console.WriteLine("Invalid Input: Enter Y or N");
                                input = Console.ReadLine().ToUpper();
                            }

                        } while (input != "Y");

                        //adds new item to list of farms
                        farmCollect.AddFarm(fName, fAddress, fCity, fState, fZip);
                        farmCollect.DisplayFarms();
                        break;

                    case 2:
                        farmCollect.DisplayFarms();
                        bool retry;

                        //loop while user wants to retry
                        do
                        {
                            Console.WriteLine("Enter the name of the farm that you would like to modify:");
                            var farmName = Console.ReadLine();

                            var index = farmCollect.BinarySearch(farmName);
                            if (index < 0)
                            {
                                Console.WriteLine("No such farm in list.\nWould you like to try again? (Y/N)");
                                string response = Console.ReadLine().ToUpper();
                                //checks for correct input
                                while (!(response.Equals("Y") || response.Equals("N")))
                                {
                                    Console.WriteLine("Invalid Input: Enter Y or N");
                                    response = Console.ReadLine().ToUpper();
                                }
                                if (response == "Y")
                                    retry = true;
                                else
                                    retry = false;
                            }
                            else {
                                farmCollect.UpdateFarm(index);
                                retry = false;
                            }
                        } while (retry);
                        farmCollect.DisplayFarms();
                        break;

                    case 3:
                        Console.WriteLine("Enter the State (not abbreviation): ");
                        string stateStr = Console.ReadLine();
                        farmCollect.SearchForFarmByLocation(stateStr);
                        break;

                    case 4:
                        farmCollect.DisplayFarmCount();
                        break;
                    default:
                        break;
                }

            } while (selection != 5);
        } //end Main
    }
}
