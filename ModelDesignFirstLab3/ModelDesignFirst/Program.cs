using System;

namespace ModelDesignFirst
{


    class Program
    {
        static void TesTOneToMany()
        {
            Console.WriteLine("One to many association");
            using (CustomerOrderContainer context =
           new CustomerOrderContainer())
            {
                Customer c = new Customer()
                {
                    Name = "Customer 1",
                    City = "Iasi"
                };
                Order o1 = new Order()
                {
                    TotalValue = 200,
                    Date = DateTime.Now,
                    Customer = c
                };
                Order o2 = new Order()
                {
                    TotalValue = 300,
                    Date = DateTime.Now,
                    Customer = c
                };
                context.Customers.Add(c);
                context.Orders.Add(o1);
                context.Orders.Add(o2);
                context.SaveChanges();
                var items = context.Customers;
                foreach (var x in items)
                {
                    Console.WriteLine("Customer : {0}, {1}, {2}",
                   x.CustomerId, x.Name, x.City);
                    foreach (var ox in x.Orders)
                        Console.WriteLine("\tOrders: {0}, {1}, {2}",
                       ox.OrderId, ox.Date, ox.TotalValue);
                }
            }
        }

        public static void ManageMusicData()
        {
            MusicService service = new MusicService(new AlbumArtistContainer());
            String response;
            String option;
            Console.WriteLine("Options:");
            Console.WriteLine("Add Artist");
            Console.WriteLine("Add Album");
            Console.WriteLine("Add Relationship");

            while (true)
            {
                Console.Write("Continue?[Y\\N]");
                response = Console.ReadLine();
                if (response != "Y")
                    break;
                Console.Write("Pick an option:");
                option = Console.ReadLine();
                if (option == "Add Artist")
                {
                    String first;
                    String last;
                    Console.Write("First Name:");
                    first = Console.ReadLine();
                    Console.Write("Last Name:");
                    last = Console.ReadLine();
                    Artist a = new Artist() { FirstName = first, LastName = last };
                    service.AddArtist(a);
                }
                else if (option == "Add Album")
                {
                    String name;
                    Console.Write("Album Name:");
                    name = Console.ReadLine();
                    Album a = new Album() { AlbumName = name };
                    service.AddAlbum(a);

                }
                else if (option == "Add Relationship")
                {
                    int artistID;
                    int albumID;
                    Console.Write("Artist ID:");
                    artistID = Int32.Parse(Console.ReadLine());
                    Console.Write("Album ID:");
                    albumID = Int32.Parse(Console.ReadLine());
                    if (!service.BindAlbumAndArtist(albumID, artistID))
                    {
                        Console.WriteLine("Invalid Album or Artist ID");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid Option");
                }
            }
        }
        static void Main(string[] args)
        {
            ManageMusicData();
        }
        static void TestPerson()
        {
            using (Model1Container context = new Model1Container())
            {
                String response;
                String first;
                String last;
                String middle;
                String tel;
                while (true)
                {
                    Console.Write("Continue?[Y\\N]");
                    response = Console.ReadLine();
                    if (response != "Y")
                        break;
                    Console.Write("First Name: ");
                    first = Console.ReadLine();
                    Console.Write("Last Name: ");
                    last = Console.ReadLine();
                    Console.Write("Middle Name: ");
                    middle = Console.ReadLine();
                    Console.Write("Telephone Number: ");
                    tel = Console.ReadLine();
                    Person p = new Person()
                    {
                        FirstName = first,
                        LastName = last,
                        MiddleName = middle,
                        TelephonNumber = tel
                    };
                    context.People.Add(p);
                    context.SaveChanges();
                }


                var items = context.People;
                foreach (var x in items)
                    Console.WriteLine("{0} {1}", x.Id, x.FirstName);
            }
        }
    }
}
