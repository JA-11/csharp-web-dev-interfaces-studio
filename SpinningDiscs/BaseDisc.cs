using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        public string Name { get; set; }
        public string DiscType { get; set; }

        public BaseDisc(string name, string discType)
        {
            Name = name;
            DiscType = discType;
        }
        
        public void ReadDisc()
        {
            Console.WriteLine("Reading disc...");
        }

        public void WriteDisc()
        {
            Console.WriteLine("Writing disc...");
        }
    }
}
