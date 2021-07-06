using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Countries_Frank
{
    public class Player
    {
        private int id;
        private string name;
        private int score;

        public Player(int id, string name, int score)
        {
            this.id = id;
            this.name = name;
            this.score = score;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Score { get => score; set => score = value; }
    }
}
