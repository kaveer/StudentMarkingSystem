namespace StudentMarkingSystem.UIComponent.Admin
{
    partial class UICohort
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
            this.DDLCohort = new System.Windows.Forms.ComboBox();
            this.ButtonDeleteProgramme = new System.Windows.Forms.Button();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.TxtBxCohortName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DDLProgramme = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnAddCohort = new System.Windows.Forms.Button();
            this.TxtBxAddCohort = new System.Windows.Forms.TextBox();
            this.LblAddCohort = new System.Windows.Forms.Label();
            this.DDLAddProgramme = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DDLCohort);
            this.groupBox1.Controls.Add(this.ButtonDeleteProgramme);
            this.groupBox1.Controls.Add(this.ButtonUpdate);
            this.groupBox1.Controls.Add(this.TxtBxCohortName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DDLProgramme);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(22, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 148);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update/Delete Cohort";
            // 
            // DDLCohort
            // 
            this.DDLCohort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DDLCohort.FormattingEnabled = true;
            this.DDLCohort.Location = new System.Drawing.Point(105, 49);
            this.DDLCohort.Name = "DDLCohort";
            this.DDLCohort.Size = new System.Drawing.Size(150, 21);
            this.DDLCohort.TabIndex = 11;
            this.DDLCohort.SelectedIndexChanged += new System.EventHandler(this.DDLCohort_SelectedIndexChanged);
            // 
            // ButtonDeleteProgramme
            // 
            this.ButtonDeleteProgramme.Location = new System.Drawing.Point(105, 105);
            this.ButtonDeleteProgramme.Name = "ButtonDeleteProgramme";
            this.ButtonDeleteProgramme.Size = new System.Drawing.Size(75, 23);
            this.ButtonDeleteProgramme.TabIndex = 10;
            this.ButtonDeleteProgramme.Text = "Delete";
            this.ButtonDeleteProgramme.UseVisualStyleBackColor = true;
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Location = new System.Drawing.Point(186, 105);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(75, 23);
            this.ButtonUpdate.TabIndex = 9;
            this.ButtonUpdate.Text = "Update";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // TxtBxCohortName
            // 
            this.TxtBxCohortName.Location = new System.Drawing.Point(105, 76);
            this.TxtBxCohortName.Name = "TxtBxCohortName";
            this.TxtBxCohortName.Size = new System.Drawing.Size(150, 20);
            this.TxtBxCohortName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cohort Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Program Name";
            // 
            // DDLProgramme
            // 
            this.DDLProgramme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DDLProgramme.FormattingEnabled = true;
            this.DDLProgramme.Location = new System.Drawing.Point(105, 23);
            this.DDLProgramme.Name = "DDLProgramme";
            this.DDLProgramme.Size = new System.Drawing.Size(150, 21);
            this.DDLProgramme.TabIndex = 1;
            this.DDLProgramme.SelectedIndexChanged += new System.EventHandler(this.DDLProgramme_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Programme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cohort Management";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnAddCohort);
            this.groupBox2.Controls.Add(this.TxtBxAddCohort);
            this.groupBox2.Controls.Add(this.LblAddCohort);
            this.groupBox2.Controls.Add(this.DDLAddProgramme);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(316, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 148);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update/Delete Cohort";
            // 
            // BtnAddCohort
            // 
            this.BtnAddCohort.Location = new System.Drawing.Point(180, 105);
            this.BtnAddCohort.Name = "BtnAddCohort";
            this.BtnAddCohort.Size = new System.Drawing.Size(75, 23);
            this.BtnAddCohort.TabIndex = 9;
            this.BtnAddCohort.Text = "Add Cohort";
            this.BtnAddCohort.UseVisualStyleBackColor = true;
            this.BtnAddCohort.Click += new System.EventHandler(this.BtnAddCohort_Click);
            // 
            // TxtBxAddCohort
            // 
            this.TxtBxAddCohort.Location = new System.Drawing.Point(105, 50);
            this.TxtBxAddCohort.Name = "TxtBxAddCohort";
            this.TxtBxAddCohort.Size = new System.Drawing.Size(150, 20);
            this.TxtBxAddCohort.TabIndex = 3;
            // 
            // LblAddCohort
            // 
            this.LblAddCohort.AutoSize = true;
            this.LblAddCohort.Location = new System.Drawing.Point(6, 53);
            this.LblAddCohort.Name = "LblAddCohort";
            this.LblAddCohort.Size = new System.Drawing.Size(69, 13);
            this.LblAddCohort.TabIndex = 2;
            this.LblAddCohort.Text = "Cohort Name";
            // 
            // DDLAddProgramme
            // 
            this.DDLAddProgramme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DDLAddProgramme.FormattingEnabled = true;
            this.DDLAddProgramme.Location = new System.Drawing.Point(105, 23);
            this.DDLAddProgramme.Name = "DDLAddProgramme";
            this.DDLAddProgramme.Size = new System.Drawing.Size(150, 21);
            this.DDLAddProgramme.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Select Programme";
            // 
            // UICohort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "UICohort";
            this.Size = new System.Drawing.Size(739, 514);
            this.Load += new System.EventHandler(this.UICohort_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonDeleteProgramme;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.TextBox TxtBxCohortName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DDLProgramme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnAddCohort;
        private System.Windows.Forms.TextBox TxtBxAddCohort;
        private System.Windows.Forms.Label LblAddCohort;
        private System.Windows.Forms.ComboBox DDLAddProgramme;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox DDLCohort;
    }
}
