using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P4_GarrettTucker
{

    /*********FarmCollection**************
    *   Class
    *   - Collection class that stores an array of FarmRecords
    *   Methods:
    *       ClearAndLoad
    *       AddFarm
    *       RemoveFarm
    *       UpdateFarm
    *       SearchForFarmByLocation
    *       SearchForFarmByProduct
    *       DisplayFarms
    *       DisplayFarmCount
    *********************************/
    public class FarmCollection
    {
        List<FarmRecord> farms = new List<FarmRecord>();


        /*********ClearAndLoad**************
        *   Method
        *   - Clears stored data and loads data from a file
        *********************************/
        public void ClearAndLoad()
        {
            //clears the list
            if (farms != null)
            {
                farms.RemoveRange(0, farms.Count);
            }

            try
            {
                Console.WriteLine("Accessing file:\n");
                var lines = File.ReadAllText(@"./National_On-Farm_Directory_Rev.csv"); //reads data from a file
                if (lines != null)
                {
                    var rows = lines.Split('\n'); //splits document at newline
                    string[] inputFields;

                    foreach (var row in rows)
                    {
                        if (row != "")
                        {
                            inputFields = row.Split(',');
                            FarmRecord record = new FarmRecord(
                                inputFields[5], inputFields[1],
                                inputFields[2], inputFields[3],
                                Convert.ToInt32(inputFields[4]));
                            farms.Add(record);
                        }
                    }
                    farms.RemoveAt(0); //Removes file headers from the list
                }
                else
                {
                    Console.WriteLine("File is Empty");
                }

            }
            catch (IOException)
            {
                Console.Error.WriteLine("Cannot Read File");
            } //end Catch
        } //end ClearAndLoad


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


        /*********SearchForFarmByLocation**************
        *   Method
        *   - Searches for farms
        *   - User can enter any combination of street, city, state, or zip
        *********************************/
        public void SearchForFarmByLocation(string input)
        {
            var filterByState =
                from farm in farms
                where farm.State == input
                orderby farm.FarmName ascending
                select farm;

            foreach (var i in filterByState)
            {
                Console.WriteLine(i);
            }
        } //end SearchForFarmByLocation


        /*********DisplayFarmCount**************
        *   Method
        *   - Outputs the count of farms in the list
        *********************************/
        public void DisplayFarmCount()
        {
            Console.WriteLine("\nThere are {0} farms on record.\n", farms.Count());
        } //end DisplayFarmCount


        /*********DisplayFarms**************
        *   Method
        *   - Outputs the list of farms
        *********************************/
        public void DisplayFarms()
        {
            foreach (var farm in farms)
            {
                Console.WriteLine(farm);
            }
        } //end DisplayFarms


        public int BinarySearch(string fName)
        {
            for (int i = 0; i < farms.Count(); i++)
            {
                if (farms[i].FarmName == fName)
                    return i;
            }
            return -1;
        }
    }
}
