using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseBWP
{
    class LoLCharacterDataBase
    {
        private List<InfoLoLCHaracters> infoLoLCHaracters;
        public LoLCharacterDataBase()
        {
             infoLoLCHaracters = new List<InfoLoLCHaracters>();
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
