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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainFormQuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainFormPlayButton_Click(object sender, EventArgs e)
        {
            TopicSelectionForm tForm = new TopicSelectionForm(this);
            tForm.Show();
            this.Hide();
        }
    }
}
