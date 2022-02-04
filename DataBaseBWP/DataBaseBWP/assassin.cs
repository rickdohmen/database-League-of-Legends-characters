using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseBWP
{
    class assassin : InfoLoLCHaracters
    {
        public assassin(string Name, string aType) : base(Name, aType)
        {
            
        }

        public override void ULT()
        {
            Console.WriteLine("Taste Of Fear");
        }
    }
    
}
