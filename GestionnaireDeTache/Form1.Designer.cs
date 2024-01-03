namespace GestionnaireDeTache
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            Supprimer_Tache = new Button();
            Supprimer_Liste = new Button();
            button1 = new Button();
            DeleteTaskError = new Label();
            SortedList = new Button();
            SearchTask = new TextBox();
            NameSortedList = new Label();
            Github = new LinkLabel();
            Discord = new LinkLabel();
            TacheList = new CheckedListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Verdana", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(171, 18);
            label1.Name = "label1";
            label1.Size = new Size(429, 59);
            label1.TabIndex = 0;
            label1.Text = "Tache en cours";
            // 
            // Supprimer_Tache
            // 
            Supprimer_Tache.BackColor = SystemColors.ControlDarkDark;
            Supprimer_Tache.Cursor = Cursors.Hand;
            Supprimer_Tache.FlatStyle = FlatStyle.Flat;
            Supprimer_Tache.Location = new Point(831, 479);
            Supprimer_Tache.Name = "Supprimer_Tache";
            Supprimer_Tache.Size = new Size(175, 41);
            Supprimer_Tache.TabIndex = 1;
            Supprimer_Tache.Text = "Supprimer";
            Supprimer_Tache.UseVisualStyleBackColor = false;
            Supprimer_Tache.Click += Supprimer_Tache_Click;
            // 
            // Supprimer_Liste
            // 
            Supprimer_Liste.BackColor = SystemColors.ControlDarkDark;
            Supprimer_Liste.Cursor = Cursors.Hand;
            Supprimer_Liste.FlatStyle = FlatStyle.System;
            Supprimer_Liste.Location = new Point(831, 556);
            Supprimer_Liste.Name = "Supprimer_Liste";
            Supprimer_Liste.Size = new Size(175, 44);
            Supprimer_Liste.TabIndex = 2;
            Supprimer_Liste.Text = "Effacer";
            Supprimer_Liste.UseVisualStyleBackColor = false;
            Supprimer_Liste.Click += Supprimer_Liste_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(831, 394);
            button1.Name = "button1";
            button1.Size = new Size(175, 41);
            button1.TabIndex = 4;
            button1.Text = "Ajouter";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DeleteTaskError
            // 
            DeleteTaskError.AutoSize = true;
            DeleteTaskError.BackColor = Color.Transparent;
            DeleteTaskError.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteTaskError.ForeColor = Color.Red;
            DeleteTaskError.Location = new Point(831, 523);
            DeleteTaskError.Name = "DeleteTaskError";
            DeleteTaskError.Size = new Size(0, 15);
            DeleteTaskError.TabIndex = 5;
            DeleteTaskError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SortedList
            // 
            SortedList.BackColor = SystemColors.ButtonShadow;
            SortedList.Cursor = Cursors.Hand;
            SortedList.FlatStyle = FlatStyle.Popup;
            SortedList.Font = new Font("Gothamic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SortedList.Location = new Point(12, 99);
            SortedList.Name = "SortedList";
            SortedList.Size = new Size(200, 23);
            SortedList.TabIndex = 6;
            SortedList.Text = " Nom";
            SortedList.UseVisualStyleBackColor = false;
            SortedList.Click += button2_Click;
            // 
            // SearchTask
            // 
            SearchTask.Cursor = Cursors.IBeam;
            SearchTask.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchTask.ForeColor = SystemColors.ScrollBar;
            SearchTask.Location = new Point(596, 100);
            SearchTask.Name = "SearchTask";
            SearchTask.Size = new Size(209, 22);
            SearchTask.TabIndex = 7;
            SearchTask.Text = "Rechercher";
            SearchTask.TextAlign = HorizontalAlignment.Center;
            SearchTask.TextChanged += SearchTask_TextChanged;
            // 
            // NameSortedList
            // 
            NameSortedList.AutoSize = true;
            NameSortedList.BackColor = Color.Transparent;
            NameSortedList.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameSortedList.ForeColor = Color.Red;
            NameSortedList.Location = new Point(12, 82);
            NameSortedList.Name = "NameSortedList";
            NameSortedList.Size = new Size(0, 14);
            NameSortedList.TabIndex = 8;
            // 
            // Github
            // 
            Github.AutoSize = true;
            Github.BackColor = Color.Transparent;
            Github.Cursor = Cursors.Hand;
            Github.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Github.LinkColor = Color.FromArgb(192, 255, 255);
            Github.Location = new Point(979, 9);
            Github.Name = "Github";
            Github.Size = new Size(38, 14);
            Github.TabIndex = 9;
            Github.TabStop = true;
            Github.Text = "Github";
            Github.TextAlign = ContentAlignment.MiddleCenter;
            Github.LinkClicked += Github_LinkClicked;
            // 
            // Discord
            // 
            Discord.AutoSize = true;
            Discord.BackColor = Color.Transparent;
            Discord.Cursor = Cursors.Hand;
            Discord.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Discord.LinkColor = Color.FromArgb(192, 255, 255);
            Discord.Location = new Point(973, 34);
            Discord.Name = "Discord";
            Discord.Size = new Size(44, 14);
            Discord.TabIndex = 10;
            Discord.TabStop = true;
            Discord.Text = "Discord";
            Discord.TextAlign = ContentAlignment.MiddleCenter;
            Discord.LinkClicked += Discord_LinkClicked;
            // 
            // TacheList
            // 
            TacheList.BackColor = Color.FromArgb(64, 64, 64);
            TacheList.Cursor = Cursors.Hand;
            TacheList.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TacheList.ForeColor = SystemColors.InactiveCaption;
            TacheList.FormattingEnabled = true;
            TacheList.Location = new Point(12, 128);
            TacheList.Name = "TacheList";
            TacheList.Size = new Size(793, 472);
            TacheList.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1029, 630);
            Controls.Add(TacheList);
            Controls.Add(Discord);
            Controls.Add(Github);
            Controls.Add(NameSortedList);
            Controls.Add(SearchTask);
            Controls.Add(SortedList);
            Controls.Add(DeleteTaskError);
            Controls.Add(button1);
            Controls.Add(Supprimer_Liste);
            Controls.Add(Supprimer_Tache);
            Controls.Add(label1);
            Font = new Font("Gothamic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Supprimer_Tache;
        private Button Supprimer_Liste;
        private Button button1;
        private Label DeleteTaskError;
        private Button SortedList;
        private TextBox SearchTask;
        private Label NameSortedList;
        private LinkLabel Github;
        private LinkLabel Discord;
        private CheckedListBox TacheList;
    }
}
