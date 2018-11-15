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
            };

            Console.WriteLine("What square footage are you looking for?");
            int sqFt = Convert.ToInt32(Console.ReadLine());
            var filteredHomes = listOfTinyHomes.Where(tinyHome => tinyHome.Cost > 10000 && tinyHome.SquareFeet > sqFt);
            foreach (TinyHome tinyHome in filteredHomes)
                Console.WriteLine(tinyHome.HouseName + ":   " + tinyHome.SquareFeet + "sqft    " + " " + tinyHome.Cost + "     " + tinyHome.Description + Console.ReadLine());
            
                Console.ReadLine();

            Console.WriteLine("What price are you looking for?");
            int Cost = Convert.ToInt32(Console.ReadLine());
            filteredHomes = listOfTinyHomes.Where(tinyHome => tinyHome.Cost > Cost && tinyHome.SquareFeet > sqFt);
            foreach (TinyHome tinyHome in filteredHomes)
                Console.WriteLine(tinyHome.HouseName + ":   " + tinyHome.SquareFeet + "sqft    " + " " + tinyHome.Cost + "     " + tinyHome.Description + Console.ReadLine());

            Console.ReadLine();


            Console.WriteLine("Tiny houses are popping up around the country as more people decide to downsize their lives.\nWhile the structures often measure less than 300 square feet,\n" +
                "the tiny house movement isn't necessarily about sacrifice.\n With thoughtful, innovative designs, some homeowners have\ndiscovered a small house actually leads to a simpler yet fuller life, \nconnecting them with" +
            "family, friends, and nature while freeing them from mortgages and an urge to keep up\n with the Joneses.  ~ David Hillegas");
            Console.ReadLine();
            Console.WriteLine("Welcome to Tiny Homes!");
            Console.WriteLine("Can you share your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine($"Hello, {firstName}, it's very nice to meet you.");
            Console.ReadLine();

            //Begin Tour with which house to visit.
            Console.WriteLine("Folks who choose tiny homes, do so for a variety of reasons different from the day-to-day home buyer.");
            Console.WriteLine("Let's begin by grouping our homes into 3 varieties:");
            Console.WriteLine("(Enter 1)--Most Economical");
            Console.WriteLine("(Enter 2)--Most Luxurious");
            Console.WriteLine("(Enter 3) --Smallest Environmental Footprint  ");
            string houseOption = Console.ReadLine();
            //House OPtion #1 - Economical (Price Driven)
            if (houseOption.ToLower() == "1")
            {
                filteredHomes = listOfTinyHomes.Where(tinyHome => tinyHome.Cost < 50000);
                foreach (TinyHome tinyHome in filteredHomes)
                    Console.WriteLine(tinyHome.HouseName + ":   " + tinyHome.SquareFeet + "sqft    " + " " + tinyHome.Cost + "     " + tinyHome.Description + Console.ReadLine());

                Console.ReadLine();

                Console.WriteLine("Ok, let's look at some of the features for the first version of our tiny homes:");
                Console.WriteLine(" Select  Cost:  (C)");
                Console.WriteLine("Square Footage: (S)");
                Console.WriteLine("BedType:        (B)");
                Console.WriteLine("ToiletType:     (T)");
                string houseFeatures = Console.ReadLine();


                if (houseFeatures.ToUpper() == "C")
                {
                    Console.WriteLine("The cost for the first version of my Tiny Home is $20,000!" +
                    "That's right, this includes everything you will need for build out, setup and turnkey, move-in ready!");
                    Console.ReadLine();
                    Console.WriteLine("Select (S) for square footage or (B) for the Bed setup or (T) for Toilet Type");
                    houseFeatures = Console.ReadLine();
                    if (houseFeatures.ToUpper() == "S")
                    {
                        Console.WriteLine("The square footage for this home is 96 square feet.");
                        Console.WriteLine("It will require amount of downsizing but imagine the freedom!");
                        Console.WriteLine("The type of bed is also important, please select (B) to see more details or (T) for Toilet Type.");
                        houseFeatures = Console.ReadLine();
                        if (houseFeatures.ToUpper() == "B")
                        {
                            Console.WriteLine("A sofa bed is compatible for this version.");
                            Console.WriteLine("The comforts of your sitting area by day can transform into a bedroom in the evening.");
                            Console.ReadLine();
                        }
                        else if (houseFeatures.ToUpper() == "T")
                        {
                            Console.WriteLine("A bucket toilet is installed in the first version. Remember you may have to do a bit more work with this" +
              "type of elimination infrastructure, but its affordable!");
                        }

                    }
                    else if (houseFeatures.ToUpper() == "B")
                    {
                        Console.WriteLine("A sofa bed is compatible for this version.");
                        Console.WriteLine("The comforts of your sitting area by day can transform into a bedroom in the evening.");
                        Console.ReadLine();

                        Console.WriteLine("Select (C) for square footage or (S) for the Bed setup or (T) for Toilet Type.");
                        houseFeatures = Console.ReadLine();
                        if (houseFeatures.ToUpper() == "C")
                        {
                            Console.WriteLine("The cost for the first version of my Tiny Home is $20,000!");
                            Console.WriteLine("That's right, this includes everything you will need for build out, setup and turnkey, move-in ready!");
                            Console.ReadLine();
                            Console.WriteLine("The amount of space is also important, please select (S) to see more details or (T) for Toilet Type.");
                            houseFeatures = Console.ReadLine();
                            if (houseFeatures.ToUpper() == "S")
                            {
                                Console.WriteLine("The square footage for this home is 96 square feet.");
                                Console.WriteLine("It will require amount of downsizing but imagine the freedom!");
                                Console.ReadLine();
                            }
                            else if (houseFeatures.ToUpper() == "T")
                            {
                                Console.WriteLine("A bucket toilet is installed in the first version.");
                                Console.WriteLine("Remember you may have to do a bit more work with this");
                                Console.WriteLine("type of elimination infrastructure, but its affordable!");
                            }
                            Console.ReadLine();
                        }
                        else if (houseFeatures.ToUpper() == "B")
                        {
                            Console.WriteLine("A sofa bed is compatible for this version.");
                            Console.WriteLine("The comforts of your sitting area by day can transform into a bedroom in the evening.");
                            Console.ReadLine();
                            Console.WriteLine("Select (C) for square footage or (S) for the Square Footage or (T) for Toilet Type.");
                            houseFeatures = Console.ReadLine();
                            if (houseFeatures.ToUpper() == "C")
                            {
                                Console.WriteLine("The cost for the first version of my Tiny Home is $20,000!");
                                Console.WriteLine("That's right, this includes everything you will need for build out, setup and turnkey, move-in ready!");
                                Console.ReadLine();
                                Console.WriteLine("The amount of space is also important, please select (S) to see more details or (T) for Toilet Type.");
                                houseFeatures = Console.ReadLine();
                                if (houseFeatures.ToUpper() == "S")
                                {
                                    Console.WriteLine("The square footage for this home is 96 square feet.");
                                    Console.WriteLine("It will require amount of downsizing but imagine the freedom!");

                                    Console.ReadLine();
                                }
                                else if (houseFeatures.ToUpper() == "T")
                                {
                                    Console.WriteLine("A bucket toilet is installed in the first version.");
                                    Console.WriteLine("Remember you may have to do a bit more work with this");
                                    Console.WriteLine("type of elimination infrastructure, but its affordable!");
                                }
                                Console.ReadLine();
                            }
                            else if (houseFeatures.ToUpper() == "T")
                            {
                                Console.WriteLine("A bucket toilet is installed in the first version. Remember you may have to do a bit more work with this" +
                                  "type of elimination infrastructure, but its affordable!");

                                Console.ReadLine();
                                Console.WriteLine("Select (C) for cost or (S) for the Square Footage or (B) for the recommended Bed used for this home.");
                                houseFeatures = Console.ReadLine();
                                if (houseFeatures.ToUpper() == "C")
                                {
                                    Console.WriteLine("The cost for the first version of my Tiny Home is $20,000!");
                                    Console.WriteLine("That's right, this includes everything you will need for build out, setup and turnkey, move-in ready!");
                                    Console.ReadLine();
                                    Console.WriteLine("The type of bed is also important, please select (B) to see more details or");
                                    Console.WriteLine(" (T) for type of Toilet used.");
                                    houseFeatures = Console.ReadLine();
                                    if (houseFeatures.ToUpper() == "S")
                                    {
                                        Console.WriteLine("The square footage for this home is 96 square feet.");
                                        Console.WriteLine("It will require amount of downsizing but imagine the freedom!");

                                        Console.ReadLine();
                                    }
                                    Console.ReadLine();
                                }
                            }
                        }
                    }
                }
            }

            //House Option #2 - Luxury Based
            else if (houseOption == "2")
            {
                Console.WriteLine("Ok, let's look at some of the features for the second version of our tiny homes:" +
                    " Select  Cost:           (C)" +
                     "Square Footage: (S)" +
                     "BedType:        (B)" +
                     "ToiletType:     (T)");
                string houseFeatures = Console.ReadLine();

                if (houseFeatures.ToUpper() == "C")
                {
                    Console.WriteLine("The cost for the second version of my Tiny Home is $41,500! " +
                      "That's right, this includes everything you will need for build out, setup and turnkey operation.");
                    Console.ReadLine();
                }
                else if (houseFeatures.ToUpper() == "S")
                {
                    Console.WriteLine("The square footage for this home is 160 square feet");
                    Console.ReadLine();
                }
                else if (houseFeatures == "B")
                {
                    Console.WriteLine("A sofa bed and a loft is compatible for this version. So that the comforts of your sitting area transfrom into a bedroom in the evening.");
                    Console.ReadLine();
                }
                else if (houseFeatures == "T")
                {
                    Console.WriteLine("A compost toilet is installed in the first version. Remember you may have to do a bit more work with this" +
                      "type of elimination infrastructure, but its affordable!");
                }
            }
            //House Option #3 -- Smallest Environmental Footprint
            else if (houseOption == "3")

            {
                Console.WriteLine("Ok, let's look at some of the features for the third version of our tiny homes:" +
                    " Select  Cost:           (C)" +
                             "Square Footage: (S)" +
                             "BedType:        (B)" +
                             "ToiletType:     (T)");
                string houseFeatures = Console.ReadLine();
                //public static char[] houseFeature { 'C', 'S', 'B', 'T' }

                if (houseFeatures == "C")
                {
                    Console.WriteLine("The cost for the third version of my Tiny Home is $20,000! " +
                      "That's right, this includes everything you will need for build out, setup and turnkey operation.");
                    Console.ReadLine();
                }
                else if (houseFeatures == "S")
                {
                    Console.WriteLine("The square footage for this home is 97 square feet of floor space.");
                    Console.ReadLine();
                }
                else if (houseFeatures == "B")
                {
                    Console.WriteLine("A murphy bed is compatible for this version. So that the comforts of your sitting area transfrom into a bedroom in the evening.");
                    Console.ReadLine();
                }
                else if (houseFeatures == "T")
                {
                    Console.WriteLine("A composting toilet is installed in the first version. Remember you may have to do a bit more work with this" +
                      "type of elimination infrastructure, but its affordable!");
                    Console.ReadLine();
                }
            }
                        }
                    }
                }
            
        
    
    


            

            
            

            
            
        
    

