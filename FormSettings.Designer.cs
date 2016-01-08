namespace SnakeTheGame
{
    partial class FormSettings
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
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxDifficulty = new System.Windows.Forms.ComboBox();
            this.buttonSaveAndClose = new System.Windows.Forms.Button();
            this.labelDifficulty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(12, 44);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(132, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Wpisz swoje imię:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(150, 46);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(122, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // comboBoxDifficulty
            // 
            this.comboBoxDifficulty.FormattingEnabled = true;
            this.comboBoxDifficulty.Location = new System.Drawing.Point(53, 139);
            this.comboBoxDifficulty.Name = "comboBoxDifficulty";
            this.comboBoxDifficulty.Size = new System.Drawing.Size(193, 21);
            this.comboBoxDifficulty.TabIndex = 3;
            this.comboBoxDifficulty.Text = "Wybierz poziom trudności:";
            // 
            // buttonSaveAndClose
            // 
            this.buttonSaveAndClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSaveAndClose.Location = new System.Drawing.Point(69, 181);
            this.buttonSaveAndClose.Name = "buttonSaveAndClose";
            this.buttonSaveAndClose.Size = new System.Drawing.Size(150, 68);
            this.buttonSaveAndClose.TabIndex = 6;
            this.buttonSaveAndClose.Text = "Zapisz i zamknij!";
            this.buttonSaveAndClose.UseVisualStyleBackColor = true;
            this.buttonSaveAndClose.Click += new System.EventHandler(this.buttonSaveAndClose_Click);
            // 
            // labelDifficulty
            // 
            this.labelDifficulty.AutoSize = true;
            this.labelDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDifficulty.Location = new System.Drawing.Point(49, 116);
            this.labelDifficulty.Name = "labelDifficulty";
            this.labelDifficulty.Size = new System.Drawing.Size(193, 20);
            this.labelDifficulty.TabIndex = 7;
            this.labelDifficulty.Text = "Wybierz poziom trudności:";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.labelDifficulty);
            this.Controls.Add(this.buttonSaveAndClose);
            this.Controls.Add(this.comboBoxDifficulty);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ustawienia";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxDifficulty;
        private System.Windows.Forms.Button buttonSaveAndClose;
        private System.Windows.Forms.Label labelDifficulty;
    }
}