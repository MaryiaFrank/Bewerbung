using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Countries_Frank
{
    public class DB
    {
        private MySqlConnection con;
        public DB()
        {
            string s = "SERVER = localhost; DATABASE = Project; UID = root; PASSWORD = 'ILoveAlex97';";
            con = new MySqlConnection(s);
        }
        public void OpenDB()
        {
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public int Name_registration_control(string name)
        {
            int control = 0;
            try
            {
                OpenDB();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = string.Format("SELECT COUNT(*) FROM Players where name = '{0}';", name);
                MySqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    control = reader.IsDBNull(0) ? -1 : reader.GetInt32(0);
                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return control;


        }
        public void Insert_Player_Name_Into_DB(string name)
        {
            try
            {
                OpenDB();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = string.Format("INSERT INTO players VALUES (null, '{0}', null);", name);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public int Get_how_many_id()
        {
            int id_count = 0;
            try
            {
                OpenDB();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT COUNT(country_id) FROM Quiz;";
                MySqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    id_count = reader.IsDBNull(0) ? -1 : reader.GetInt32(0);
                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return id_count;
        }
        public List<Quiz> Get_all_from_quiz()
        {
            List<Quiz> listQuiz = new List<Quiz>();

            try
            {
                OpenDB();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM Quiz";
                MySqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    listQuiz.Add(
                        new Quiz(
                            reader.IsDBNull(0) ? -1 : reader.GetInt32(0),
                            reader.IsDBNull(1) ? "" : reader.GetString(1),
                            reader.IsDBNull(2) ? "" : reader.GetString(2),
                            reader.IsDBNull(3) ? "" : reader.GetString(3)
                            )
                        );
                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return listQuiz;


        }
        public List<Player> Get_all_players()
        {
            List < Player > listPalyer = new List<Player>();

            try
            {
                OpenDB();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM players ORDER BY score DESC";
                MySqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    listPalyer.Add(
                        new Player(
                            reader.IsDBNull(0) ? -1 : reader.GetInt32(0),
                            reader.IsDBNull(1) ? "" : reader.GetString(1),
                            reader.IsDBNull(2) ? -1 : reader.GetInt32(2)
                            )
                        );
                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return listPalyer;
        }

        public int Score_Control(string name)
        {
            int old_score = -1;
            try
            {
                OpenDB();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = string.Format("SELECT score FROM players where name = '{0}'", name);
                MySqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    old_score = reader.IsDBNull(0) ? -1 : reader.GetInt32(0);
                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return old_score;

        }
        public void Insert_Score(int score, string name)
        {
            try
            {
                OpenDB();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = string.Format("UPDATE players SET score = {0} where name = '{1}';", score, name);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
