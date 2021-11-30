using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseBWP
{
    abstract class InfoLoLCHaracters
    {
        private string name;
        

        public InfoLoLCHaracters(string Name)
        {
            name = Name;
        }

        public string GetName()
        {
            return name;
        }

        abstract public void ULT();
        
    }
}
