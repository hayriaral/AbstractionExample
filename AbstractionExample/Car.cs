using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExample
{
    public class Car : Vehicle
    {
        public Car( string _brand, int _seat ) : base( _brand, _seat )
        {
        }

        public override void Move()
        {
            Console.WriteLine("The car moves fast.");
        }
    }
}
