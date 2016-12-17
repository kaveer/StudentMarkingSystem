namespace StudentMarkingSystem.UIComponent.Lecturer
{
    partial class UIGrade
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbxGrade = new System.Windows.Forms.TextBox();
            this.BtnAddGrade = new System.Windows.Forms.Button();
            this.DdlStudent = new System.Windows.Forms.ComboBox();
            this.DdlModule = new System.Windows.Forms.ComboBox();
            this.DdlCohort = new System.Windows.Forms.ComboBox();
            this.DdlProgramme = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbxGrade);
            this.groupBox1.Controls.Add(this.BtnAddGrade);
            this.groupBox1.Controls.Add(this.DdlStudent);
            this.groupBox1.Controls.Add(this.DdlModule);
            this.groupBox1.Controls.Add(this.DdlCohort);
            this.groupBox1.Controls.Add(this.DdlProgramme);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add grade";
            // 
            // txtbxGrade
            // 
            this.txtbxGrade.Location = new System.Drawing.Point(72, 127);
            this.txtbxGrade.Name = "txtbxGrade";
            this.txtbxGrade.Size = new System.Drawing.Size(179, 20);
            this.txtbxGrade.TabIndex = 11;
            this.txtbxGrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxGrade_KeyPress);
            // 
            // BtnAddGrade
            // 
            this.BtnAddGrade.Location = new System.Drawing.Point(176, 153);
            this.BtnAddGrade.Name = "BtnAddGrade";
            this.BtnAddGrade.Size = new System.Drawing.Size(75, 23);
            this.BtnAddGrade.TabIndex = 10;
            this.BtnAddGrade.Text = "Add grade";
            this.BtnAddGrade.UseVisualStyleBackColor = true;
            this.BtnAddGrade.Click += new System.EventHandler(this.BtnAddGrade_Click);
            // 
            // DdlStudent
            // 
            this.DdlStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DdlStudent.FormattingEnabled = true;
            this.DdlStudent.Location = new System.Drawing.Point(72, 100);
            this.DdlStudent.Name = "DdlStudent";
            this.DdlStudent.Size = new System.Drawing.Size(179, 21);
            this.DdlStudent.TabIndex = 8;
            this.DdlStudent.SelectedIndexChanged += new System.EventHandler(this.DdlStudent_SelectedIndexChanged);
            // 
            // DdlModule
            // 
            this.DdlModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DdlModule.FormattingEnabled = true;
            this.DdlModule.Location = new System.Drawing.Point(72, 73);
            this.DdlModule.Name = "DdlModule";
            this.DdlModule.Size = new System.Drawing.Size(179, 21);
            this.DdlModule.TabIndex = 7;
            this.DdlModule.SelectedIndexChanged += new System.EventHandler(this.DdlModule_SelectedIndexChanged);
            // 
            // DdlCohort
            // 
            this.DdlCohort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DdlCohort.FormattingEnabled = true;
            this.DdlCohort.Location = new System.Drawing.Point(72, 46);
            this.DdlCohort.Name = "DdlCohort";
            this.DdlCohort.Size = new System.Drawing.Size(179, 21);
            this.DdlCohort.TabIndex = 6;
            this.DdlCohort.SelectedIndexChanged += new System.EventHandler(this.DdlCohort_SelectedIndexChanged);
            // 
            // DdlProgramme
            // 
            this.DdlProgramme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DdlProgramme.FormattingEnabled = true;
            this.DdlProgramme.Location = new System.Drawing.Point(72, 19);
            this.DdlProgramme.Name = "DdlProgramme";
            this.DdlProgramme.Size = new System.Drawing.Size(179, 21);
            this.DdlProgramme.TabIndex = 5;
            this.DdlProgramme.SelectedIndexChanged += new System.EventHandler(this.DdlProgramme_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Grade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Student";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Module";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cohort";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programme";
            // 
            // UIGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UIGrade";
            this.Size = new System.Drawing.Size(461, 403);
            this.Load += new System.EventHandler(this.UIGrade_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbxGrade;
        private System.Windows.Forms.Button BtnAddGrade;
        private System.Windows.Forms.ComboBox DdlStudent;
        private System.Windows.Forms.ComboBox DdlModule;
        private System.Windows.Forms.ComboBox DdlCohort;
        private System.Windows.Forms.ComboBox DdlProgramme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
