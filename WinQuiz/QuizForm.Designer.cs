namespace WinQuiz
{
    partial class QuizForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizForm));
            this.BackButton = new System.Windows.Forms.Button();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.ChoiceRB1 = new System.Windows.Forms.RadioButton();
            this.ChoiceRB2 = new System.Windows.Forms.RadioButton();
            this.ChoiceRB3 = new System.Windows.Forms.RadioButton();
            this.ChoiceRB4 = new System.Windows.Forms.RadioButton();
            this.PrevButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackButton.BackgroundImage")));
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackButton.Location = new System.Drawing.Point(727, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(61, 57);
            this.BackButton.TabIndex = 4;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Location = new System.Drawing.Point(65, 84);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(31, 13);
            this.QuestionLabel.TabIndex = 5;
            this.QuestionLabel.Text = "1+1?";
            // 
            // ChoiceRB1
            // 
            this.ChoiceRB1.AutoSize = true;
            this.ChoiceRB1.Location = new System.Drawing.Point(96, 183);
            this.ChoiceRB1.Name = "ChoiceRB1";
            this.ChoiceRB1.Size = new System.Drawing.Size(63, 17);
            this.ChoiceRB1.TabIndex = 6;
            this.ChoiceRB1.TabStop = true;
            this.ChoiceRB1.Text = "option 1";
            this.ChoiceRB1.UseVisualStyleBackColor = true;
            // 
            // ChoiceRB2
            // 
            this.ChoiceRB2.AutoSize = true;
            this.ChoiceRB2.Location = new System.Drawing.Point(242, 183);
            this.ChoiceRB2.Name = "ChoiceRB2";
            this.ChoiceRB2.Size = new System.Drawing.Size(63, 17);
            this.ChoiceRB2.TabIndex = 7;
            this.ChoiceRB2.TabStop = true;
            this.ChoiceRB2.Text = "option 2";
            this.ChoiceRB2.UseVisualStyleBackColor = true;
            // 
            // ChoiceRB3
            // 
            this.ChoiceRB3.AutoSize = true;
            this.ChoiceRB3.Location = new System.Drawing.Point(388, 183);
            this.ChoiceRB3.Name = "ChoiceRB3";
            this.ChoiceRB3.Size = new System.Drawing.Size(63, 17);
            this.ChoiceRB3.TabIndex = 8;
            this.ChoiceRB3.TabStop = true;
            this.ChoiceRB3.Text = "option 3";
            this.ChoiceRB3.UseVisualStyleBackColor = true;
            // 
            // ChoiceRB4
            // 
            this.ChoiceRB4.AutoSize = true;
            this.ChoiceRB4.Location = new System.Drawing.Point(534, 183);
            this.ChoiceRB4.Name = "ChoiceRB4";
            this.ChoiceRB4.Size = new System.Drawing.Size(63, 17);
            this.ChoiceRB4.TabIndex = 9;
            this.ChoiceRB4.TabStop = true;
            this.ChoiceRB4.Text = "option 4";
            this.ChoiceRB4.UseVisualStyleBackColor = true;
            // 
            // PrevButton
            // 
            this.PrevButton.Location = new System.Drawing.Point(51, 357);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(119, 71);
            this.PrevButton.TabIndex = 10;
            this.PrevButton.Text = "Previous";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(599, 362);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(116, 65);
            this.NextButton.TabIndex = 11;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PrevButton);
            this.Controls.Add(this.ChoiceRB4);
            this.Controls.Add(this.ChoiceRB3);
            this.Controls.Add(this.ChoiceRB2);
            this.Controls.Add(this.ChoiceRB1);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.BackButton);
            this.Name = "QuizForm";
            this.Text = "Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.RadioButton ChoiceRB1;
        private System.Windows.Forms.RadioButton ChoiceRB2;
        private System.Windows.Forms.RadioButton ChoiceRB3;
        private System.Windows.Forms.RadioButton ChoiceRB4;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Button NextButton;
    }
}