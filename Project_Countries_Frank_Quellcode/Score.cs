using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Countries_Frank
{
    public partial class Score : Form
    {
        private List<Player> ListScore;
        private DB db = new DB();

        public Score()
        {
            InitializeComponent();
            Show_Score();
        }

        public void Show_Score()
        {
            ListScore = db.Get_all_players();
            dgv_score.Rows.Clear();

            foreach (Player p in ListScore)
            {   
                if(p.Score != -1)
                {
                    dgv_score.Rows.Add(p.Name, p.Score);
                }                                           
            }
        }
    }
}
