namespace Assignment_OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part 01 Enum and Structg


            #region Q01 : Create an Enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this Enum.

            //Console.WriteLine(" The Week Days : ");

            //for (int i = 0; i < 7; i++)
            //{
            //    WeekDays WeekDays = (WeekDays)i;
            //    Console.WriteLine(WeekDays);
            //}

            #endregion

            #region Q02 : Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
            //Console.WriteLine(" Please Enter the names : ");
            //Console.Write(" First person name : ");
            //string? Name01 = Console.ReadLine();
            //Console.Write(" Age of the first person : ");
            //int.TryParse(Console.ReadLine(), out int Age01);
            //Console.Write(" Second person name : ");
            //string? Name02 = Console.ReadLine();
            //Console.Write(" Age of the second person : ");
            //int.TryParse(Console.ReadLine(), out int Age02);
            //Console.Write(" Third person name : ");
            //string? Name03 = Console.ReadLine();
            //Console.Write(" Age of the third person : ");
            //int.TryParse(Console.ReadLine(), out int Age03);


            //Person[] persons = new Person[3];
            //persons[0] = new Person(Name01, Age01);
            //persons[1] = new Person(Name02, Age02);
            //persons[2] = new Person(Name03, Age03);

            //Console.Clear();
            //Console.WriteLine(" Details of all persons : ");
            //foreach (Person person in persons)
            //{
            //    Console.WriteLine(person);
            //}




            #endregion

            #region Q03 : Create an Enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members. 
            ////Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season.
            ////Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //bool flag;
            //SeasOn season;
            //do
            //{
            //    Console.Write(" Please Enter a Season Name :  ");
            //    flag = Enum.TryParse<SeasOn>(Console.ReadLine(), true, out season);

            //} while (!flag);

            //if (season == SeasOn.Spring)
            //    Console.WriteLine("   spring from march to may ");
            //else if (season == SeasOn.Summer)
            //    Console.WriteLine("summer from  june to august");
            //else if (season == SeasOn.Autumn)
            //    Console.WriteLine("autumn from September to November");
            //else
            //    Console.WriteLine(" winter from December to February");


            #endregion

            #region Q04 : Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum  
            ////Create Variable from previous Enum to Add and Remove Permission from variable,
            ////check if specific Permission existed inside variable

            //Permissions permission;
            //Permissions permissionDefault = Permissions.Read;
            //bool IsParsed;
            //do
            //{
            //    Console.Write("Please Enter A Permission : ");
            //    IsParsed = Enum.TryParse<Permissions>(Console.ReadLine(), true, out permission);
            //} while (!IsParsed);

            //bool HasPermission = permissionDefault.HasFlag(permission);
            //if (HasPermission)
            //    Console.WriteLine($" User Has {permission} Permissions ");
            //else
            //{
            //    permissionDefault ^= permission;
            //    Console.WriteLine($" Update permissions : {permissionDefault}");
            //}



            #endregion

            #region Q05: Create an Enum called "Colors" with the basic colors (Red, Green, Blue) as its members. 
            ////Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

            //Console.Write(" please enter a Color : ");
            //string? color = Console.ReadLine();

            //bool IsParsed = Enum.TryParse<Colors>(color, true, out Colors Result);
            //if (IsParsed)
            //    Console.WriteLine($" {Result} is one of the primary colors");
            //else
            //    Console.WriteLine($"{color} is not a primary colors   ");

            #endregion

            #region Q06: Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            //Console.WriteLine(" Please enter the first point : ");
            //Console.Write(" X1 : ");
            //int.TryParse(Console.ReadLine(), out int X1);
            //Console.Write(" Y1 : ");
            //int.TryParse(Console.ReadLine(), out int Y1);

            //Console.WriteLine(" Please enter the Second point : ");
            //Console.Write(" X2 : ");
            //int.TryParse(Console.ReadLine(), out int X2);
            //Console.Write(" Y2 : ");
            //int.TryParse(Console.ReadLine(), out int Y2);

            //Console.Clear();

            //Point p1 = new Point(X1, Y1);
            //Point p2 = new Point(X2, Y2);
            //double Distance = CalculatesDistance(p1, p2);
            //Console.WriteLine($" the distance between the first point to the second point : {Distance}");

            #endregion

            #region Q07 : Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

            // Console.WriteLine(" Please Enter the names : ");
            // Console.Write(" First person name : ");
            // string? Name01 = Console.ReadLine();
            // Console.Write(" Age of the first person : ");
            // int.TryParse(Console.ReadLine(), out int Age01);
            // Console.Write(" Second person name : ");
            // string? Name02 = Console.ReadLine();
            // Console.Write(" Age of the second person : ");
            // int.TryParse(Console.ReadLine(), out int Age02);
            // Console.Write(" Third person name : ");
            // string? Name03 = Console.ReadLine();
            // Console.Write(" Age of the third person : ");
            // int.TryParse(Console.ReadLine(), out int Age03);

            // Console.Clear();

            //Person per1 = new Person( Name01 , Age01);
            //Person per2= new Person( Name02 , Age02 );
            //Person per3 = new Person( Name03 , Age03 );

            // if (Age01 > Age02 && Age01 > Age03)     
            //     Console.WriteLine(per1);           
            // else if (Age02 > Age03)
            //     Console.WriteLine(per2);
            // else
            //     Console.WriteLine(per3);




            #endregion


            #endregion


            #region Part 02 :Encapsulation
            //Console.WriteLine(" Please enter Employee data");

            //Employees[] EmpArr = new Employees[3];
            //for (int i = 0; i < EmpArr.Length; i++)
            //{
            //    EmpArr[i] = new Employees();
            //    Console.WriteLine($" Employee 0{i + 1} : ");
            //    Console.Write(" Id : ");
            //    EmpArr[i].Id = int.Parse(Console.ReadLine());
            //    Console.Write(" Name : ");
            //    EmpArr[i].Name = Console.ReadLine();
            //    Console.Write(" Security Level : ");
            //    Enum.TryParse<SecurityLevel>(Console.ReadLine(), true, out SecurityLevel Result);
            //    EmpArr[i].SecurityLevel = Result;
            //    Console.Write(" Salary : ");
            //    EmpArr[i].Salary = decimal.Parse(Console.ReadLine());
            //    Console.WriteLine(" Hiring date : ");
            //    Console.Write(" Day: ");
            //    int Day = int.Parse(Console.ReadLine());
            //    Console.Write(" Month: ");
            //    int Month = int.Parse(Console.ReadLine());
            //    Console.Write(" Year: ");
            //    int Year = int.Parse(Console.ReadLine());
            //    HiringDate HireDate = new HiringDate(Day, Month, Year);
            //    EmpArr[i].Hiredate = HireDate;
            //    Console.Write(" Gender : ");
            //    Enum.TryParse<Gender>(Console.ReadLine(), true, out Gender gender);
            //    EmpArr[i].gender = gender;
            //}

            //Console.Clear();

            //for (int i = 0; i < EmpArr.Length; i++)
            //{
            //    Console.WriteLine($" Employee  Data {i + 1} : ");
            //    Console.WriteLine(EmpArr[i]);
            //    Console.WriteLine();
            //}

            #endregion



        }




        // Function to calculate the distance between two points 
        static double CalculatesDistance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }


    }
}
