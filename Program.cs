﻿using System;

namespace _17_3_2020
{
             
    class Program
        {
            static void Main(string[] args)
            {
                Interior[] interior = new Interior[3];
                interior[0] = new Menashe("Menashe", "Zagri", 740438764, "04-03-1982");
                interior[1] = new Lidor("Lidor", "Ben-Simon", 123456789, "02/01/1995");
                interior[2] = new Dana("Dana", "Sadeh", 012345, "14/12/1989");

                for (int i = 0; i < interior.Length; i++)
                {
                    interior[i].ShowDetails();

                }
            Console.ReadKey();
            }
        }

         public class Interior
        {
            private string _firstName;
            private string _lastName;
            private int _id;
            private string _birthDate;
            private static string _nationality;

            public Interior(string FirstName, string LastName, int id, string BirthDate)
            {
                _firstName = FirstName;
                _lastName = LastName;
                _id = id;
                _birthDate = BirthDate;
                _nationality = "Israeli";
            }

            public void CheckId()
            {
                string idLength = _id.ToString();

                if (idLength.Length < 9 || idLength.Length > 9)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" is an Invalid ID");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" is a valid ID");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }

            public void ShowDetails()
            {
                Console.WriteLine($"\tFirst name: {_firstName}");
                Console.WriteLine($"\tLast name: {_lastName}");
                Console.Write($"\tID: {_id}");
                CheckId();
                Console.WriteLine($"\tBirth Date: {_birthDate}");
                Console.WriteLine($"\tNationality: {_nationality}");
                Console.WriteLine();
            }

        }

        public class Menashe : Interior
        {
            public Menashe(string FirstName, string LastName, int id, string BirthDate)
                : base(FirstName, LastName, id, BirthDate)
            {
            }

        }

        public class Lidor : Interior
        {
            public Lidor(string FirstName, string LastName, int id, string BirthDate)

                : base(FirstName, LastName, id, BirthDate)
            {
            }

        }

        public class Dana : Interior
        {
            public Dana(string FirstName, string LastName, int id, string BirthDate)
                : base(FirstName, LastName, id, BirthDate)
            {
            }
        }
    }
