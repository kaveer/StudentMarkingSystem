namespace StudentMarkingSystem.Forms
{
    partial class ViewProgramForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ProgramDropDownList = new System.Windows.Forms.ComboBox();
            this.Descriptiontextbox = new System.Windows.Forms.TextBox();
            this.DurationTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Program";
            // 
            // ProgramDropDownList
            // 
            this.ProgramDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProgramDropDownList.FormattingEnabled = true;
            this.ProgramDropDownList.Location = new System.Drawing.Point(78, 61);
            this.ProgramDropDownList.Name = "ProgramDropDownList";
            this.ProgramDropDownList.Size = new System.Drawing.Size(184, 21);
            this.ProgramDropDownList.TabIndex = 1;
            this.ProgramDropDownList.SelectedIndexChanged += new System.EventHandler(this.ProgramDropDownList_SelectedIndexChanged);
            // 
            // Descriptiontextbox
            // 
            this.Descriptiontextbox.Location = new System.Drawing.Point(78, 114);
            this.Descriptiontextbox.Multiline = true;
            this.Descriptiontextbox.Name = "Descriptiontextbox";
            this.Descriptiontextbox.Size = new System.Drawing.Size(184, 76);
            this.Descriptiontextbox.TabIndex = 2;
            // 
            // DurationTextbox
            // 
            this.DurationTextbox.Location = new System.Drawing.Point(78, 88);
            this.DurationTextbox.Name = "DurationTextbox";
            this.DurationTextbox.Size = new System.Drawing.Size(184, 20);
            this.DurationTextbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Duration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(187, 209);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ViewProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 286);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DurationTextbox);
            this.Controls.Add(this.Descriptiontextbox);
            this.Controls.Add(this.ProgramDropDownList);
            this.Controls.Add(this.label1);
            this.Name = "ViewProgramForm";
            this.Text = "ViewProgramForm";
            this.Load += new System.EventHandler(this.ViewProgramForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ProgramDropDownList;
        private System.Windows.Forms.TextBox Descriptiontextbox;
        private System.Windows.Forms.TextBox DurationTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CloseButton;
    }
}