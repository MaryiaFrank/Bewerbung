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
    public partial class Quiz_Form2 : Form
    {
        Random random = new Random();
        private DB db = new DB();
        private List<Quiz> ListQuiz;

        int questionNr = 10; //how many questions there are
        static int how_many_id = 15; //how many id in db --> How_many_id()

        int[] questions = new int[how_many_id];       
        int[] answer_options = new int[4];

        string right_answer;
        int score = 0;

        string game_type;
        string player_name;

        public Quiz_Form2(string game_type, string player_name)
        {
            this.game_type = game_type;
            this.player_name = player_name;

            InitializeComponent();

            ListQuiz = db.Get_all_from_quiz();

            How_many_id();
            Fill_qustions_array();
                     
            Show_questions(game_type);

        }
        private void Show_questions(string game_type)
        {
            if(questionNr > 0)
            {
                if (game_type == "countries")
                {
                    Quiz q = ListQuiz.Find(x => x.Id == questions[questionNr]);
                    label_Countrie_Capital.Text = q.Capital; //the question is shown

                    right_answer = q.Country; //note the right answer

                    answer_options[0] = q.Id; // insert the right answer into answer_options
                    Fill_answer_options();

                    //Show answer options
                    Quiz a = ListQuiz.Find(x => x.Id == answer_options[0]);
                    button1.Text = a.Country;
                    a = ListQuiz.Find(x => x.Id == answer_options[1]);
                    button2.Text = a.Country;
                    a = ListQuiz.Find(x => x.Id == answer_options[2]);
                    button3.Text = a.Country;
                    a = ListQuiz.Find(x => x.Id == answer_options[3]);
                    button4.Text = a.Country;
                }

                else if (game_type == "capitals")
                {
                    Quiz q = ListQuiz.Find(x => x.Id == questions[questionNr]);
                    label_Countrie_Capital.Text = q.Country; 

                    right_answer = q.Capital; 

                    answer_options[0] = q.Id;
                    Fill_answer_options();
                   
                    Quiz a = ListQuiz.Find(x => x.Id == answer_options[0]);
                    button1.Text = a.Capital;
                    a = ListQuiz.Find(x => x.Id == answer_options[1]);
                    button2.Text = a.Capital;
                    a = ListQuiz.Find(x => x.Id == answer_options[2]);
                    button3.Text = a.Capital;
                    a = ListQuiz.Find(x => x.Id == answer_options[3]);
                    button4.Text = a.Capital;
                }

                else if (game_type == "flags")
                {
                    Quiz q = ListQuiz.Find(x => x.Id == questions[questionNr]);
                    label_Countrie_Capital.Text = q.Country;

                    right_answer = q.Flag;

                    answer_options[0] = q.Id;
                    Fill_answer_options();

                    Quiz a = ListQuiz.Find(x => x.Id == answer_options[0]);
                    button1.Name = a.Flag;
                    button1.BackgroundImage = Image.FromFile(a.Flag);
                    a = ListQuiz.Find(x => x.Id == answer_options[1]);
                    button2.Name = a.Flag;
                    button2.BackgroundImage = Image.FromFile(a.Flag);
                    a = ListQuiz.Find(x => x.Id == answer_options[2]);
                    button3.Name = a.Flag;
                    button3.BackgroundImage = Image.FromFile(a.Flag);
                    a = ListQuiz.Find(x => x.Id == answer_options[3]);
                    button4.Name = a.Flag;
                    button4.BackgroundImage = Image.FromFile(a.Flag);
                }

            }
            else //Game is over -> show Score, if new score > old score -> insert new score into DB
            {
                MessageBox.Show("The Quiz is over. Your score is " + score + "/10");

                int old_score = db.Score_Control(player_name);
                if (score > old_score)
                {
                    db.Insert_Score(score, player_name);
                }              
            }
                                
        }
        private void Answer_option_selected(object sender, EventArgs e) //check if answer right or wrong, questionNR--, call 'show_questions'
        {
            Button answer_check = sender as Button;

            if (answer_check.Text == right_answer || answer_check.Name == right_answer)
            {
                MessageBox.Show("This is the right answer!");
                score++;
                label_score.Text = score.ToString();
            }
            else
            {
                MessageBox.Show("The answer is unfortunately wrong");
            }

            questionNr--;
            Show_questions(game_type);

        }
        private void How_many_id() // count(country_id) and insert into int 'how_many_id';
        {
            how_many_id = db.Get_how_many_id();
        }
        private void Fill_qustions_array() // to make array 'questions' flexible, we checked how many countries is in DB and filled the array;
        {
            for (int i = 0; i < how_many_id; i++)
            {
                questions[i] = i+1;                
            }
            Shuffle_qustions();
        }
        private void Shuffle_qustions()
        {
            for (int i = questions.Length - 1; i > 0; i--)
            {
                int randomIndex = random.Next(0, i + 1);

                int temp = questions[i];
                questions[i] = questions[randomIndex];
                questions[randomIndex] = temp;
            }
        } 
        private void Fill_answer_options() // we put the id of the right answer into array[0] and 3 random and unique id into array[1-3]
        {
            for (int i = 1; i < 4; i++)
            {
                bool control = false;

                while (!control)
                {
                    int randomIndex = random.Next(0, questions.Length);
                    if (answer_options[0] != questions[randomIndex] && answer_options[1] != questions[randomIndex] 
                        && answer_options[2] != questions[randomIndex] && answer_options[3] != questions[randomIndex])
                    {
                        answer_options[i] = questions[randomIndex];
                        control = true;
                    }
                }
            }
            Shuffle_answer_options();
        }
        private void Shuffle_answer_options()
        {
            for (int i = answer_options.Length - 1; i > 0; i--)
            {
                int randomIndex = random.Next(0, i + 1);

                int temp = answer_options[i];
                answer_options[i] = answer_options[randomIndex];
                answer_options[randomIndex] = temp;
            }
        }
       
    }
}
