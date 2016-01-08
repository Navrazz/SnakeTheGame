namespace SnakeTheGame
{
    partial class FormControls
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
            this.labelControlsTitle = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelOptions = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelControlsTitle
            // 
            this.labelControlsTitle.AutoSize = true;
            this.labelControlsTitle.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelControlsTitle.Location = new System.Drawing.Point(169, 9);
            this.labelControlsTitle.Name = "labelControlsTitle";
            this.labelControlsTitle.Size = new System.Drawing.Size(146, 34);
            this.labelControlsTitle.TabIndex = 0;
            this.labelControlsTitle.Text = "Sterowanie:\r\n";
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClose.Location = new System.Drawing.Point(186, 210);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(113, 54);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Zamknij!";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelOptions
            // 
            this.labelOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOptions.Location = new System.Drawing.Point(64, 75);
            this.labelOptions.Name = "labelOptions";
            this.labelOptions.Size = new System.Drawing.Size(128, 132);
            this.labelOptions.TabIndex = 2;
            this.labelOptions.Text = "Poruszanie:\r\n\r\nRestart Gry:\r\n\r\n\r\n";
            // 
            // labelDescription
            // 
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDescription.Location = new System.Drawing.Point(198, 75);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(259, 132);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "WSAD lub strzałki kierunkowe\r\n\r\nESC\r\n\r\n\r\n";
            // 
            // Controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 278);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelOptions);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelControlsTitle);
            this.Name = "Controls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sterowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelControlsTitle;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelOptions;
        private System.Windows.Forms.Label labelDescription;
    }
}