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
    public partial class Form1 : Form
    {
        private DB db = new DB();

        private List<Player> listPlayers;
        PictureBox game_type = null;
        string player_name;

        public Form1()
        {
            InitializeComponent();
            get_players_names();
        }

        private void start_Click(object sender, EventArgs e)
        {
            start.BorderStyle = BorderStyle.Fixed3D;

            if (textBox_name.Text != "" && game_type != null || comboBox_playes.SelectedIndex != -1 && game_type != null)
            {                              
                Quiz_Form2 f2 = new Quiz_Form2(game_type.Name, player_name);                
                f2.ShowDialog();
                empty_form1();
            }
            else
            {
                start.BorderStyle = BorderStyle.FixedSingle;
            }                       
        }

        private void empty_form1()
        {
            start.BorderStyle = BorderStyle.FixedSingle;
            game_type.BorderStyle = BorderStyle.FixedSingle;
            comboBox_playes.SelectedIndex = -1;
            textBox_name.Text = "";
            label_name.Text = "";
            label_Welcome.Text = "Welcome!";
        }
        private void select_game_form_click(object sender, EventArgs e)
        {
            game_type = sender as PictureBox;
            game_type.BorderStyle = BorderStyle.Fixed3D;
        }

        private void button_registration_Click(object sender, EventArgs e)
        {
            button_registration.BorderStyle = BorderStyle.Fixed3D;
            comboBox_playes.SelectedIndex = -1;

            int control = db.Name_registration_control(textBox_name.Text);
            if(control == 0)
            {
                db.Insert_Player_Name_Into_DB(textBox_name.Text);
                player_name = textBox_name.Text;

                label_name.Text = player_name;
                label_Welcome.Text = "Welcome!";
                get_players_names();
            }
            else
            {
                MessageBox.Show("This name is already used.");               

            }

            button_registration.BorderStyle = BorderStyle.None;
            
        }

        private void get_players_names()
        {
            listPlayers = db.Get_all_players();

            comboBox_playes.Items.Clear();

            foreach(Player p in listPlayers)
            {
                comboBox_playes.Items.Add(p.Name);
            }
        }

        private void comboBox_playes_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox_playes.SelectedIndex != -1)
            {
                player_name = comboBox_playes.SelectedItem.ToString();
                label_name.Text = player_name;
                label_Welcome.Text = "Welcome back!";
            }
                         
        }

        private void score_Click(object sender, EventArgs e)
        {
            button_score.BorderStyle = BorderStyle.Fixed3D;

            Score s = new Score();
            s.ShowDialog();

            button_score.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
