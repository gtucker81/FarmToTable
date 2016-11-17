using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_GarrettTucker
{

    /*********StateRecord**************
    *   Class
    *   - Stores Data for each state
    *   Methods:
    *       StateRecord - default constructor
    *       StateRecord - overloaded constructor
    *       ToString - overloaded ToString
    *   Properties:
    *       StateName
    *       StateAbbr
    *********************************/
    public class StateRecord
    {
        /*********FarmRecord - Default**************
        *   Method
        *   - Default Constructor
        *********************************/
        public StateRecord()
            : this(string.Empty, string.Empty)
        { } //end default constructor


        /*********FarmRecord - Overloaded**************
        *   Method
        *   - Overloaded constructor sets properties to parameter values
        *********************************/
        public StateRecord(string name, string abbreviation)
        {
            StateName = name;
            StateAbbr = abbreviation;
        } //end overloaded constructor


        /*********ToString**************
        *   Method
        *   - Overloads the to string method
        *********************************/
        public override string ToString()
        {
            return string.Format("{0} - {1}",
                StateName, StateAbbr);
        } //end ToString


        /*********StateName**************
        *   Property - AutoImplemented
        *   - Get and Set the state name
        *********************************/
        public string StateName { get; private set; }


        /*********StateAbbr**************
        *   Property - AutoImplemented
        *   - Get and Set the state abbreviation
        *********************************/
        public string StateAbbr { get; private set; }

    }
}
