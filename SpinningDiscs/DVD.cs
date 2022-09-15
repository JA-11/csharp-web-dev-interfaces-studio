using System;
using System.Collections.Generic;
namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisc
    {
        public string MovieSynopsis { get; set; }

        public DVD(string movieSynopsis, string name, string discType) : base(name, discType)
        {
            MovieSynopsis = movieSynopsis;
        }

        public void SpinDisc()
        {
            Console.WriteLine("A DVD spins at a rate of 570 - 1600 rpm.");
        }

        public void StoreInfo()
        {
            Console.WriteLine("Storing DVD data...");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}\nDisc Type: {DiscType}\nSynopsis: {MovieSynopsis}\nStorage Capacity: {IOpticalDisc.StorageCapacity}");
        }


        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
    }
}
