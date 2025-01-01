using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP02
{
    #region Q01 : Create an Enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this Enum.

    enum WeekDays : byte
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    #endregion

    #region Q03 : Create an Enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members. 
    //Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season.
    //Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

    enum SeasOn : byte
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    #endregion

    #region Q04 : Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum  
    //Create Variable from previous Enum to Add and Remove Permission from variable,
    //check if specific Permission existed inside variable

    [Flags]
    enum Permissions : byte
    {
        Delete = 1,
        Execute = 2,
        Read = 4,
        Write = 8
    }


    #endregion

    #region Q05 : Create an Enum called "Colors" with the basic colors (Red, Green, Blue) as its members. 
    //Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

    enum Colors : byte
    {
        Red,
        Green,
        Blue

    }

    #endregion


}
