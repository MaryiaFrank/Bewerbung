using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Countries_Frank
{
    public class Quiz
    {
        private int id;
        private string country;
        private string capital;
        private string flag;

        public Quiz (int id, string country, string capital, string flag)
        {
            this.id = id;
            this.country = country;
            this.capital = capital;
            this.flag = flag;
        }

        public int Id { get => id; set => id = value; }
        public string Country { get => country; set => country = value; }
        public string Capital { get => capital; set => capital = value; }
        public string Flag { get => flag; set => flag = value; }
    }
}
