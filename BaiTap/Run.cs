using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTaiLop
{
    public class Run
    {
        public static void Main(string[] args)
        {
            //Câu 2
            Console.WriteLine("Cau 2");
            List<Car> cars = new List<Car>()
            {
                //      Name          Price   Year SeatCount Brand
                new Car("Honda CR-V", 156999, 1995, 7, "Honda"),
                new Car("Perodua Myvi", 19999, 2000, 5, "Toyota"),
                new Car("Honda City", 230000, 1989, 5, "Honda"),
                new Car("BMW X7 3.0", 588000, 1992, 6, "BMW"),
                new Car("Lexus NX300", 182000, 2019, 7, "Lexus"),
                new Car("BMW X3", 156800, 1985, 4, "BMW")
            };

            //a.hiển thị các xe có giá trong khoảng 100.000 đến 250.000; 
            var PriceCar = cars.Where(car => car.Price >= 100000 && car.Price <= 250000);
            Console.WriteLine("Cac xe co gia trong khoang 100.000 den 250.000:");
            foreach (var car in PriceCar)
            {
                Console.WriteLine("Ten: " + car.Name + ", Gia: " + car.Price);
            }

            //b. các xe có năm sản xuất > 1990.
            var YearCar = cars.Where(car => car.Year > 1990);
            Console.WriteLine("\nCac xe co nam san xuat > 1990:");
            foreach (var car in YearCar)
            {
                Console.WriteLine("Ten: " + car.Name + ", Nam san xuat: " + car.Year);
            }

            //c. gom các xe theo hãng sản xuất, tính tổng giá trị theo nhóm
            var GroupedCars = cars
                              .GroupBy(car => car.Brand)
                              .Select(group => new
                              {
                                  Brand = group.Key,
                                  TotalPrice = group.Sum(car => car.Price)
                              });
            Console.WriteLine("\nTong gia tri cua nhom xe theo hang san xuat:");
            foreach (var group in GroupedCars)
            {
                Console.WriteLine("Hang san xuat: " + group.Brand + ", Tong so tien: " + group.TotalPrice);
            }

            //Cau 3
            Console.Write("\nCau 3");

            List<Truck> trucks = new List<Truck>()
            {
                //            Name   Price    Year SeatCount Company
                new Truck("Ford F-450", 59455, 2024, 4, "Ford"),
                new Truck("Nissan Frontier", 30030, 2021, 4, "Nissan"),
                new Truck("Jeep Gladitor", 37895, 2011, 4, "Jeep"),
                new Truck("GMC Hummer EV", 96500, 2017, 5, "GMC"),
                new Truck("Hyundai Santa Cruz", 26900, 2015, 4, "Hyundai")
            };

            //a.hiển thị danh sách Truck theo thứ tự năm sản xuất mới nhất
            var YearTrucks = trucks.OrderByDescending(truck => truck.Year);
            Console.WriteLine("\nDanh sach truck theo thu tu nam san xuat moi nhat:");
            foreach (var truck in YearTrucks)
            {
                Console.WriteLine("Ten: " + truck.Name + ", Nam san xuat: " + truck.Year);
            }

            //b. hiển thị tên cty chủ quản của Truck
            Console.WriteLine("\nCong ty chu quan cua moi Truck");
            foreach (var truck in trucks)
            {
                Console.WriteLine("Ten: " + truck.Name + ", Cong ty chu quan: " + truck.Company);
            }
        }
    }
}
