using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelApp
{
    class Room
    {
        public static int id;
        public int Id { get; }


        public bool isAvailable = true;

        public string Name { get; set; }
        public int Price { get; set; }
        public int PersonCapasity { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"id si:{id}, adi:{Name}, qiymeti:{Price}, kapasitesi:{PersonCapasity}");
        }

        public Room(string name, int price, int personCapasity)
        {
            Name = name;
            Price = price;
            PersonCapasity = personCapasity;
            id++;
        }
    }
}
