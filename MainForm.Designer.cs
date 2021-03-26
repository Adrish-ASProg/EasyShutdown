namespace Shutdown
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimeDay = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioAtTime = new System.Windows.Forms.RadioButton();
            this.radioAfterPeriod = new System.Windows.Forms.RadioButton();
            this.buttonOk = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCancelShutdown = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimeHour = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioShutdown = new System.Windows.Forms.RadioButton();
            this.radioHibern = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.menu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimeDay
            // 
            this.dateTimeDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDay.Location = new System.Drawing.Point(25, 141);
            this.dateTimeDay.MinDate = new System.DateTime(2021, 3, 26, 0, 0, 0, 0);
            this.dateTimeDay.Name = "dateTimeDay";
            this.dateTimeDay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimeDay.Size = new System.Drawing.Size(150, 30);
            this.dateTimeDay.TabIndex = 1;
            this.dateTimeDay.Value = new System.DateTime(2021, 3, 26, 0, 0, 0, 0);
            this.dateTimeDay.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioAfterPeriod);
            this.groupBox2.Controls.Add(this.radioAtTime);
            this.groupBox2.Location = new System.Drawing.Point(10, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 50);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // radioAtTime
            // 
            this.radioAtTime.AutoSize = true;
            this.radioAtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAtTime.Location = new System.Drawing.Point(197, 15);
            this.radioAtTime.Name = "radioAtTime";
            this.radioAtTime.Size = new System.Drawing.Size(140, 21);
            this.radioAtTime.TabIndex = 1;
            this.radioAtTime.Text = "A la date indiquée";
            this.radioAtTime.UseVisualStyleBackColor = true;
            // 
            // radioAfterPeriod
            // 
            this.radioAfterPeriod.AutoSize = true;
            this.radioAfterPeriod.Checked = true;
            this.radioAfterPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAfterPeriod.Location = new System.Drawing.Point(11, 15);
            this.radioAfterPeriod.Name = "radioAfterPeriod";
            this.radioAfterPeriod.Size = new System.Drawing.Size(170, 21);
            this.radioAfterPeriod.TabIndex = 0;
            this.radioAfterPeriod.TabStop = true;
            this.radioAfterPeriod.Text = "Après le temps indiqué";
            this.radioAfterPeriod.UseVisualStyleBackColor = true;
            this.radioAfterPeriod.CheckedChanged += new System.EventHandler(this.radioAfterPeriod_CheckedChanged);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(127, 184);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(0);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(128, 24);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "Valider";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile,
            this.menuItemAbout});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(384, 24);
            this.menu.TabIndex = 4;
            this.menu.Text = "menuStrip1";
            // 
            // menuItemFile
            // 
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCancelShutdown,
            this.toolStripSeparator1,
            this.menuItemQuit});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(54, 20);
            this.menuItemFile.Text = "Fichier";
            // 
            // menuItemCancelShutdown
            // 
            this.menuItemCancelShutdown.Name = "menuItemCancelShutdown";
            this.menuItemCancelShutdown.Size = new System.Drawing.Size(226, 22);
            this.menuItemCancelShutdown.Text = "Annuler une programmation";
            this.menuItemCancelShutdown.Click += new System.EventHandler(this.menuItemCancelShutdown_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(223, 6);
            // 
            // menuItemQuit
            // 
            this.menuItemQuit.Name = "menuItemQuit";
            this.menuItemQuit.Size = new System.Drawing.Size(226, 22);
            this.menuItemQuit.Text = "Quitter";
            this.menuItemQuit.Click += new System.EventHandler(this.menuItemQuit_Click);
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Name = "menuItemAbout";
            this.menuItemAbout.Size = new System.Drawing.Size(24, 20);
            this.menuItemAbout.Text = "?";
            this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
            // 
            // dateTimeHour
            // 
            this.dateTimeHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeHour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeHour.Location = new System.Drawing.Point(122, 141);
            this.dateTimeHour.MinDate = new System.DateTime(2018, 3, 2, 0, 0, 0, 0);
            this.dateTimeHour.Name = "dateTimeHour";
            this.dateTimeHour.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimeHour.ShowUpDown = true;
            this.dateTimeHour.Size = new System.Drawing.Size(138, 30);
            this.dateTimeHour.TabIndex = 5;
            this.dateTimeHour.Value = new System.DateTime(2018, 3, 2, 1, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioShutdown);
            this.groupBox1.Controls.Add(this.radioHibern);
            this.groupBox1.Location = new System.Drawing.Point(10, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 50);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // radioShutdown
            // 
            this.radioShutdown.AutoSize = true;
            this.radioShutdown.Checked = true;
            this.radioShutdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioShutdown.Location = new System.Drawing.Point(40, 15);
            this.radioShutdown.Name = "radioShutdown";
            this.radioShutdown.Size = new System.Drawing.Size(86, 21);
            this.radioShutdown.TabIndex = 1;
            this.radioShutdown.TabStop = true;
            this.radioShutdown.Text = "Extinction";
            this.radioShutdown.UseVisualStyleBackColor = true;
            // 
            // radioHibern
            // 
            this.radioHibern.AutoSize = true;
            this.radioHibern.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioHibern.Location = new System.Drawing.Point(197, 15);
            this.radioHibern.Name = "radioHibern";
            this.radioHibern.Size = new System.Drawing.Size(128, 21);
            this.radioHibern.TabIndex = 0;
            this.radioHibern.Text = "Veille prolongée";
            this.radioHibern.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 216);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimeHour);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dateTimeDay);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programmer l\'arrêt";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimeDay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioAtTime;
        private System.Windows.Forms.RadioButton radioAfterPeriod;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuItemFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemCancelShutdown;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemQuit;
        private System.Windows.Forms.ToolStripMenuItem menuItemAbout;
        private System.Windows.Forms.DateTimePicker dateTimeHour;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioShutdown;
        private System.Windows.Forms.RadioButton radioHibern;
    }
}

