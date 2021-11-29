using System;
using System.Collections.Generic;

namespace DataBaseBWP
{
    class Program
    {
        static void Main(string[] args)
        {
            LoLCharacterDataBase loLCharacterDataBase = new LoLCharacterDataBase();

            InfoLoLCHaracters infoloLCHaracters = new InfoLoLCHaracters("Kha'Zix");
            InfoLoLCHaracters infoloLCHaracters1 = new InfoLoLCHaracters("Kindred");

            loLCharacterDataBase.AddInfo(infoloLCHaracters);
            loLCharacterDataBase.AddInfo(infoloLCHaracters1);

            foreach(InfoLoLCHaracters c in loLCharacterDataBase.GetInfo())
            {
                Console.WriteLine(c.GetName());
            }

        }
    }
}
