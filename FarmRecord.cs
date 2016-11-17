using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_GarrettTucker
{

    /*********FarmRecord**************
    *   Class
    *   - Stores Data for each farm
    *   Methods:
    *       FarmRecord - default constructor
    *       FarmRecord - overloaded constructor
    *       ToString - overloaded ToString
    *   Properties:
    *       FarmID
    *       FarmName
    *       StreetAddress
    *       City
    *       State
    *       ZipCode
    *       GPSXY
    *       FarmRating
    *********************************/
    public class FarmRecord
    {
        //****VARIABLES*****
        private int farmID, zipCode, farmRating;
        private double gpsXY;
        private string farmName, streetAddress, city, state;


        /*********FarmRecord - Default**************
        *   Method
        *   - Default Constructor
        *********************************/
        public FarmRecord()
            : this(string.Empty, string.Empty, string.Empty, string.Empty, 0)
        { } //end default constructor


        /*********FarmRecord - Overloaded**************
        *   Method
        *   - Overloaded constructor sets properties to parameter values
        *********************************/
        public FarmRecord(string FNV, string AV, string CV, string SV, int ZV)
        {
            FarmName = FNV;
            StreetAddress = AV;
            City = CV;
            State = SV;
            ZipCode = ZV;
        } //end overloaded constructor


        /*********ToString**************
        *   Method
        *   - Overloads the to string method
        *********************************/
        public override string ToString()
        {
            return string.Format("{0}\n\t{1}\n\t{2}, {3} {4}",
                FarmName, StreetAddress, City, State, ZipCode);
        } //end ToString


        /*********FarmID**************
        *   Property
        *   - Get and Set a number ID
        *********************************/
        public int FarmID
        {
            get { return farmID; }
            set
            {
                if (value < 0) farmID = -1;
                else farmID = value;
            }
        }


        /*********FarmName**************
        *   Property
        *   - Get and Set the farms name
        *********************************/
        public string FarmName
        {
            get { return farmName; }
            set { farmName = value; }
        }

        /*********StreetAddress**************
        *   Property
        *   - Get and Set the street address
        *********************************/
        public string StreetAddress
        {
            get { return streetAddress; }
            set { streetAddress = value; }
        }

        /*********City**************
        *   Property
        *   - Get and Set the city
        *********************************/
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        /*********State**************
        *   Property
        *   - Get and Set the state
        *********************************/
        public string State
        {
            get { return state; }
            set { state = value; }
        }

        /*********ZipCode**************
        *   Property
        *   - Get and Set the zip code
        *********************************/
        public int ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

        /*********GPSXY**************
        *   Property
        *   - Get and Set the gps location coordinates
        *   - X is East/West, Y is North/South
        *********************************/
        public double GPSXY
        {
            get { return gpsXY; }
            set { gpsXY = value; }
        }

        /*********FarmRating**************
        *   Property
        *   - Get and Set the farmRating
        *   - This is optional, farms start with no rating
        *     and users have the option to rate a farm
        *   - Performanc ratings range from 1 to 5
        *********************************/
        public int FarmRating
        {
            get { return farmRating; }
            set { farmRating = value; }
        }
    }
}
