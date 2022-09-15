using System;
using System.Collections.Generic;
namespace SpinningDiscs
{
    public class CD : BaseDisc , IOpticalDisc
    {
        public List<string> TrackNames { get; set; }

        public CD(List<string> trackNames, string name, string discType) : base(name, discType)
        {
            TrackNames = trackNames;
        }

        public void SpinDisc()
        {
            Console.WriteLine("A CD spins at a rate of 200 - 500 rpm.");
        }

        public void StoreInfo()
        {
            Console.WriteLine("Storing CD data...");
        }

        public void PrintTrackNames()
        {
            foreach (string track in TrackNames)
            {
                Console.WriteLine(track);
            }
                        
        }

        public void PrintInfo()
        {

            Console.WriteLine($"Name: {Name}\nDisc Type: {DiscType}\nTrack List: {TrackNames}\nStorage Capacity: {IOpticalDisc.StorageCapacity}");
        }



        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
    }
}
