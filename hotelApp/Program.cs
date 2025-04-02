using System.Threading.Channels;

namespace hotelApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ToString metodunu overwrite elemeyi basa dusmedim
           

            Room otaqq = new Room("ad", 1, 1);
            Hotel hotel = new Hotel("Riverside");

            bool onnan = true;
            while (onnan)
            {
                Console.WriteLine();
                Console.WriteLine("Otaq yaratmaq ucun 1 basin.");
                Console.WriteLine("Otaq elave etmek ucun 2 basin.");
                Console.WriteLine("Otaq rezerv etmke ucun 3 basin.");
                Console.WriteLine("Cixmaq ucun 0 basin.");
                Console.WriteLine();
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":

                        Console.WriteLine("otaq adi daxil edin:");
                        string otaqAdi = Console.ReadLine();
                        Console.WriteLine("qiymet daxil edin:");
                        int otaqQiymeti = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("otaq kapasitesini daxile edin:");
                        int otaqKapasitesi = Convert.ToInt32(Console.ReadLine());
                        Room otaq = new Room(otaqAdi, otaqQiymeti, otaqKapasitesi);
                        otaqq = otaq;
                        break;
                    case "2":
                        hotel.AddRoom(otaqq);
                        Console.WriteLine($"otaq {hotel.name} hoteline elave olundu");
                        break;
                    case "3":
                        if (otaqq.isAvailable)
                        {
                            hotel.MakeReservation(otaqq.Id);
                            Console.WriteLine("otaq ugurla reserv olundu");
                        }
                        else
                        {
                            Console.WriteLine("Doludu otaq");
                        }
                            break;
                    case "0":
                        onnan = false;
                        break;
                }
            }

            
        }
    }
}
