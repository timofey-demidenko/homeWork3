using System;
using System.Text;
using static System.Console;

namespace homeWork3
{
    internal class Program
    {

        static void Cube(int height, int width, string symb)
        {
            char[,] arr = new char[width, height];
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                    arr[i, j] = symb[0];

            WriteLine("Massive :");
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                    Write(arr[i, j]);
                WriteLine();
            }
            WriteLine();

        }

        static bool Palindrom(string Array)
        {
            string reversedString = String.Empty;
            for (int i = Array.Length - 1; i > -1; i--)
                reversedString += Array[i];

            if (reversedString == Array)
                return true;
            else
                return false;
        }

        static void Filter(int[] array, int item)
        {
            array = array.Where(e => e != item).ToArray();
            Console.WriteLine(String.Join(",", array));
        }

        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////#1

            /* string symb = ReadLine();
            int width = int.Parse(ReadLine());
            int height = int.Parse(ReadLine());
            Cube(height, width, symb); */

            /////////////////////////////////////////////////////#2

            /* string Array = ReadLine();
            Palindrom(Array); */

            ////////////////////////////////////////////////////#3

            /* int[] array = { 1, 2, 3, 4, 5, 4, 6 };
            int item = 4;
            Filter(array, item); */
        }

    }
    internal class Website
    {
        private string name = "";
        private string url = "";
        private string description = "";
        private string ip = "";

        Website(string name, string url, string description, string ip)
        {
            this.name = name;
            this.url = url;
            this.description = description;
            this.ip = ip;
        }
        public string Name { get { return name; } } 
        public string Url { get { return url; } }   
        public string Description { get { return description; } }
        public string Ip { get { return ip; } }
    }
    internal class Shop
    {
        private string name = "";
        private string firstYear = "";
        private string description = "";
        private string phoneNumber = "";
        private string email = "";

        Shop(string name, string firstYear, string description, string phoneNumber, string email)
        {
            this.name = name;
            this.firstYear = firstYear;
            this.description = description;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }
        private string Name { get { return name; } }
        private string FirstYear { get { return firstYear; } }
        private string Description { get { return description; } }
        private string PhoneNumber { get { return phoneNumber; } }
        private string Email { get { return email; } }
    }
}