using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jovon Sales");
            Console.WriteLine("jsales3@kent.edu");

            DateTime myValue = DateTime.Now;

            Console.WriteLine("Enter your Birthdate in mm/dd/yyyy format:");

            string userValue = Console.ReadLine();

            string subString = userValue.Substring(0, 2);
            string subString2 = userValue.Substring(3, 2);

            string subString3 = userValue.Substring(6, 4);

            int month = int.Parse(subString);
            int day = int.Parse(subString2);
            int year = int.Parse(subString3);

            while (month <= 12 && day <= 31 && year <= 2016)
            {
                DateTime myBirthday = DateTime.Parse(userValue);
                TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
                Console.WriteLine(myAge.TotalDays);
                Console.ReadLine();
                break;
            }

            Console.WriteLine("The date you entered is incorrect");
            Console.WriteLine("Please enter a correct date");
            userValue = Console.ReadLine();
        }
    }
}
