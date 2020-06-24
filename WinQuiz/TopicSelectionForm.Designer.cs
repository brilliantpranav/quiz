namespace WinQuiz
{
    partial class TopicSelectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopicSelectionForm));
            this.TSFormSciButton = new System.Windows.Forms.Button();
            this.TSFormMathsButton = new System.Windows.Forms.Button();
            this.TSFormGeoButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TSFormSciButton
            // 
            this.TSFormSciButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TSFormSciButton.BackgroundImage")));
            this.TSFormSciButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TSFormSciButton.Location = new System.Drawing.Point(57, 129);
            this.TSFormSciButton.Name = "TSFormSciButton";
            this.TSFormSciButton.Size = new System.Drawing.Size(140, 172);
            this.TSFormSciButton.TabIndex = 0;
            this.TSFormSciButton.UseVisualStyleBackColor = true;
            this.TSFormSciButton.Click += new System.EventHandler(this.TSFormSciButton_Click);
            // 
            // TSFormMathsButton
            // 
            this.TSFormMathsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TSFormMathsButton.BackgroundImage")));
            this.TSFormMathsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TSFormMathsButton.Location = new System.Drawing.Point(340, 129);
            this.TSFormMathsButton.Name = "TSFormMathsButton";
            this.TSFormMathsButton.Size = new System.Drawing.Size(140, 172);
            this.TSFormMathsButton.TabIndex = 1;
            this.TSFormMathsButton.UseVisualStyleBackColor = true;
            this.TSFormMathsButton.Click += new System.EventHandler(this.TSFormMathsButton_Click);
            // 
            // TSFormGeoButton
            // 
            this.TSFormGeoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TSFormGeoButton.BackgroundImage")));
            this.TSFormGeoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TSFormGeoButton.Location = new System.Drawing.Point(601, 129);
            this.TSFormGeoButton.Name = "TSFormGeoButton";
            this.TSFormGeoButton.Size = new System.Drawing.Size(140, 172);
            this.TSFormGeoButton.TabIndex = 2;
            this.TSFormGeoButton.UseVisualStyleBackColor = true;
            this.TSFormGeoButton.Click += new System.EventHandler(this.TSFormGeoButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackButton.BackgroundImage")));
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackButton.Location = new System.Drawing.Point(740, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(61, 57);
            this.BackButton.TabIndex = 3;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // TopicSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.TSFormGeoButton);
            this.Controls.Add(this.TSFormMathsButton);
            this.Controls.Add(this.TSFormSciButton);
            this.Name = "TopicSelectionForm";
            this.Text = "TopicSelectionForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TSFormSciButton;
        private System.Windows.Forms.Button TSFormMathsButton;
        private System.Windows.Forms.Button TSFormGeoButton;
        private System.Windows.Forms.Button BackButton;
    }
}