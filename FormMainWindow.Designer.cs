namespace SnakeTheGame
{
    partial class FormMainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainWindow));
            this.pictureBoxGameBoard = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelTitleScore = new System.Windows.Forms.Label();
            this.labelScoreShow = new System.Windows.Forms.Label();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.menuStripOptions = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjścieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemControls = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTopTen = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTopScoreShow = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPressEnter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameBoard)).BeginInit();
            this.menuStripOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxGameBoard
            // 
            this.pictureBoxGameBoard.BackColor = System.Drawing.Color.Green;
            this.pictureBoxGameBoard.Location = new System.Drawing.Point(70, 109);
            this.pictureBoxGameBoard.Name = "pictureBoxGameBoard";
            this.pictureBoxGameBoard.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxGameBoard.TabIndex = 0;
            this.pictureBoxGameBoard.TabStop = false;
            this.pictureBoxGameBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxGameBoard_Paint);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(229, 24);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(283, 45);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Snake The Game";
            // 
            // labelTitleScore
            // 
            this.labelTitleScore.AutoSize = true;
            this.labelTitleScore.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitleScore.Location = new System.Drawing.Point(617, 109);
            this.labelTitleScore.Name = "labelTitleScore";
            this.labelTitleScore.Size = new System.Drawing.Size(142, 26);
            this.labelTitleScore.TabIndex = 2;
            this.labelTitleScore.Text = "Bierzący wynik:";
            // 
            // labelScoreShow
            // 
            this.labelScoreShow.AutoSize = true;
            this.labelScoreShow.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelScoreShow.Location = new System.Drawing.Point(617, 155);
            this.labelScoreShow.Name = "labelScoreShow";
            this.labelScoreShow.Size = new System.Drawing.Size(23, 26);
            this.labelScoreShow.TabIndex = 2;
            this.labelScoreShow.Text = "0";
            // 
            // menuStripOptions
            // 
            this.menuStripOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemHelp});
            this.menuStripOptions.Location = new System.Drawing.Point(0, 0);
            this.menuStripOptions.Name = "menuStripOptions";
            this.menuStripOptions.Size = new System.Drawing.Size(823, 24);
            this.menuStripOptions.TabIndex = 3;
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemNewGame,
            this.toolStripMenuItemRestart,
            this.wyjścieToolStripMenuItem});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(38, 20);
            this.toolStripMenuItemFile.Text = "Plik";
            // 
            // toolStripMenuItemNewGame
            // 
            this.toolStripMenuItemNewGame.Name = "toolStripMenuItemNewGame";
            this.toolStripMenuItemNewGame.Size = new System.Drawing.Size(126, 22);
            this.toolStripMenuItemNewGame.Text = "Nowa Gra";
            this.toolStripMenuItemNewGame.Click += new System.EventHandler(this.toolStripMenuItemNewGame_Click);
            // 
            // toolStripMenuItemRestart
            // 
            this.toolStripMenuItemRestart.Name = "toolStripMenuItemRestart";
            this.toolStripMenuItemRestart.Size = new System.Drawing.Size(126, 22);
            this.toolStripMenuItemRestart.Text = "Restart";
            this.toolStripMenuItemRestart.Click += new System.EventHandler(this.toolStripMenuItemRestart_Click);
            // 
            // wyjścieToolStripMenuItem
            // 
            this.wyjścieToolStripMenuItem.Name = "wyjścieToolStripMenuItem";
            this.wyjścieToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.wyjścieToolStripMenuItem.Text = "Wyjście";
            this.wyjścieToolStripMenuItem.Click += new System.EventHandler(this.wyjścieToolStripMenuItem_Click);
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemControls,
            this.toolStripMenuItemTopTen});
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(57, 20);
            this.toolStripMenuItemHelp.Text = "Pomoc";
            // 
            // toolStripMenuItemControls
            // 
            this.toolStripMenuItemControls.Name = "toolStripMenuItemControls";
            this.toolStripMenuItemControls.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItemControls.Text = "Sterowanie";
            this.toolStripMenuItemControls.Click += new System.EventHandler(this.toolStripMenuItemControls_Click);
            // 
            // toolStripMenuItemTopTen
            // 
            this.toolStripMenuItemTopTen.Name = "toolStripMenuItemTopTen";
            this.toolStripMenuItemTopTen.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItemTopTen.Text = "Najlepsze wyniki";
            this.toolStripMenuItemTopTen.Click += new System.EventHandler(this.toolStripMenuItemTopTen_Click);
            // 
            // labelTopScoreShow
            // 
            this.labelTopScoreShow.AutoSize = true;
            this.labelTopScoreShow.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTopScoreShow.Location = new System.Drawing.Point(617, 289);
            this.labelTopScoreShow.Name = "labelTopScoreShow";
            this.labelTopScoreShow.Size = new System.Drawing.Size(23, 25);
            this.labelTopScoreShow.TabIndex = 4;
            this.labelTopScoreShow.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(617, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Najlepszy wynik:";
            // 
            // labelPressEnter
            // 
            this.labelPressEnter.AutoSize = true;
            this.labelPressEnter.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPressEnter.ForeColor = System.Drawing.Color.Red;
            this.labelPressEnter.Location = new System.Drawing.Point(192, 341);
            this.labelPressEnter.Name = "labelPressEnter";
            this.labelPressEnter.Size = new System.Drawing.Size(262, 36);
            this.labelPressEnter.TabIndex = 6;
            this.labelPressEnter.Text = ">>>Wciśnij Enter<<<";
            this.labelPressEnter.Visible = false;
            // 
            // FormMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(823, 652);
            this.Controls.Add(this.labelPressEnter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTopScoreShow);
            this.Controls.Add(this.labelScoreShow);
            this.Controls.Add(this.labelTitleScore);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBoxGameBoard);
            this.Controls.Add(this.menuStripOptions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStripOptions;
            this.Name = "FormMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake The Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMainWindow_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormMainWindow_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameBoard)).EndInit();
            this.menuStripOptions.ResumeLayout(false);
            this.menuStripOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGameBoard;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelTitleScore;
        private System.Windows.Forms.Label labelScoreShow;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.MenuStrip menuStripOptions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNewGame;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRestart;
        private System.Windows.Forms.ToolStripMenuItem wyjścieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemControls;
        private System.Windows.Forms.Label labelTopScoreShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPressEnter;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTopTen;
    }
}

