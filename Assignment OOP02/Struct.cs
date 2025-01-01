using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP02
{
    #region Q02 : Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
    //and Q07
    // Q07 : Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.


    struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string _name, int _age)
        {
            Name = _name;
            Age = _age;
        }
        public override string ToString()
        {
            return ($" Name : {Name} , Age : {Age}");
        }

    }
    #endregion

    #region Q06: Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }



        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }


    #endregion

}
