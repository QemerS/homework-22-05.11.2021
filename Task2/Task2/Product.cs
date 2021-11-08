using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class Product
    {
        public string Name { get; set; }
        public Product(string name)
        {
            this.Name = name;
        }
        public int Price { get; set; }
        public int Count
        {
            get
            {
                return Count;
            }
            set
            {
                if (value > 0)
                {
                    Count = value;
                }
            }
        }
        public int TotalIncome { get; set; }
        public void Sell()
        {
            if (Count > 0)
            {
                Count--;
                TotalIncome++; //deqiq hesablamani tap
            }
            else 
            {
                Console.WriteLine("Satis bas vere bilmez");
            }
        }
    }
}
