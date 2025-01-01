using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP02
{

    enum Gender : byte
    {
        M,
        F
    }

    enum SecurityLevel : byte
    {
        Guest,
        Developer,
        Secretary,
        DBA

    }

    internal class Employees
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public HiringDate Hiredate { get; set; }
        public Gender gender { get; set; }


        public override string ToString()
        {
            return ($" Id : {Id}  Name : {Name}  Gender : {gender}  Security Level : {SecurityLevel}  Salary : {Salary:C}  Hiring Date : {Hiredate}  ");
        }


    }
    internal class HiringDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public override string ToString()
        {
            return ($"{Day}/{Month}/{Year}");
        }
    }



}
