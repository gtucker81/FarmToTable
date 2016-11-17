using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_GarrettTucker
{

    /*********States**************
    *   Class
    *   - Stores a list of states and abreviations
    *   
    *********************************/
    public class States
    {
        //Populate the List
        List<string> states = new List<string>();
        states.Add(Alabama, AL);
            Alaska, Arizona,
                                    Arkansas, California, Colorado, Connecticut, 
                                    Delaware, Florida, Georgia, Hawaii, Idaho, 
                                    Illinois, Indiana, Iowa, Kansas Kentucky
Louisiana
Maine
Maryland
Massachusetts
Michigan
Minnesota
Mississippi
Missouri
Montana
Nebraska
Nevada
New Hampshire
New Jersey
New Mexico
New York
North Carolina, North Dakota, Ohio, Oklahoma, Oregon, Pennsylvania, Rhode Island, South Carolina,
South Dakota, Tennessee, Texas, Utah, Vermont, Virginia, Washington, West Virginia, Wisconsin, Wyoming,
District of Columbia, Puerto Rico, Guam, American Samoa, U.S.Virgin Islands, Northern Mariana Islands);

        /*********AddFarm**************
        *   Method
        *   - Adds a new farm record to the list of farms.
        *********************************/
        public void AddFarm(string farmName, string farmAddress,
                            string farmCity, string farmState, int farmZip)
        {
            FarmRecord record = new FarmRecord(farmName, farmAddress,
                farmCity, farmState, farmZip);
            farms.Add(record);
        } //end AddFarm

        /*********RemoveFarm**************
        *   Method
        *   - Removes a farm record from the list of farms.
        *********************************/
        public void RemoveFarm(int FarmID)
        {
            //To Be Defined
        } //end RemoveFarm


        /*********UpdateFarm**************
        *   Method
        *   - Modifies an existing record at index
        *********************************/
        public void UpdateFarm(int index)
        {
            bool valid = false;
            int selection;
            //Loop unil selection is valid
            do
            {
                Console.WriteLine("Select the item you would like to edit:");
                Console.WriteLine("0) Farm Name");
                Console.WriteLine("1) Farm Address");
                selection = Convert.ToInt32(Console.ReadLine());
                if (selection < 0 || selection > 1)
                    Console.WriteLine("Invalid Input: Enter an integer between 0 and 5.\n");
                else
                    valid = true;

            } while (!valid);

            if (selection == 0)
            {
                Console.WriteLine("Enter the new farm name: ");
                farms[index].FarmName = Console.ReadLine();
            }
            else if (selection == 1)
            {
                Console.WriteLine("Enter the new farm address information: ");
                Console.WriteLine("Enter Street Address: ");
                farms[index].StreetAddress = Console.ReadLine();
                Console.WriteLine("Enter City: ");
                farms[index].City = Console.ReadLine();
                Console.WriteLine("Enter State: ");
                farms[index].State = Console.ReadLine();
                Console.WriteLine("Enter Zip Code: ");
                farms[index].ZipCode = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Something went terribly wrong!\nYou shouldn't be here!");
            }

            Console.WriteLine("This is the updated farm information:");
            Console.WriteLine(farms[index]);
        }


        /*********DisplayStateCount**************
        *   Method
        *   - Outputs the count of states in the list
        *********************************/
        public void DisplayFarmCount()
        {
            Console.WriteLine("\nThere are {0} states on record.\n", states.Count());
        } //end DisplayFarmCount


        /*********DisplayFarms**************
        *   Method
        *   - Outputs the list of states
        *********************************/
        public void DisplayStates()
        {
            foreach (var state in states)
            {
                Console.WriteLine("{0}\n", state);
            }
        } //end DisplayStates

    }
}
