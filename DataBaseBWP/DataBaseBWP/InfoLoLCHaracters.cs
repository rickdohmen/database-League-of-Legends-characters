using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseBWP
{
    public abstract  class InfoLoLCHaracters
    {
        public string name;
        public string characterType;

        public InfoLoLCHaracters(string Name, string aType)
        {
            name = Name;
            characterType = aType;
        }

        public string GetName()
        {
            return name;
        }

        public string GetType()
        {
            return characterType;
        }

        abstract public void ULT();
        
    }
}
