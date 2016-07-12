using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConPro1
{
    class Program
    {
        static void Main(string[] args)
        {
            string admin_username = "Johnathan Craig";
            string admin_password = "021295";
            string admin_log = "";
            string admin_age = "21";
            string admin_phonenumber = "2703141732";
            string admin_email = "johnathancraig1719@yahoo.com";
            string user_input = "";
            string user_name = "";
            string user_age = "";
            string user_phonenumber = "";
            Console.WriteLine("Input Admin username");
            user_input = Console.ReadLine();
            Console.WriteLine("Input Admin password");
            admin_log = Console.ReadLine();
            if (user_input == admin_username && admin_log == admin_password)
            {






                Console.WriteLine("Tell me your name.");
                user_name = Console.ReadLine();

                Console.WriteLine("Hello, " + user_name + " Tell me your age, ");
                user_age = Console.ReadLine();

                Console.WriteLine("Tell me your phone number " + user_name);
                user_phonenumber = Console.ReadLine();

                Console.WriteLine("So your name is " + user_name + " you are " + user_age + " years old " + " and your phone number is " + user_phonenumber);


                Console.ReadLine();
            }
            else {
            Console.ReadLine();
            }
        }
    }
}