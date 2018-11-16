using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace OpenHouse
{
    class Program

    {
        //https://www.youtube.com/watch?v=74KTOpJXY_o



        static void Main(string[] args)
        { 
                 
            List<TinyHome> listOfTinyHomes = new List<TinyHome>()
            {

                new TinyHome()  { HouseName = "LeafHouse", SquareFeet = 160,    Cost = 41500, Description = "http://www.tinyhousing.ca/" },
                new TinyHome()  { HouseName = "Whimsy", SquareFeet = 300 ,      Cost = 10500, Description = "https://www.windrivertinyhomes.com/the-big-whimsy" },
                new TinyHome()  { HouseName = "FarmHouse", SquareFeet = 260,    Cost = 25000, Description = "https://tinyhouselistings.com/listings/farmhouse-chic-tiny-house-in-alabama-move-in-ready"},
                new TinyHome()  { HouseName = "Cypress 26", SquareFeet = 290 ,  Cost = 99046, Description = "https://www.tumbleweedhouses.com/design-your-tumbleweed/?src=cypress-page-tab"},
                new TinyHome()  { HouseName = "Ironclad", SquareFeet = 240 ,    Cost = 69000, Description = "https://www.windrivertinyhomes.com/the-ironclad" },
                new TinyHome()  { HouseName = "Monocle", SquareFeet = 240 ,     Cost = 79900, Description = "https://www.windrivertinyhomes.com/the-monocle" },
                new TinyHome()  { HouseName = "Urban Micro", SquareFeet = 650 , Cost = 150000, Description = "https://www.windrivertinyhomes.com/store/urban-micro-home-plans" },
                new TinyHome()  { HouseName = "Bungalow", SquareFeet = 180 ,    Cost = 60000, Description = "https://www.windrivertinyhomes.com/wind-river-bungalow" },
                new TinyHome()  { HouseName = "Silhouette", SquareFeet = 221 ,  Cost = 89500, Description = "https://www.windrivertinyhomes.com/the-silouette" },
                new TinyHome()  { HouseName = "Goose", SquareFeet =  531,       Cost = 84995, Description = "https://www.treehugger.com/tiny-houses/goose-tiny-house-tiny-heirloom.html" },
                new TinyHome()  { HouseName = "CoffeeGrounds", SquareFeet = 275 , Cost = 13,  Description = "https://www.treehugger.com/tiny-houses/tiny-home-runs-on-coffee-grounds-dunkin-donuts-new-frontier-homes.html" },
                new TinyHome()  { HouseName = "Lighthouse", SquareFeet = 154 ,  Cost = 50000, Description = "https://www.treehugger.com/tiny-houses/lighthouse-office-knowhow-shop.html" },
                new TinyHome()  { HouseName = "Wanderer", SquareFeet = 174 ,    Cost = 53861 , Description = "https://www.treehugger.com/tiny-houses/wanderer-summit-tiny-homes.html" },
                new TinyHome()  { HouseName = "Buster", SquareFeet = 184 ,      Cost = 70714, Description = "https://www.treehugger.com/tiny-houses/buster-tiny-house-build-tiny-nz.html" },
                new TinyHome()  { HouseName = "Retreat", SquareFeet = 169 ,     Cost = 150000, Description = "https://www.boardandvellum.com/portfolio/backyard-reading-retreat/" },

            };
            var filteredHomes = listOfTinyHomes.Where(tinyHome => tinyHome.Cost < 50000);
            Console.WriteLine("Tiny houses are popping up around the country as more people decide to downsize their lives.\nWhile the structures often measure less than 300 square feet,\n" +
                "the tiny house movement isn't necessarily about sacrifice.\n With thoughtful, innovative designs, some homeowners have \ndiscovered a small house actually leads to a simpler" +
                " yet fuller life, \nconnecting them with family, friends, and nature while freeing them from mortgages and an urge to keep up\n with the Joneses.  ~ David Hillegas");
            Console.ReadLine();
            Console.WriteLine("Welcome to Tiny Homes!");
            Console.WriteLine("Would you like to give me your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine($"Hello, {firstName}, it's very nice to meet you.");
            Console.ReadLine();



            //Begin with search for a tiny home.
            Console.WriteLine("Folks who choose tiny homes, do so for a variety of reasons different from the day-to-day home buyer.");
            Console.WriteLine("Let's begin by grouping our homes into 3 varieties:");
            Console.WriteLine("(Enter 1)--Most Economical");
            Console.WriteLine("(Enter 2)--Most Luxurious");
            Console.WriteLine("(Enter 3) --Smallest Environmental Footprint  ");
            string houseOption = Console.ReadLine();
            //House OPtion #1 - Economical (Price Driven)
            if (houseOption == "1")
            {
                filteredHomes = listOfTinyHomes.Where(tinyHome => tinyHome.Cost < 50000);
                foreach (TinyHome tinyHome in filteredHomes)
                    Console.WriteLine(tinyHome.HouseName + ":   " + tinyHome.SquareFeet + "sqft    " + " " + "$" + tinyHome.Cost + "     " + tinyHome.Description + Console.ReadLine());

                Console.ReadLine();

            }



            if (houseOption == "2")
            {
                filteredHomes = listOfTinyHomes.Where(tinyHome => tinyHome.Cost > 85000);
                foreach (TinyHome tinyHome in filteredHomes)
                    Console.WriteLine(tinyHome.HouseName + ":   " + tinyHome.SquareFeet + "sqft    " + " " + "$" + tinyHome.Cost + "     " + tinyHome.Description + Console.ReadLine());

                Console.ReadLine();
            }


            if (houseOption == "3")
            {
                filteredHomes = listOfTinyHomes.Where(tinyHome => tinyHome.Cost < 70000 && tinyHome.SquareFeet < 300);
                foreach (TinyHome tinyHome in filteredHomes)
                    Console.WriteLine(tinyHome.HouseName + ":   " + tinyHome.SquareFeet + "sqft    " + " " + "$" + tinyHome.Cost + "     " + tinyHome.Description + Console.ReadLine());

                Console.ReadLine();
            }
            Console.WriteLine("What square footage are you looking for (between 60 - 300)?");
            int sqFt = Convert.ToInt32(Console.ReadLine());
            filteredHomes = listOfTinyHomes.Where(tinyHome => tinyHome.Cost > 10000 && tinyHome.SquareFeet > sqFt);
            foreach (TinyHome tinyHome in filteredHomes)
                Console.WriteLine(tinyHome.HouseName + ":   " + tinyHome.SquareFeet + "sqft    " + "$ " + tinyHome.Cost + "     " + tinyHome.Description + Console.ReadLine());

            Console.ReadLine();

            Console.WriteLine("What price are you looking for (between $20000 - $100000)?");
            int Cost = Convert.ToInt32(Console.ReadLine());
            filteredHomes = listOfTinyHomes.Where(tinyHome => tinyHome.Cost > Cost && tinyHome.SquareFeet > sqFt);
            foreach (TinyHome tinyHome in filteredHomes)
                Console.WriteLine(tinyHome.HouseName + ":   " + tinyHome.SquareFeet + "sqft    " + " " + "$" + tinyHome.Cost + "     " + tinyHome.Description + Console.ReadLine());

            Console.ReadLine();

            Console.WriteLine("Thank You TrueCoders! I had a blast. To all the Memories: Angry Bird, Baby Carrots, RollCall, the laughter...best of luck to Mark V!");
            Console.ReadLine();

        }
    }
}





            

           
                
                        
                    
                            
                        
           
    


            

            
            

            
            
        
    

