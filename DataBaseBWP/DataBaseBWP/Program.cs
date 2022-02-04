using System;
using System.Collections.Generic;

namespace DataBaseBWP
{
    class Program
    {
        static void Main(string[] args)
        {
            LoLCharacterDataBase db = new LoLCharacterDataBase();

            InfoLoLCHaracters Kindred = new InfoLoLCHaracters("Kaitlyn", "ADC");

            db.AddInfo(Kindred);

            LoLCharacterDataBase loLCharacterDataBase = new LoLCharacterDataBase();

            bool bShouldRun = true;

            while(bShouldRun)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "marksman":
                        foreach(InfoLoLCHaracters c in loLCharacterDataBase.GetInfo())
                        {
                            if(c.GetName() == "marksman")
                            {
                                Console.WriteLine(c.name + "is a marksman");
                            }
                            
                        }
                        break;
                        /*InfoLoLCHaracters infoloLCHaracters = new marksman("Kindred");
                        loLCharacterDataBase.AddInfo(infoloLCHaracters);
                        Console.WriteLine("Added A marksman");
                        break;*/

                    case "assassin":

                        foreach (InfoLoLCHaracters c in loLCharacterDataBase.GetInfo())
                        {
                            if (c.GetName() == "assassin")
                            {
                                Console.WriteLine(c.name + "is a assassin");
                            }

                        }
                        break;
                    /*InfoLoLCHaracters infoloLCHaracters1 = new assassin("Kha'Zix");
                    loLCharacterDataBase.AddInfo(infoloLCHaracters1);
                    Console.WriteLine("Added A assassin");*/


                    case "all":
                        var allCharacters = loLCharacterDataBase.GetInfo();
                        foreach (var c in allCharacters)
                        {
                            Console.WriteLine(c.GetName());
                        }
                        break;

                    case "exit":
                        bShouldRun = false;
                        Console.WriteLine("Exit the program");
                        break;
                }
            }
            
            /*
            InfoLoLCHaracters infoloLCHaracters = new assassin("Kha'Zix");
            InfoLoLCHaracters infoloLCHaracters1 = new marksman("Kindred");

            loLCharacterDataBase.AddInfo(infoloLCHaracters);


            string filter = Console.ReadLine();
            /*
            switch (filter)
            {
                case "All":

                    goto case "marksman";

                case "marksman":
                    loLCharacterDataBase.AddInfo(infoloLCHaracters1);

                    if(filter == "All")
                    {
                        goto case "Assassin";
                    }
                    break;

            }

            foreach(InfoLoLCHaracters c in loLCharacterDataBase.GetInfo())
            {
                c.ULT();
                Console.WriteLine(c.GetName());
            }
            */

        }
    }
}
