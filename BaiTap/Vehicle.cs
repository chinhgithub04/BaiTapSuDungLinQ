using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTaiLop
{
    public abstract class Vehicle
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Year { get; set; }
        public int SeatCount { get; set; }

        public Vehicle(string name, double price, int year, int seatCount)
        {
            Name = name;
            Price = price;
            Year = year;
            SeatCount = seatCount;
        }

    }
}
