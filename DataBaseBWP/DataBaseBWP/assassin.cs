using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseBWP
{
    class assassin : InfoLoLCHaracters
    {
        public assassin(string Name) : base(Name)
        {
            
        }

        public override void ULT()
        {
            Console.WriteLine("Taste Of Fear");
        }
    }
    
}
