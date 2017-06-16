namespace StudentMarkingSystem.Forms
{
    partial class AdminHomeForm
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

            test
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnStudentManagement = new System.Windows.Forms.Button();
            this.BtnCohort = new System.Windows.Forms.Button();
            this.BtnLecturerManagement = new System.Windows.Forms.Button();
            this.BtnHistory = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnProgramme = new System.Windows.Forms.Button();
            this.BtnModuleManagment = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.username_label = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnStudentManagement
            // 
            this.BtnStudentManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnStudentManagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnStudentManagement.Font = new System.Drawing.Font("Goudy Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStudentManagement.Location = new System.Drawing.Point(0, 0);
            this.BtnStudentManagement.Name = "BtnStudentManagement";
            this.BtnStudentManagement.Size = new System.Drawing.Size(228, 53);
            this.BtnStudentManagement.TabIndex = 4;
            this.BtnStudentManagement.Text = "Student Management";
            this.BtnStudentManagement.UseVisualStyleBackColor = true;
            this.BtnStudentManagement.Click += new System.EventHandler(this.BtnStudentManagement_Click);
            // 
            // BtnCohort
            // 
            this.BtnCohort.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCohort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCohort.Font = new System.Drawing.Font("Goudy Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCohort.Location = new System.Drawing.Point(0, 53);
            this.BtnCohort.Name = "BtnCohort";
            this.BtnCohort.Size = new System.Drawing.Size(228, 53);
            this.BtnCohort.TabIndex = 3;
            this.BtnCohort.Text = "Cohort Management";
            this.BtnCohort.UseVisualStyleBackColor = true;
            this.BtnCohort.Click += new System.EventHandler(this.BtnCohort_Click);
            // 
            // BtnLecturerManagement
            // 
            this.BtnLecturerManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnLecturerManagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLecturerManagement.Font = new System.Drawing.Font("Goudy Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLecturerManagement.Location = new System.Drawing.Point(0, 106);
            this.BtnLecturerManagement.Name = "BtnLecturerManagement";
            this.BtnLecturerManagement.Size = new System.Drawing.Size(228, 53);
            this.BtnLecturerManagement.TabIndex = 6;
            this.BtnLecturerManagement.Text = "Lecturer Management";
            this.BtnLecturerManagement.UseVisualStyleBackColor = true;
            this.BtnLecturerManagement.Click += new System.EventHandler(this.BtnLecturerManagement_Click);
            // 
            // BtnHistory
            // 
            this.BtnHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnHistory.Font = new System.Drawing.Font("Goudy Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHistory.Location = new System.Drawing.Point(0, 213);
            this.BtnHistory.Name = "BtnHistory";
            this.BtnHistory.Size = new System.Drawing.Size(228, 53);
            this.BtnHistory.TabIndex = 7;
            this.BtnHistory.Text = "History";
            this.BtnHistory.UseVisualStyleBackColor = true;
            this.BtnHistory.Click += new System.EventHandler(this.BtnHistory_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.BtnProgramme);
            this.panel1.Controls.Add(this.BtnHistory);
            this.panel1.Controls.Add(this.BtnModuleManagment);
            this.panel1.Controls.Add(this.BtnLecturerManagement);
            this.panel1.Controls.Add(this.BtnCohort);
            this.panel1.Controls.Add(this.BtnStudentManagement);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 554);
            this.panel1.TabIndex = 8;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Goudy Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(0, 374);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(228, 54);
            this.button5.TabIndex = 11;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Goudy Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 54);
            this.button2.TabIndex = 10;
            this.button2.Text = "Option";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BtnProgramme
            // 
            this.BtnProgramme.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProgramme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnProgramme.Font = new System.Drawing.Font("Goudy Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProgramme.Location = new System.Drawing.Point(0, 266);
            this.BtnProgramme.Name = "BtnProgramme";
            this.BtnProgramme.Size = new System.Drawing.Size(228, 54);
            this.BtnProgramme.TabIndex = 9;
            this.BtnProgramme.Text = "Programme";
            this.BtnProgramme.UseVisualStyleBackColor = true;
            this.BtnProgramme.Click += new System.EventHandler(this.BtnProgramme_Click);
            // 
            // BtnModuleManagment
            // 
            this.BtnModuleManagment.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnModuleManagment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnModuleManagment.Font = new System.Drawing.Font("Goudy Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModuleManagment.Location = new System.Drawing.Point(0, 159);
            this.BtnModuleManagment.Name = "BtnModuleManagment";
            this.BtnModuleManagment.Size = new System.Drawing.Size(228, 54);
            this.BtnModuleManagment.TabIndex = 12;
            this.BtnModuleManagment.Text = "Module management";
            this.BtnModuleManagment.UseVisualStyleBackColor = true;
            this.BtnModuleManagment.Click += new System.EventHandler(this.BtnModuleManagment_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(963, 95);
            this.panel2.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.username_label);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(676, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(287, 95);
            this.panel5.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::StudentMarkingSystem.Properties.Resources.male_circle_512;
            this.pictureBox2.Location = new System.Drawing.Point(0, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.Location = new System.Drawing.Point(106, 43);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(174, 15);
            this.username_label.TabIndex = 9;
            this.username_label.Text = "UsernamePlaceholder";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(241)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(228, 95);
            this.panel4.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentMarkingSystem.Properties.Resources.University_of_Technology_Mauritius_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(93, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Marking";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.MainPanel.Location = new System.Drawing.Point(227, 95);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(736, 554);
            this.MainPanel.TabIndex = 9;
            // 
            // AdminHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 649);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel2);
            this.Name = "AdminHomeForm";
            this.Text = "AdminHomeForm";
            this.Load += new System.EventHandler(this.AdminHomeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnCohort;
        private System.Windows.Forms.Button BtnStudentManagement;
        private System.Windows.Forms.Button BtnLecturerManagement;
        private System.Windows.Forms.Button BtnHistory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label username_label;
        private LoginForm login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnProgramme;
        private System.Windows.Forms.Button BtnModuleManagment;
    }
}