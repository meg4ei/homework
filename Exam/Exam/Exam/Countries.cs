using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exam
{
    public class Countries
    {
        private string country;
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

         private string city;
         public string City
         {
             get { return city; }
             set { city = value; }
         }


         private long population;
         public long Population
        {
            get { return population; }
            set { population = value; }
        }

        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}", this.country, this.city, this.population);
        }
    }
}

