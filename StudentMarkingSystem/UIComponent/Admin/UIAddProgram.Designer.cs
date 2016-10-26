namespace StudentMarkingSystem.UIComponent.Admin
{
    partial class UIAddProgram
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonDeleteProgramme = new System.Windows.Forms.Button();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TextboxDuration = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextboxProgramName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DropDownListProgramme = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ButtonAddProgram = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TextboxAddDuration = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TextboxAddName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GridViewProgramme = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewProgramme)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Programme Management";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonDeleteProgramme);
            this.groupBox1.Controls.Add(this.ButtonUpdate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TextboxDuration);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TextboxProgramName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DropDownListProgramme);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 157);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update/Delete programme";
            // 
            // ButtonDeleteProgramme
            // 
            this.ButtonDeleteProgramme.Location = new System.Drawing.Point(89, 115);
            this.ButtonDeleteProgramme.Name = "ButtonDeleteProgramme";
            this.ButtonDeleteProgramme.Size = new System.Drawing.Size(75, 23);
            this.ButtonDeleteProgramme.TabIndex = 10;
            this.ButtonDeleteProgramme.Text = "Delete";
            this.ButtonDeleteProgramme.UseVisualStyleBackColor = true;
            this.ButtonDeleteProgramme.Click += new System.EventHandler(this.ButtonDeleteProgramme_Click);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Location = new System.Drawing.Point(164, 115);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(75, 23);
            this.ButtonUpdate.TabIndex = 9;
            this.ButtonUpdate.Text = "Update";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Year";
            // 
            // TextboxDuration
            // 
            this.TextboxDuration.Location = new System.Drawing.Point(89, 76);
            this.TextboxDuration.Name = "TextboxDuration";
            this.TextboxDuration.Size = new System.Drawing.Size(70, 20);
            this.TextboxDuration.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Duration";
            // 
            // TextboxProgramName
            // 
            this.TextboxProgramName.Location = new System.Drawing.Point(89, 50);
            this.TextboxProgramName.Name = "TextboxProgramName";
            this.TextboxProgramName.Size = new System.Drawing.Size(150, 20);
            this.TextboxProgramName.TabIndex = 3;
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
            // DropDownListProgramme
            // 
            this.DropDownListProgramme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownListProgramme.FormattingEnabled = true;
            this.DropDownListProgramme.Location = new System.Drawing.Point(89, 23);
            this.DropDownListProgramme.Name = "DropDownListProgramme";
            this.DropDownListProgramme.Size = new System.Drawing.Size(150, 21);
            this.DropDownListProgramme.TabIndex = 1;
            this.DropDownListProgramme.SelectedIndexChanged += new System.EventHandler(this.DropDownListProgramme_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ButtonAddProgram);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TextboxAddDuration);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TextboxAddName);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(267, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 157);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Programme";
            // 
            // ButtonAddProgram
            // 
            this.ButtonAddProgram.Location = new System.Drawing.Point(154, 115);
            this.ButtonAddProgram.Name = "ButtonAddProgram";
            this.ButtonAddProgram.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddProgram.TabIndex = 17;
            this.ButtonAddProgram.Text = "Add";
            this.ButtonAddProgram.UseVisualStyleBackColor = true;
            this.ButtonAddProgram.Click += new System.EventHandler(this.ButtonAddProgram_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Year";
            // 
            // TextboxAddDuration
            // 
            this.TextboxAddDuration.Location = new System.Drawing.Point(89, 49);
            this.TextboxAddDuration.Name = "TextboxAddDuration";
            this.TextboxAddDuration.Size = new System.Drawing.Size(70, 20);
            this.TextboxAddDuration.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Duration";
            // 
            // TextboxAddName
            // 
            this.TextboxAddName.Location = new System.Drawing.Point(89, 23);
            this.TextboxAddName.Name = "TextboxAddName";
            this.TextboxAddName.Size = new System.Drawing.Size(150, 20);
            this.TextboxAddName.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Program Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GridViewProgramme);
            this.groupBox3.Location = new System.Drawing.Point(16, 228);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(503, 151);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "View programme";
            // 
            // GridViewProgramme
            // 
            this.GridViewProgramme.AllowUserToAddRows = false;
            this.GridViewProgramme.AllowUserToDeleteRows = false;
            this.GridViewProgramme.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.GridViewProgramme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewProgramme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewProgramme.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GridViewProgramme.Location = new System.Drawing.Point(3, 16);
            this.GridViewProgramme.Name = "GridViewProgramme";
            this.GridViewProgramme.ReadOnly = true;
            this.GridViewProgramme.Size = new System.Drawing.Size(497, 132);
            this.GridViewProgramme.TabIndex = 0;
            // 
            // UIAddProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "UIAddProgram";
            this.Size = new System.Drawing.Size(542, 467);
            this.Load += new System.EventHandler(this.UIAddProgram_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewProgramme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonDeleteProgramme;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextboxDuration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextboxProgramName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DropDownListProgramme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ButtonAddProgram;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextboxAddDuration;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextboxAddName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView GridViewProgramme;
    }
}
