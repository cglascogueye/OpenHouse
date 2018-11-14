using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OpenHouse
{
    class House
    {

        public List<House> NameOfHouse { get; set; }

        public string BedType { get; set; }
        public string TypeofToilet { get; set; }
        public decimal SquareFootage { get; set; }
        public double PriceofHouse { get; set; }

        public int NumberOfWindows { get; set; }
        public string DescriptionOfRoom { get; set; }

        // https://www.tumbleweedhouses.com/category/tiny-house-lifestyle/
        //Room = new List<Room>(){"Living Room", "Dining Room", "Master Bedroom", " Kitchen"}

        public void HouseFeatures()
      {
            
                Console.WriteLine("Ok, let's look at some of the features for our tiny home:");
                Console.WriteLine("Select  Cost:  (C)");
                Console.WriteLine("Square Footage: (S)");
                Console.WriteLine("BedType:        (B)");
                Console.WriteLine("ToiletType:     (T)");
                string houseFeatures = Console.ReadLine();
      } 
    }

    //class Pyramid
    //{
    //    private static void Main(string[] args)
    //    {
    //        int numberoflayer = 6, Space, Number;
    //        Console.WriteLine("Print pyramid");
    //        for (int i = 1; i <= numberoflayer; i++) // Total number of layer for pyramid  
    //        {
    //            for (Space = 1; Space <= (numberoflayer - i); Space++) // Loop For Space  
    //                Console.Write(" ");
    //            for (Number = 1; Number <= i; Number++) //increase the value  
    //                Console.Write(Number);
    //            for (Number = (i - 1); Number >= 1; Number--) //decrease the value  
    //                Console.Write(Number);
    //            Console.WriteLine();
    //            Console.ReadLine();
    //        }
    //    }
    //}

}
