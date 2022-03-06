using System;
using System.Collections.Generic;

namespace DataBaseBWP
{
    class Program
    {

        static void Main(string[] args)
        {
            

            LoLCharacterDataBase loLCharacterDataBase = new LoLCharacterDataBase();
            

            InfoLoLCHaracters Kindred = new marksman("Kindred", "ADC");
            InfoLoLCHaracters Khazix = new assassin("Kha'zix", "JGL");

            loLCharacterDataBase.AddInfo(Kindred);
            loLCharacterDataBase.AddInfo(Khazix);

            bool bShouldRun = true;

            while(bShouldRun)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "marksman":
                        foreach(InfoLoLCHaracters c in loLCharacterDataBase.GetInfo())
                        {
                            if(c.GetName() == "Kindred")
                            {
                                Console.WriteLine(c.characterName + " is a marksman(ADC)");
                            }
                            
                        }
                        break;
                        

                    case "assassin":

                        foreach (InfoLoLCHaracters c in loLCharacterDataBase.GetInfo())
                        {
                            if (c.GetName() == "Kha'zix")
                            {
                                Console.WriteLine(c.characterName + " is a assassin(JGL)");
                            }

                        }
                        break;
                   


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
            
            

        }
    }
}
