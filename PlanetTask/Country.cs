using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolel15
{
    internal class Country
    {

        public string CountryName { get; set; }
        public double Area { get; set; }
        public string Anthem { get; set; }
        public string Region { get; set; }


        public Country(string CountryName, double Area, string Anthem, string Region)
        {
            this.CountryName = CountryName;
            this.Area = Area;
            this.Anthem = Anthem;
            this.Region = Region;
        }


    }
}