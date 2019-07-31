using System;
using System.Collections.Generic;

namespace Lab9v4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //________________________________________ Students Info___________________________________________________

            Student student0 = new Student()
            {
                Name = "",
                LastName = "",
                Hometown = "",
                Food = "",
                FavoriteBand = "",
                FavoriteColor = ""
            };

            Student student1 = new Student()
            {
                Name = "Dakota",
                LastName = "Slabbekorn",
                Hometown = "Kent City",
                Food = "Pho",
                FavoriteBand = "Trap",
                FavoriteColor = "Red"

            };

            Student student2 = new Student()
            {
                Name = "Joshua",
                LastName = "Bultsma",
                Hometown = "Grand Rapids",
                Food = "Cheese Tortellini",
                FavoriteBand = "Hip Hop",
                FavoriteColor = "Pink"

            };
            Student student3 = new Student()
            {
                Name = "Tommy",
                LastName = "Waalkes",
                Hometown = "Releigh",
                Food = "Chicken Curry",
                FavoriteBand = "",
                FavoriteColor = "Not White"
            };
            Student student4 = new Student()
            {
                Name = "James",
                LastName = "Dockery",
                Hometown = "Grand Rapids",
                Food = "Cheeseburgers",
                FavoriteBand = "Rock",
                FavoriteColor = "Red"
            };
            Student student5 = new Student()
            {
                Name = "Maricela",
                LastName = "Rivera",
                Hometown = "Morelia Mexico",
                Food = "Tacos",
                FavoriteBand = "Country",
                FavoriteColor = "Blue"
            };
            Student student6 = new Student()
            {
                Name = "Kimvy",
                LastName = "Nguyen",
                Hometown = "Grand Rapids",
                Food = "Sushi",
                FavoriteBand = "Rock",
                FavoriteColor = "White"
            };
            Student student7 = new Student()
            {
                Name = "Sam",
                LastName = "Thomson",
                Hometown = "Grand Rapids",
                Food = "Tacos",
                FavoriteBand = "nickelback",
                FavoriteColor = "Black"
            };

            List<Student> students = new List<Student>(24);

            students.Add(student0);
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);
            students.Add(student5);
            students.Add(student6);
            students.Add(student7);
            Console.WriteLine("Welcom to the Grand Circus Back End developemnt After hour class of 2019");
            //________________________________________ Students Search ______________________________________________________
            bool searchMore = true;
            while (searchMore)

            {
                int sNum = 0;
                Console.WriteLine("Type a number from 1-{0} to find out about a student", students.Count - 1);
                SortByName sortByName = new SortByName();
                students.Sort(sortByName);

                for (int i = 1; i < students.Count; i++)
                {
                    Student stu = students[i];
                    Console.WriteLine(i + "-" + stu.Name);
                }
                string input1 = Console.ReadLine();

                try
                {
                    sNum = int.Parse(input1);

                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid entry. you must enter a number");
                    input1 = Console.ReadLine();
                    sNum = int.Parse(input1);
                }

                while (sNum > students.Count - 1)
                {
                    Console.WriteLine("you must enter a number btween 1 and {0} ", students.Count - 1);
                    input1 = Console.ReadLine();

                    try
                    {
                        sNum = int.Parse(input1);

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid entry. you must enter a number");
                        input1 = Console.ReadLine();
                        sNum = int.Parse(input1);
                    }
                }


                //_________________________________________Caracteristics______________________________________________________
                bool moreCaracteristics = true;
                while (moreCaracteristics)
                {
                    int input2 = 0;
                    Console.WriteLine("Student {0} is {1} {2} What would you like to know about {1}?", sNum, students[sNum].Name, students[sNum].LastName);
                    Console.WriteLine("Choises");
                    Console.WriteLine("1- Hometown");
                    Console.WriteLine("2- Favorite Food");
                    Console.WriteLine("3- Favorite Musician");
                    Console.WriteLine("4- Favorite Color");

                    string inp = Console.ReadLine();
                    try
                    {
                        input2 = int.Parse(inp);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("invalid entry. please enter an intiger");
                    }
                    while (input2 > 4)
                    {
                        Console.WriteLine("Invalid  entry. must enter a number between 1 and 4");
                        inp = Console.ReadLine();
                        try
                        {
                            input2 = int.Parse(inp);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid  entry. must enter a number between 1 and 4");
                        }
                    }
                    if (input2 == 1)
                    {
                        Console.WriteLine("{0}'s Hometown is: {1} ", students[sNum].Name, students[sNum].Hometown);
                    }
                    if (input2 == 2)
                    {
                        Console.WriteLine("{0}'s Favorite Food is: {1} ", students[sNum].Name, students[sNum].Food);
                    }
                    if (input2 == 3)
                    {
                        Console.WriteLine("{0}'s Favorite Band is: {1} ", students[sNum].Name, students[sNum].FavoriteBand);
                    }
                    if (input2 == 4)
                    {
                        Console.WriteLine("{0}'s Favorite Color is: {1} ", students[sNum].Name, students[sNum].FavoriteColor);
                    }

                    Console.WriteLine("Whould you like to know more about {0}?", students[sNum].Name);
                    string oc = Console.ReadLine().ToLower();

                    while (oc != "n" && oc != "y")

                    {
                        Console.WriteLine("Invalid entry. Enter n/y");
                        oc = Console.ReadLine().ToLower();
                    }
                    if (oc == "n")
                    { moreCaracteristics = false; }
                }

                //_________________________________________Add Student__________________________________________________________
                bool addMoreStudent = true;
                while (addMoreStudent)
                {
                    Console.WriteLine("Would you like to add a student? y/n");
                    string adding = Console.ReadLine();

                    if (adding == "y")
                    {
                        Console.WriteLine("What is the First Name of the student");
                        string nameInput = Console.ReadLine();
                        Console.WriteLine("What is the Last Name of the student");
                        string lastNameInput = Console.ReadLine();
                        Console.WriteLine("What is the Hometown of the Student");
                        string homeInput = Console.ReadLine();
                        Console.WriteLine("What is the Favorite Food of the Student");
                        string foodInput = Console.ReadLine();
                        Console.WriteLine("What is the Favorite Band  of the Student");
                        string bandInput = Console.ReadLine();
                        Console.WriteLine("What is the Favorite Color of the Student");
                        string colorInput = Console.ReadLine();

                        students.Add(new Student { Name = nameInput, Hometown = homeInput, Food = foodInput, FavoriteBand = bandInput, FavoriteColor = colorInput, LastName = lastNameInput });
                        Console.WriteLine("Do you want to add another Student?");
                        string a = Console.ReadLine().ToLower();

                        while (a != "n" && a != "y")
                        {
                            Console.WriteLine("Invalid entry. It must be n or y");
                            a = Console.ReadLine().ToLower();
                        }
                        if (a == "n")
                        {
                            addMoreStudent = false;

                        }
                    }
                    else
                    {
                        addMoreStudent = false;
                    }
                }
                Console.WriteLine("List of Students:");
                sortByName = new SortByName();
                students.Sort(sortByName);

                for (int i = 1; i < students.Count; i++)
                {
                    Student stu = students[i];
                    Console.WriteLine(i + "-" + stu.Name);
                }
                Console.WriteLine("Do you want to search info about one of this students?");
                string repeat = Console.ReadLine().ToLower();

                while (repeat != "n" && repeat != "y")
                {
                    Console.WriteLine("Invalid entry. It must be n or y");
                    repeat = Console.ReadLine().ToLower();
                }
                if (repeat == "n")
                {
                    Console.WriteLine("Good Bye");
                    searchMore = false;

                }
            }
        }

        public class SortByName : IComparer<Student>
        {
            public int Compare(Student x, Student y)
            {
                return x.Name.CompareTo(y.Name);
            }
        }
    }
}





