using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTaiLop
{
    public class Truck : Vehicle
    {
        public string Company { get; set; }

        public Truck(string name, double price, int year, int seatCount, string company) : base(name, price, year, seatCount)
        {
            Company = company;
        }


    }
}
