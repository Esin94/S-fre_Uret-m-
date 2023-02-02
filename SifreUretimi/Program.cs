using System;

namespace SifreUretimi
{
    
    class User
    {
        public string name;
        public string lastname;
        public int age;
        public string sifre;
        public User(string name, string lastname, int age)
        {
            this.name = name;
            this.lastname = lastname;
            this.age = age;
        }
        public void SifreUret()
        {
            string UpperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string LowerCase = "abcdefghijklmnopqrstuvwxyz";
            string Number = "0123456789";
            string Special = "~`!@#$%^&/()*-_+=[]{}|?;:,.><'";
            string total="";
            total += UpperCase;
            Console.WriteLine("Include UpperCase Characters? If type yes if not type no.");
            var includeUpperCase = Console.ReadLine();
            Console.WriteLine("Include LowerCase Characters? If type yes if not type no.");
            var includeLowerCase = Console.ReadLine();
            Console.WriteLine("Include Special Characters? If type yes if not type no.");
            var includeSpecial = Console.ReadLine();
            Console.WriteLine("Include Numbers? If type yes if not type no.");
            var includeNumber = Console.ReadLine();
            Console.WriteLine("How many Characters?");
            var length = Console.ReadLine();
            if (includeUpperCase=="yes")
            {
                total += UpperCase;
            }
            if (includeLowerCase == "yes")
            {
                total += LowerCase;
            }
            if (includeSpecial == "yes")
            {
                total += Special;
            }
            if (includeNumber == "yes")
            {
                total += Number;
            }
            var random = new Random();
            string sifre = "";
            for (int i = 0; i < int.Parse(length); i++)
            {
                sifre += total[random.Next(total.Length)];
            }
            Console.WriteLine("New Password is "+sifre);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            User user=new User("Esin","Yılmaz",28);
            user.SifreUret();

            
        }
    }
}
