namespace SnakeTheGame
{
    partial class FormGameOver
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelYourScore = new System.Windows.Forms.Label();
            this.labelShowScore = new System.Windows.Forms.Label();
            this.buttonSaveAndClose = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(187, 29);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(143, 34);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Game Over!";
            // 
            // labelYourScore
            // 
            this.labelYourScore.AutoSize = true;
            this.labelYourScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelYourScore.Location = new System.Drawing.Point(161, 95);
            this.labelYourScore.Name = "labelYourScore";
            this.labelYourScore.Size = new System.Drawing.Size(105, 20);
            this.labelYourScore.TabIndex = 1;
            this.labelYourScore.Text = "Twój wynik to:";
            // 
            // labelShowScore
            // 
            this.labelShowScore.AutoSize = true;
            this.labelShowScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelShowScore.Location = new System.Drawing.Point(312, 95);
            this.labelShowScore.Name = "labelShowScore";
            this.labelShowScore.Size = new System.Drawing.Size(18, 20);
            this.labelShowScore.TabIndex = 2;
            this.labelShowScore.Text = "0";
            // 
            // buttonSaveAndClose
            // 
            this.buttonSaveAndClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSaveAndClose.Location = new System.Drawing.Point(180, 196);
            this.buttonSaveAndClose.Name = "buttonSaveAndClose";
            this.buttonSaveAndClose.Size = new System.Drawing.Size(150, 83);
            this.buttonSaveAndClose.TabIndex = 5;
            this.buttonSaveAndClose.Text = "Zapisz i zamknij!";
            this.buttonSaveAndClose.UseVisualStyleBackColor = true;
            this.buttonSaveAndClose.Click += new System.EventHandler(this.buttonSaveAndClose_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(137, 141);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(129, 20);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Podaj swoje imię:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(291, 143);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(103, 20);
            this.textBoxName.TabIndex = 7;
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 291);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonSaveAndClose);
            this.Controls.Add(this.labelShowScore);
            this.Controls.Add(this.labelYourScore);
            this.Controls.Add(this.labelTitle);
            this.Name = "GameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Over";
            this.Load += new System.EventHandler(this.GameOver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelYourScore;
        private System.Windows.Forms.Label labelShowScore;
        private System.Windows.Forms.Button buttonSaveAndClose;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
    }
}