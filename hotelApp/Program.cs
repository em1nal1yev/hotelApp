using System.Threading.Channels;

namespace hotelApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string hotelName;
            Console.WriteLine("Hotel adi daxil edin: ");
            hotelName = Console.ReadLine();
            Hotel hotel = new Hotel(hotelName);

            Room otaqq = new Room("ad", 1, 1);
            

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
                        string otaqAdi;


                        while (true)
                        {
                            Console.WriteLine("otaq adi daxil edin:");
                            otaqAdi = Console.ReadLine();
                            if (hotel.HasRoom(otaqAdi))
                            {
                                Console.WriteLine("Bu adli otaq already var, basqa ad daxil edin!!");
                            }
                            else
                            {
                                break;
                            }
                        }
                        Console.WriteLine("qiymet daxil edin:");
                        string otaqQiymeti = Console.ReadLine();
                        int qiymeti;
                        if (int.TryParse(otaqQiymeti, out qiymeti))
                        {
                        }
                        else
                        {
                            Console.WriteLine("qiymeti duzgun daxil edin!!!");
                        }
                        Console.WriteLine("otaq kapasitesini daxile edin:");
                        string otaqKapasitesi = Console.ReadLine();
                        int kapasitesi;
                        if (int.TryParse(otaqKapasitesi, out kapasitesi)) ;
                        else
                        {
                            Console.WriteLine("Otaqgin tutumunu duzgun qeyd edin!!!");
                        }
                            Room otaq = new Room(otaqAdi, qiymeti, kapasitesi);
                        otaqq = otaq;
                        break;
                    case "2":
                        hotel.AddRoom(otaqq);
                        Console.WriteLine($"{otaqq.Name} adli otaq {hotel.name} hoteline elave olundu");
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
                    case "4":
                        hotel.SHowRooms();
                        break; ;
                    case "0":
                        onnan = false;
                        break;
                }
            }
            Hotel hotel3 = new Hotel("Anaradssda");
            Console.WriteLine(hotel3);
            
        }
    }
}
