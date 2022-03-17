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

                    case "add character":
                        Console.WriteLine("here you can add assassin/marksman characters to the database but keep in mind that the database is bugged");

                        //hier wil ik de functie zetten dat zodra je een van de zes naamen in typed dat ze in de gooede case word toegevoegd
                        string Name = Console.ReadLine();
                        string aType = Console.ReadLine();
                        InfoLoLCHaracters Character  = new marksman(Name, aType);
                        InfoLoLCHaracters CharacterB = new assassin(Name, aType);
                        loLCharacterDataBase.AddInfo(Character);
                        loLCharacterDataBase.AddInfo(CharacterB);
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
