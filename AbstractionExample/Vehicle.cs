using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExample
{
    //Abstract classlardan nesne türetilemez.
    //Pek çok yönden ortak özellik taşıyan classların ana classı olması için oluşturulur.
    public abstract class Vehicle
    {
        private string brand; //field

        //Property fieldlara erişmemizi sağlayan mekanizmadır.
        public string Brand //property
        {
            get
            {
                return brand;
            }
            set
            {
                brand = value;
            }
        }
        
        public int Seat { get; set; } //prop + TAB + TAB ile oluşturulan property

        //virtual methodların tanımı yeterli ise alt classlar tarafından kullanılır. Gerektiğinde override edilir.
        public virtual void Honk()
        {
            Console.WriteLine("Düüüt!");
        }

        //Abstract method tanımlanırken gövdesi bulunmaz ve inherit edilen alt classların override etmesi zorunludur.
        public abstract void Move();

        //Parametreli constructor kullandığımızda, bu sınıftan kalıtım alan alt sınıfların objeleri oluşturulurken parametlerin girilmesini mecbur hale getiriyoruz.
        public Vehicle(string _brand, int _seat)
        {
            brand = _brand;
            Seat = _seat;
        }

        public override string ToString()
        {
            return "Brand: " + Brand + "\t" + "Seat: " + Seat.ToString();
        }
    }
}
