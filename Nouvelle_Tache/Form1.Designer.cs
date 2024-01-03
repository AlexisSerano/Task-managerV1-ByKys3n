namespace Nouvelle_Tache
{
    partial class New_Tache
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Tache));
            label1 = new Label();
            TaskNameText = new TextBox();
            TaskDescriptionText = new TextBox();
            ValidateNewTask = new Button();
            NameTaskError = new Label();
            DescriptionTaskError = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gothamic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(244, 35);
            label1.Name = "label1";
            label1.Size = new Size(336, 51);
            label1.TabIndex = 0;
            label1.Text = "Nouvelle Tache";
            // 
            // TaskNameText
            // 
            TaskNameText.Cursor = Cursors.IBeam;
            TaskNameText.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TaskNameText.Location = new Point(227, 163);
            TaskNameText.MaxLength = 15;
            TaskNameText.Name = "TaskNameText";
            TaskNameText.Size = new Size(377, 57);
            TaskNameText.TabIndex = 1;
            TaskNameText.Text = "Ma Tache";
            TaskNameText.TextAlign = HorizontalAlignment.Center;
            // 
            // TaskDescriptionText
            // 
            TaskDescriptionText.Cursor = Cursors.IBeam;
            TaskDescriptionText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TaskDescriptionText.Location = new Point(227, 294);
            TaskDescriptionText.MaxLength = 60;
            TaskDescriptionText.Name = "TaskDescriptionText";
            TaskDescriptionText.Size = new Size(377, 33);
            TaskDescriptionText.TabIndex = 2;
            TaskDescriptionText.Text = "Ma description";
            TaskDescriptionText.TextAlign = HorizontalAlignment.Center;
            // 
            // ValidateNewTask
            // 
            ValidateNewTask.BackColor = SystemColors.ControlDarkDark;
            ValidateNewTask.Cursor = Cursors.Hand;
            ValidateNewTask.FlatStyle = FlatStyle.Popup;
            ValidateNewTask.Font = new Font("Gothamic", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ValidateNewTask.ForeColor = SystemColors.ButtonFace;
            ValidateNewTask.Location = new Point(556, 384);
            ValidateNewTask.Name = "ValidateNewTask";
            ValidateNewTask.Size = new Size(222, 41);
            ValidateNewTask.TabIndex = 5;
            ValidateNewTask.Text = "Valider";
            ValidateNewTask.UseVisualStyleBackColor = false;
            ValidateNewTask.Click += button1_Click;
            // 
            // NameTaskError
            // 
            NameTaskError.AutoSize = true;
            NameTaskError.BackColor = Color.Transparent;
            NameTaskError.ForeColor = Color.Red;
            NameTaskError.Location = new Point(343, 232);
            NameTaskError.Name = "NameTaskError";
            NameTaskError.Size = new Size(0, 15);
            NameTaskError.TabIndex = 6;
            NameTaskError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DescriptionTaskError
            // 
            DescriptionTaskError.AutoSize = true;
            DescriptionTaskError.BackColor = Color.Transparent;
            DescriptionTaskError.ForeColor = Color.Red;
            DescriptionTaskError.Location = new Point(343, 340);
            DescriptionTaskError.Name = "DescriptionTaskError";
            DescriptionTaskError.Size = new Size(0, 15);
            DescriptionTaskError.TabIndex = 7;
            DescriptionTaskError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // New_Tache
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(DescriptionTaskError);
            Controls.Add(NameTaskError);
            Controls.Add(ValidateNewTask);
            Controls.Add(TaskDescriptionText);
            Controls.Add(TaskNameText);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "New_Tache";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TaskNameText;
        private TextBox TaskDescriptionText;
        private Button ValidateNewTask;
        private Label NameTaskError;
        private Label DescriptionTaskError;
    }
}
