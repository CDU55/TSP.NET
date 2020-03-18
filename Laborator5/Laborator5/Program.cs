using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator5
{
    class Program
    {
        public static void TestScenariu1()
        {
            ModelSelfRefrences context = new ModelSelfRefrences();
            SelfReference referinta1 = new SelfReference() { Name = "Referinta1" };
            SelfReference referinta2 = new SelfReference() { Name = "Referinta2", ParentSelfReference = referinta1 };
            referinta1.References.Add(referinta2);
            SelfReference referinta3 = new SelfReference() { Name = "Referinta3", ParentSelfReference = referinta2 };
            referinta2.References.Add(referinta3);
            SelfReference referinta4 = new SelfReference() { Name = "Referinta4", ParentSelfReference = referinta2 };
            referinta2.References.Add(referinta4);
            context.SelfReferences.Add(referinta1);
            context.SelfReferences.Add(referinta2);
            context.SelfReferences.Add(referinta3);
            context.SelfReferences.Add(referinta4);
            context.SaveChanges();

        }
        public static void Scenariu3()
        {
            byte[] thumbBits = new byte[100];
            byte[] fullBits = new byte[2000];
            using (var context = new Scenariu3())
            {
                var photo = new Photograph
                {
                    Title = "My Dog",
                    ThumbnailBits = thumbBits
                };
                var fullImage = new PhotographFullImage
                {
                    HighResolutionBits =
                fullBits
                };
                photo.PhotographFullImage = fullImage;
                context.Photos.Add(photo);
                context.SaveChanges();
            }
            using (var context = new Scenariu3())
            {
                foreach (var photo in context.Photos)
                {
                    Console.WriteLine("Photo: {0}, ThumbnailSize {1} bytes",
                    photo.Title, photo.ThumbnailBits.Length);
                    // explicitly load the "expensive" entity,
                    // context.Entry(photo)
                    //.Reference(p => p.PhotographFullImage).Load();
                    Console.WriteLine("Full Image Size: {0} bytes",
                    photo.PhotographFullImage.HighResolutionBits.Length);
                }
            }
        }

        public static void Scenariu4()
        {
            using (var context = new Scenariu4())
            {
                var business = new Business
                {
                    Name = "Corner Dry Cleaning",
                    LicenseNumber = "100x1"
                };
                context.Businesses.Add(business);
                var retail = new Retail
                {
                    Name = "Shop and Save",
                    LicenseNumber =
                "200C",
                    Address = "101 Main",
                    City = "Anytown",
                    State = "TX",
                    ZIPCode = "76106"
                };
                context.Businesses.Add(retail);
                var web = new eCommerce
                {
                    Name = "BuyNow.com",
                    LicenseNumber =
                "300AB",
                    URL = "www.buynow.com"
                };
                context.Businesses.Add(web);
                context.SaveChanges();
            }
            using (var context = new Scenariu4())
            {
                Console.WriteLine("\n--- All Businesses ---");
                foreach (var b in context.Businesses)
                {
                    Console.WriteLine("{0} (#{1})", b.Name, b.LicenseNumber);
                }
                Console.WriteLine("\n--- Retail Businesses ---");
                foreach (var r in context.Businesses.OfType<Retail>())
                {
                    Console.WriteLine("{0} (#{1})", r.Name, r.LicenseNumber);
                    Console.WriteLine("{0}", r.Address);
                    Console.WriteLine("{0}, {1} {2}", r.City, r.State, r.ZIPCode);
                }
                Console.WriteLine("\n--- eCommerce Businesses ---");
                foreach (var e in context.Businesses.OfType<eCommerce>())
                {
                    Console.WriteLine("{0} (#{1})", e.Name, e.LicenseNumber);
                    Console.WriteLine("Online address is: {0}", e.URL);
                }
            }
        }
        public static void Scenariu5()
        {
            using (var context = new Scenariu5())
            {
                var fte = new FullTimeEmployee
                {
                    FirstName = "Jane",
                    LastName =
                "Doe",
                    Salary = 71500M
                };
                context.Employees.Add(fte);
                fte = new FullTimeEmployee
                {
                    FirstName = "John",
                    LastName = "Smith",
                    Salary = 62500M
                };
                context.Employees.Add(fte);
                var hourly = new HourlyEmployee
                {
                    FirstName = "Tom",
                    LastName =
                "Jones",
                    Wage = 8.75M
                };
                context.Employees.Add(hourly);
                context.SaveChanges();
            }
            using (var context = new Scenariu5())
            {
                Console.WriteLine("--- All Employees ---");
                foreach (var emp in context.Employees)
                {
                    bool fullTime = emp is HourlyEmployee ? false : true;
                    Console.WriteLine("{0} {1} ({2})", emp.FirstName, emp.LastName,
                    fullTime ? "Full Time" : "Hourly");
                }
                Console.WriteLine("--- Full Time ---");
                foreach (var fte in context.Employees.OfType<FullTimeEmployee>())
                {
                    Console.WriteLine("{0} {1}", fte.FirstName, fte.LastName);
                }
                Console.WriteLine("--- Hourly ---");
                foreach (var hourly in context.Employees.OfType<HourlyEmployee>())
                {
                    Console.WriteLine("{0} {1}", hourly.FirstName,
                    hourly.LastName);
                }
            }
        }
        public static void AfisareScenariu1()
        {
            ModelSelfRefrences context = new ModelSelfRefrences();
            foreach (var reference in context.SelfReferences.ToList())
            {
                Console.WriteLine($"Referinta:{reference.Name} NumeParinte:{(reference.ParentSelfReference != null ? reference.ParentSelfReference.Name : "None")}");
            }
        }
        static void Main(string[] args)
        {
            Scenariu5();
        }
    }
}
