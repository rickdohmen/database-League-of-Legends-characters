using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseBWP
{
    class marksman : InfoLoLCHaracters
    {
        public marksman(string Name, string aType) : base(Name, aType)
        {

        }

        public override void ULT()
        {
            Console.WriteLine("fountain of life");
        }

    }
}
