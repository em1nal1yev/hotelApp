using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelApp
{
    class Room
    {
        public int id;
        public int Id { get; }
        string _name;
        int _price;
        int _personCapacity;
        public bool isAvailable = true;

        public void ShowInfo()
        {
            Console.WriteLine($"id si:{id}, adi:{_name}, qiymeti:{_price}, kapasitesi:{_personCapacity}");
        }

        public Room(string name, int price, int personCapasity)
        {
            _name = name;
            _price = price;
            _personCapacity = personCapasity;
        }
    }
}
