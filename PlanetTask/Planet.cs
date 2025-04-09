using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace consolel15
{
    internal class Planet
    {
        public string Name { get; set; }
        public double Area { get; set; }
        public Country[] Countries;

        public Planet(string name)
        {
            Name = name;
            Area = Area;
            Countries = new Country[0];
        }

        public void CreateCountry(Country country)
        {
            Array.Resize(ref Countries, Countries.Length + 1);
            Countries[Countries.Length - 1] = country;
            Console.WriteLine("Yeni olke ugurla elave edildi");

        }

        public void UpdateCountry(string name, Country UpdatedCountry)
        {
            for (int i = 0; i < Countries.Length; i++) {

                if (Countries[i].CountryName == name)
                {

                    Countries[i] = UpdatedCountry;
                }
                break;

            }


        }
        public void GetAllCountries()
        {

            foreach (Country country in Countries)
            {
                Console.WriteLine(country);

            }


        }

        public void RemoveCountry(string name)
        {

            for (int i = 0; i < Countries.Length; i++)
            {
                if (Countries[i].CountryName == name)
                {
                    Countries[i] = default(Country);

                }


               




            }


        }

        public void GetCountryByRegion(string name)
        {


            foreach (Country country in Countries)
            {
                if (country.CountryName == name)
                {



                }
                Console.WriteLine("country");

            }




        }

    }


}








    


