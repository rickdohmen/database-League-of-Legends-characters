using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseBWP
{
    public abstract class InfoLoLCHaracters
    {
        public string characterName;
        public string characterType;

        public InfoLoLCHaracters(string Name, string aType)
        {
            characterName = Name;
            characterType = aType;
        }

        public string GetName()
        {
            return characterName;
        }

        public new string GetType()
        {
            return characterType;
        }

        abstract public void ULT();
        
    }
}
