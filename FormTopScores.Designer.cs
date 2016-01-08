namespace SnakeTheGame
{
    partial class FormTopScores
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelFirstPlace = new System.Windows.Forms.Label();
            this.labelSecondPlace = new System.Windows.Forms.Label();
            this.labelThirdPlace = new System.Windows.Forms.Label();
            this.labelFourthPlace = new System.Windows.Forms.Label();
            this.labelFifthPlace = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(67, 19);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(208, 23);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "TOP 5 najlepszych graczy:\r\n";
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClose.Location = new System.Drawing.Point(90, 216);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(150, 83);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "Zamknij!";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelFirstPlace
            // 
            this.labelFirstPlace.AutoSize = true;
            this.labelFirstPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFirstPlace.Location = new System.Drawing.Point(125, 53);
            this.labelFirstPlace.Name = "labelFirstPlace";
            this.labelFirstPlace.Size = new System.Drawing.Size(75, 20);
            this.labelFirstPlace.TabIndex = 7;
            this.labelFirstPlace.Text = "Miejsce 1";
            // 
            // labelSecondPlace
            // 
            this.labelSecondPlace.AutoSize = true;
            this.labelSecondPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSecondPlace.Location = new System.Drawing.Point(125, 83);
            this.labelSecondPlace.Name = "labelSecondPlace";
            this.labelSecondPlace.Size = new System.Drawing.Size(75, 20);
            this.labelSecondPlace.TabIndex = 8;
            this.labelSecondPlace.Text = "Miejsce 2";
            // 
            // labelThirdPlace
            // 
            this.labelThirdPlace.AutoSize = true;
            this.labelThirdPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelThirdPlace.Location = new System.Drawing.Point(125, 113);
            this.labelThirdPlace.Name = "labelThirdPlace";
            this.labelThirdPlace.Size = new System.Drawing.Size(75, 20);
            this.labelThirdPlace.TabIndex = 9;
            this.labelThirdPlace.Text = "Miejsce 3";
            // 
            // labelFourthPlace
            // 
            this.labelFourthPlace.AutoSize = true;
            this.labelFourthPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFourthPlace.Location = new System.Drawing.Point(125, 143);
            this.labelFourthPlace.Name = "labelFourthPlace";
            this.labelFourthPlace.Size = new System.Drawing.Size(75, 20);
            this.labelFourthPlace.TabIndex = 9;
            this.labelFourthPlace.Text = "Miejsce 4";
            // 
            // labelFifthPlace
            // 
            this.labelFifthPlace.AutoSize = true;
            this.labelFifthPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFifthPlace.Location = new System.Drawing.Point(125, 173);
            this.labelFifthPlace.Name = "labelFifthPlace";
            this.labelFifthPlace.Size = new System.Drawing.Size(75, 20);
            this.labelFifthPlace.TabIndex = 9;
            this.labelFifthPlace.Text = "Miejsce 5";
            // 
            // FormTopScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 311);
            this.ControlBox = false;
            this.Controls.Add(this.labelFifthPlace);
            this.Controls.Add(this.labelFourthPlace);
            this.Controls.Add(this.labelThirdPlace);
            this.Controls.Add(this.labelSecondPlace);
            this.Controls.Add(this.labelFirstPlace);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormTopScores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Najlepsze wyniki";
            this.Load += new System.EventHandler(this.TopScores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelFirstPlace;
        private System.Windows.Forms.Label labelSecondPlace;
        private System.Windows.Forms.Label labelThirdPlace;
        private System.Windows.Forms.Label labelFourthPlace;
        private System.Windows.Forms.Label labelFifthPlace;
    }
}