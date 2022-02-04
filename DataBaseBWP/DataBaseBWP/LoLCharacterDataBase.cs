using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseBWP
{
    class LoLCharacterDataBase
    {
        public List<InfoLoLCHaracters> infoLoLCHaracters;

        public LoLCharacterDataBase()
        {

            infoLoLCHaracters = null;
            LoLCharacterDataBase db = new LoLCharacterDataBase();

            InfoLoLCHaracters Kindred = new marksman("Kindred", "ADC");
            InfoLoLCHaracters Khazix = new assassin("Kha'zix", "JGL");

            db.AddInfo(Kindred);
            db.AddInfo(Khazix);



        }

        public void AddInfo(InfoLoLCHaracters infoloLCHaracters)
        {
            infoLoLCHaracters.Add(infoloLCHaracters);
        }

        public List<InfoLoLCHaracters> GetInfo()
        {
            return infoLoLCHaracters;
        }
    }
}
