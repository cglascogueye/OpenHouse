using System;
using System.Collections.Generic;
using System.Linq;


namespace OpenHouse
{
    class Program
          
    {
        public int NumberOfRooms = 12;
        public static List<Room> House = new List<Room>();
    
        static void Main(string[] args)
        {
            Room bedroom = new Room();
            bedroom.Name = "Bedroom";
            House.Add(bedroom);
            bedroom.DescriptionOfRoom.Add("");

            "______________\n"+
           "|              |\n"

//Introduction
            Console.WriteLine("Welcome to our Open House!");

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine($"Hello, {firstName}, it's very nice to meet you.");
            Console.ReadLine();

            //Begin Tour with which room to visit.

            Console.WriteLine("Would you like to start our tour in the  Bedroom (Enter B), Living Room (Enter L), or the Kitchen (Enter K) ");
            string roomOption = Console.ReadLine();

            if (roomOption.ToLower() == "b")


            {
                Console.WriteLine("Ok, let's head to the bedroom.");
                Console.ReadLine();

                Console.WriteLine("As you can see this is a very spacious room. ");
                Console.WriteLine("This area here can be used as a vanity area or a small office area. ");
                Console.WriteLine("The walk-in closet is on the other side of the bathroom.");
                Console.ReadLine();
            }
           
            else if (roomOption.ToLower() == "l")
            {
                Console.WriteLine("You're going to love the living room. There's lots of light.");
                Console.ReadLine();
                Console.WriteLine("What's a bold color you would like to incorporate into your living room color scheme?");
            }

            else if (roomOption.ToLower() == "k")

            {
                Console.WriteLine("   .");
                Console.WriteLine("    .");
                
            }

            Console.ReadLine();
            }

            }
            
        }
    

