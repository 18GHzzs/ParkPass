using System;
using System.Linq;
using System.Xml.Linq;

namespace ParkPass.DataStructures
{
    /// <summary>
    /// The ListHandler class is responsible for managing student and faculty data.
    /// </summary>
    internal class ListHandler
    {
        private StudentData? students = new StudentData();
        private FacultyData? faculty = new FacultyData();
        private BaseList? placeHolder;

        public string checker(string type, bool special = false)
        {
            string input;
            if (!special)
            {
                Console.Write($"Enter the {type}: ");
                do
                {
                    input = Console.ReadLine();
                    if (input.IsWhiteSpace() || input.Any(char.IsDigit))
                    {
                        Console.Write("Input cannot be empty or contain digits. Please try again: ");
                    }
                }
                while (input.IsWhiteSpace() || input.Any(char.IsDigit));
                return input;
            }
            else
            {
                Console.Write($"Enter the {type}: ");
                do
                {
                    input = Console.ReadLine();
                    if (input.IsWhiteSpace())
                    {
                        Console.Write("Input cannot be empty. Please try again: ");
                    }
                    if (input.Length > 7 && input.Length < 8)
                    {
                        Console.Write("Input must be exactly 7 characters long. Please try again: ");
                    }
                }
                while (input.IsWhiteSpace() || (input.Length > 7 && input.Length < 8));
                return input;
            }
        }

        public void StudentHandler()
        {
            int choice;
            string name;
            string course;
            string vehiclePlate;
            Console.WriteLine("--==={ Student List Handler }===--");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Remove Student");
            Console.WriteLine("3. Search Student");
            Console.WriteLine("4. Exit");
            Console.Write("\n\nPlease select an option (1-4): ");

            do
            {
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

                switch (choice)
                {
                    case 1:
                        name = checker("student\'s name");
                        course = checker("student\'s course");
                        vehiclePlate = checker("student\'s vehicle plate", true);

                        students.addNode(name, course, vehiclePlate);

                        break;
                    case 2:
                        name = checker("student\'s name");
                        course = checker("student\'s course");
                        vehiclePlate = checker("student\'s vehicle plate", true);

                        students.removeNode(name, course, vehiclePlate);

                        break;
                    case 3:
                        name = checker("student\'s name");
                        course = checker("student\'s course");
                        vehiclePlate = checker("student\'s vehicle plate", true);

                        placeHolder = students.searchNode(name, course, vehiclePlate);

                        if (placeHolder != null)
                        {
                            Console.WriteLine($"Student found: Name: {placeHolder.name}, Course: {placeHolder.course}, Vehicle Plate: {placeHolder.vehiclePlate}");
                        }
                        else
                        {
                            Console.WriteLine("Student not found.");
                        }

                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
            while (choice != 4);

        }

        public void FacultyHandler()
        {
            int choice;
            string name;
            string course;
            string vehiclePlate;
            Console.WriteLine("--==={ Faculty List Handler }===--");
            Console.WriteLine("1. Add Faculty");
            Console.WriteLine("2. Remove Faculty");
            Console.WriteLine("3. Search Faculty");
            Console.WriteLine("4. Exit");
            Console.Write("\n\nPlease select an option (1-4): ");

            do
            {
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

                switch (choice)
                {
                    case 1:
                        name = checker("Faculty Member\'s name");
                        course = checker("Faculty Member\'s course");
                        vehiclePlate = checker("Faculty Member\'s vehicle plate", true);

                        faculty.addNode(name, course, vehiclePlate);

                        break;
                    case 2:
                        name = checker("Faculty Member\'s name");
                        course = checker("Faculty Member\'s course");
                        vehiclePlate = checker("Faculty Member\'s vehicle plate", true);

                        faculty.removeNode(name, course, vehiclePlate);

                        break;
                    case 3:
                        name = checker("Faculty Member\'s name");
                        course = checker("Faculty Member\'s course");
                        vehiclePlate = checker("Faculty Member\'s vehicle plate", true);

                        placeHolder = faculty.searchNode(name, course, vehiclePlate);

                        if (placeHolder != null)
                        {
                            Console.WriteLine($"Faculty member found: Name: {placeHolder.name}, Course: {placeHolder.course}, Vehicle Plate: {placeHolder.vehiclePlate}");
                        }
                        else
                        {
                            Console.WriteLine("Faculty member not found.");
                        }

                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
            while (choice != 4);
        }
    }
}
