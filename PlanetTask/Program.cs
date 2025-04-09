using System.ComponentModel.Design;
using System.Diagnostics;
using System.Xml.Linq;

namespace consolel15
{
    internal class Program
    {
        static void Main(string[] args)
        {

            


            while (true)
            {

                Console.Clear();
                Console.WriteLine("*****Menu*****");
                Console.WriteLine("1.Sisteme giris");
                Console.WriteLine("0.Cixis");

                string choice = Console.ReadLine();
                if (choice == "1")
                {

                    SystemMenu();

                }
                else if (choice == "2")
                {
                    break;
                }






            }



        }

        static void SystemMenu()
        {
            Planet planet = new Planet("Earth");

            while (true) {

                Console.Clear();
                Console.WriteLine("1.olke yarat"); //CreateCountry
                Console.WriteLine("2.Butun olkeleri gor");  ///getAllCountries
                Console.WriteLine("3.olkeni sil");  ////RemoveCountry
                Console.WriteLine("4.olkede deyisiklikler et");  //// UpdateCountry
                Console.WriteLine("Regiona gore olkeni gor");    ///GetCountryByRegion
                Console.WriteLine("0.Exit");   ///Hecne cixirsan


                string choice = Console.ReadLine();
                if (choice == "0") break;
                if (choice == "1") {

                    Console.Write("Olkenin adi :");
                    string CountryName = Console.ReadLine();
                    Console.Write("Olkenin erazisi: ");
                    double Area = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Olkenin himni");
                    string Anthem = Console.ReadLine();
                    Console.Write("Olkenin Regionu");
                    string Region = Console.ReadLine();
                    try
                    {
                        Country z = new Country(CountryName, Area, Anthem, Region);



                        planet.CreateCountry(z);
                    }
                    catch (Exception x)
                    {
                        Console.WriteLine(x.Message);
                    }
                }


                if (choice == "2")
                {
                    planet.GetAllCountries();
                }


                if (choice == "3")
                {

                    Console.Write("Olkenin adi :");
                    string CountryName = Console.ReadLine();
                    planet.RemoveCountry(CountryName);

                }

                if (choice == "4") {


                    string country2;
                    while (true) ;
                   
                    
                    {
                        Console.Write("Olkenin adi :");
                        string CountryName2 = Console.ReadLine();


                        Console.Write("Olkenin erazisi: ");
                        double Area2 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Himni :");
                        string Anthem2 = Console.ReadLine();

                        Console.Write("Olkenin Regionu");
                        string Region2 = Console.ReadLine();

                        Country country3 = new Country(CountryName2, Area2, Anthem2, Region2);
                        planet.UpdateCountry(CountryName2,country3);

                        break;


                    }

                    if (choice == "5") {

                        Console.Write("Olkenin adi :");
                        string Region = Console.ReadLine();
                        

                            planet.GetCountryByRegion(Region);
                          
                        

                    }





                    else if (choice == "0") {

                        Environment.Exit(0);


                    }



                }

            }
        }

    }
}




