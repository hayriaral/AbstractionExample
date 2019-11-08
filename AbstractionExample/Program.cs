using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExample
{
    class Program
    {
        static void Main( string[] args )
        {
            #region Instance olusturma ve methodları kullanma

            Car car = new Car("Ford",5);
            Bus bus = new Bus("BMC", 40);

            Console.WriteLine( car );
            car.Honk();
            car.Move();
            Console.WriteLine();
            Console.WriteLine( bus );
            bus.Honk();
            bus.Move();

            Console.WriteLine( "-------------------" );
            Console.WriteLine("\nSonraki regiona gecmek icin enter'a basın!");
            Console.ReadLine();

            #endregion

            #region Linq kullanımı

            List<Vehicle> vehicles = new List<Vehicle>();

            Car car1 = new Car("Toyota", 5);
            Car car2 = new Car("Porche", 2);
            Car car3 = new Car("BMW", 5 );

            Bus bus1 = new Bus("Mercedes", 45);
            Bus bus2 = new Bus("Karsan", 50);
            Bus bus3 = new Bus("Volvo", 30);

            vehicles.Add( car1 );
            vehicles.Add( car2 );
            vehicles.Add( car3 );
            vehicles.Add( bus1 );
            vehicles.Add( bus2 );
            vehicles.Add( bus3 );

            foreach ( Vehicle vehicle in vehicles )
            {
                Console.WriteLine(vehicle);
            }

            Console.WriteLine("\nKoltuk sayısı için bir sayı giriniz: ");
            int seatSelection = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nKoltuk Sayısı " + seatSelection.ToString() + " olan araçlar:");

            List<Vehicle> vehiclesFilteredBySeat = vehicles.Where( t => t.Seat == seatSelection ).ToList();

            if ( vehiclesFilteredBySeat.Count>0 )
            {
                foreach ( Vehicle vehicle in vehiclesFilteredBySeat )
                {
                    Console.WriteLine( vehicle );
                }
            }
            else
            {
                Console.WriteLine("araç yok!");
            }

            Console.WriteLine("-------------------");
            Console.WriteLine("\nListeye eklenen ilk araç:");
            var firstVehicle = vehicles.FirstOrDefault();
            Console.WriteLine(firstVehicle);


            Console.ReadLine();

            #endregion
        }
    }
}
