using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTaiLop
{
    public class Car : Vehicle
    {
        public string Brand { get; set; }

        public Car(string name, double price, int year, int seatCount, string brand) : base(name, price, year, seatCount)
        {
            Brand = brand;
        }

    }
}
