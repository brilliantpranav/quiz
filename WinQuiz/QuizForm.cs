using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinQuiz
{
    public partial class QuizForm : Form
    {
        struct QuestionItem
        {
            int index;
            public string question;
            public int[] choice;
            public int correctAnswer;

            public QuestionItem(string []fields)
            {
                index = int.Parse(fields[0]);
                question = fields[1];
                choice = new int[4];
                for (int i = 0; i < 4; i++)
                {
                    choice[i] =  int.Parse(fields[i + 2]);
                }
                correctAnswer = int.Parse(fields[6]);
            }
        }

        TopicSelectionForm TSForm = null;
        int quizType = 0;
        int currentQuestion = 0;
        int maxQuestions = 0;
        List<QuestionItem> QuestionsDB = new List<QuestionItem>();
        public QuizForm(TopicSelectionForm topForm)
        {
            TSForm = topForm;
            InitializeComponent();
        }

        public void SetupQuizType(int type)
        {
            quizType = type;
            switch(quizType)
            {
                case 0: 
                    this.Text = " Science Quiz";
                    break;
                case 1:
                    this.Text = " Maths Quiz";
                    break;
                case 2:
                    this.Text = " Geography Quiz";
                    break;
            }
            string dbFileName = "../db/" + quizType + ".csv";
            using (Stream fileStream = File.Open(dbFileName, FileMode.Open))
            using (StreamReader reader = new StreamReader(fileStream))
            {
                string line = null;
                int count = 0;
                do
                {
                    line = reader.ReadLine();
                    count++;
                    if (line == null) break;
                    if (count == 1) continue;
                    string[] fields = line.Split(',');
                    QuestionsDB.Add(new QuestionItem(fields));
                }
                while (line != null);
            }
            currentQuestion = 0;
            maxQuestions = QuestionsDB.Count;
            SetQuestion(currentQuestion);
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            TSForm.Show();
        }
        private void SetQuestion(int i)
        {
            QuestionLabel.Text = QuestionsDB[i].question;
            ChoiceRB1.Text = QuestionsDB[i].choice[0].ToString();
            ChoiceRB2.Text = QuestionsDB[i].choice[1].ToString();
            ChoiceRB3.Text = QuestionsDB[i].choice[2].ToString();
            ChoiceRB4.Text = QuestionsDB[i].choice[3].ToString();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            currentQuestion++;
            if (currentQuestion >= maxQuestions)
            {
                currentQuestion = maxQuestions - 1;
            }
            SetQuestion(currentQuestion);

        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            if (currentQuestion > 0)
            {
                currentQuestion--;
                SetQuestion(currentQuestion);
            }
        }
    }
}
