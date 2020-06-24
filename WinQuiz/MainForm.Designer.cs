namespace WinQuiz
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainFormPlayButton = new System.Windows.Forms.Button();
            this.MainFormQuitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainFormPlayButton
            // 
            this.MainFormPlayButton.Location = new System.Drawing.Point(85, 357);
            this.MainFormPlayButton.Name = "MainFormPlayButton";
            this.MainFormPlayButton.Size = new System.Drawing.Size(228, 87);
            this.MainFormPlayButton.TabIndex = 0;
            this.MainFormPlayButton.Text = "Play Quiz";
            this.MainFormPlayButton.UseVisualStyleBackColor = true;
            this.MainFormPlayButton.Click += new System.EventHandler(this.MainFormPlayButton_Click);
            // 
            // MainFormQuitButton
            // 
            this.MainFormQuitButton.Location = new System.Drawing.Point(382, 364);
            this.MainFormQuitButton.Name = "MainFormQuitButton";
            this.MainFormQuitButton.Size = new System.Drawing.Size(239, 79);
            this.MainFormQuitButton.TabIndex = 1;
            this.MainFormQuitButton.Text = "Quit";
            this.MainFormQuitButton.UseVisualStyleBackColor = true;
            this.MainFormQuitButton.Click += new System.EventHandler(this.MainFormQuitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainFormQuitButton);
            this.Controls.Add(this.MainFormPlayButton);
            this.Name = "MainForm";
            this.Text = "Quiz Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MainFormPlayButton;
        private System.Windows.Forms.Button MainFormQuitButton;
    }
}

