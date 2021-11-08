using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Milk : Product
    {


        public Milk(string name, int volume, int fatRate)
        {
            this.Name = name;
            this.Volume = volume;
            this.FatRate = fatRate;
        }

        public int Volume
        {
            get;set;
        }
        public int FatRate
        {
            get;set;
        }
    }
}
