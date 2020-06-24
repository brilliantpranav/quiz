using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinQuiz
{
    public partial class TopicSelectionForm : Form
    {
        QuizForm quizForm = null;
        MainForm mainForm = null;
        public TopicSelectionForm(MainForm form)
        {
            quizForm = new QuizForm(this);
            mainForm = form;
            InitializeComponent();
        }



        private void TSFormSciButton_Click(object sender, EventArgs e)
        {
            quizForm.SetupQuizType(0);
            quizForm.Show();
            this.Hide();
        }

        private void TSFormMathsButton_Click(object sender, EventArgs e)
        {
            quizForm.SetupQuizType(1);
            quizForm.Show();
            this.Hide();
        }

        private void TSFormGeoButton_Click(object sender, EventArgs e)
        {
            quizForm.SetupQuizType(2);
            quizForm.Show();
            this.Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
        }
    }
}
