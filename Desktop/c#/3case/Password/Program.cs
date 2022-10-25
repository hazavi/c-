using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Password
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opret[1], Login[2]");

            Console.Write("Vælg: ");
            string valg = Console.ReadLine();
            if (valg == "1")

            {
                WriteToFile();
            } 
            else if (valg == "2")
            {
                Login();
            }
            
        }

        /// Skriver til tekstfilen
         public static void WriteToFile()
        {
             Console.Clear();

            string brugernavn;
            string password;
            
            //! # $ % & ' ( ) * + , - . / : ; < = > ? @ [ ^ _  { | } ~
            string[] specialtegn = { "!", "#", "$", "%", "&", "'","(",")", "*", "+", ",", "-", ".", "/", ":", ";", "<", "=", ">", "?", "@", "[","^", "_", "{", "|", "}", "~"};

            do { 

            Console.Write("Indtast Brugernavn: ");
            brugernavn = Console.ReadLine();
            
            Console.Write("Indtast Password: ");
            password = Console.ReadLine();
           
                string infos = brugernavn + " " + password;
                string filePath = @"C:\Users\hazavi\Desktop\c#\3case\LoginInfos.txt";

                char PassFirst = password[0];
                char PassLast = password[password.Length - 1];

                if (password.Length >= 12 && specialtegn.Any(password.Contains) == true && Char.IsDigit(PassFirst) == false && Char.IsDigit(PassLast) == false && brugernavn.ToLower() != password.ToLower())
                {

                    using (StreamWriter file = new StreamWriter(filePath, true))

                    {
                        file.WriteLine(infos);
                    }

                    Console.Write("Godkent password!");
                    break;

                }
                else 

                {

                    Console.Clear();
                    Console.WriteLine("Password IKKE GODKENDT!");
                    Console.WriteLine(" ");

                    Console.WriteLine("Brugernavn og Password må ikke være det samme");

                    Console.WriteLine("Password må ikke indeholde: 'Mellemrum' og 'Nummer' på den første og sidste plads");

                    Console.WriteLine("Password 'skal' indeholde en eller flere specialtegn som fx: ! # $ % & ' ( ) * + , - . / : ; < = > ? @ [ ^ _  { | } ~ ");

                    Console.WriteLine("Password skal være Minimum 12 tegn");
                    Console.WriteLine("Prøv igen!");
                    Console.WriteLine(" ");


               


                }

            }

            while (true);
     

           Console.ReadKey();

        }
        static void Login()
        {
            Console.Clear();
            Console.WriteLine("LOGIN");

            Console.Write("Brugernavn: ");
            string brugernvn = Console.ReadLine();  

            Console.Write("Password: ");
            string passwrd = Console.ReadLine();   

            string checklogin = brugernvn + " " + passwrd;

            string path = @"C:\Users\hazavi\Desktop\c#\3case\LoginInfos.txt";

            string[] lines = File.ReadAllLines(path);

            

            if (lines.Contains(checklogin))
            {
              
                Console.Clear();
                Console.WriteLine("Login Succes!");
                Console.Write("Ændre Password? [1]Ja, [2]No: ");
                string valg = Console.ReadLine();  

                if (valg == "1" )
                {
                    Console.Write("Indtast en ny password: ");
                    string newpass = Console.ReadLine();

                    string modifytext = File.ReadAllText(@"C:\Users\hazavi\Desktop\c#\3case\LoginInfos.txt");
                    modifytext = modifytext.Replace(passwrd, newpass);
                    File.WriteAllText(@"C:\Users\hazavi\Desktop\c#\3case\LoginInfos.txt", modifytext);

                    Console.WriteLine("Password er Ændret!");
                }
                else if (valg == "2" )
                {
                    Console.WriteLine(":)");
                }
            }

            else
            {
                Console.WriteLine("Brugernavn eller Password er forkert! Prøv igen.");
            }
            

            Console.ReadKey();
        }

        

    }
}
