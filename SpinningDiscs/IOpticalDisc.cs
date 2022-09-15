using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public interface IOpticalDisc
    {
        public const int StorageCapacity = 128;

        public void SpinDisc();

        public void StoreInfo();

        public void PrintInfo();

    }
}
