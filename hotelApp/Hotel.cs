using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelApp
{
    class Hotel
    {
        public string name;
        Room[] Rooms = new Room[0];

        public bool HasRoom(string roomName)
        {
            for (int i= 0; i<Rooms.Length; i++)
            {
                if (Rooms[i].Name == roomName)
                {
                    return true;
                    break;
                }
            }
            return false;
        }
        public Hotel(string name)
        {
            this.name = name;
        }
        public void MakeReservation(int roomId)
        {
            for(int i = 0; i<Rooms.Length;i++)
            {
                if (Rooms[i].Id == roomId)
                {
                    if (!Rooms[i].isAvailable)
                    {
                        Console.WriteLine("The room is full!");
                    }
                    else
                    {
                        Rooms[i].isAvailable = false;
                    }
                }
            }
        }

        public void AddRoom(Room room)
        {
            Array.Resize(ref Rooms, Rooms.Length + 1);
            Rooms[^1] = room; 
        }

        public void SHowRooms()
        {
            for(int i = 0; i < Rooms.Length; i++)
            {
                if (i == Rooms.Length-1)
                {
                    Console.WriteLine(Rooms[i].Name + " ");
                }
                else
                {
                    Console.Write(Rooms[i].Name + " ");
                }
            }
        }

        public override string ToString()
        {
            return "Anar";
        }

        //public override string ToString()
        //{
        //    return base.ToString();
        //}

    }
}
