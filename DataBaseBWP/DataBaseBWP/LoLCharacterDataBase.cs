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
