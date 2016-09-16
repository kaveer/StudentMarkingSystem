namespace StudentMarkingSystem.Forms
{
    partial class AddProgramForm
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
            this.ProgramNameTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProgramDurationTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProgramDescriptionTextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SaveProgramButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Program Name";
            // 
            // ProgramNameTextbox
            // 
            this.ProgramNameTextbox.Location = new System.Drawing.Point(96, 51);
            this.ProgramNameTextbox.Name = "ProgramNameTextbox";
            this.ProgramNameTextbox.Size = new System.Drawing.Size(175, 20);
            this.ProgramNameTextbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Duration";
            // 
            // ProgramDurationTextbox
            // 
            this.ProgramDurationTextbox.Location = new System.Drawing.Point(96, 78);
            this.ProgramDurationTextbox.Name = "ProgramDurationTextbox";
            this.ProgramDurationTextbox.Size = new System.Drawing.Size(175, 20);
            this.ProgramDurationTextbox.TabIndex = 3;
            this.ProgramDurationTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProgramDurationTextbox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description";
            // 
            // ProgramDescriptionTextbox
            // 
            this.ProgramDescriptionTextbox.Location = new System.Drawing.Point(96, 107);
            this.ProgramDescriptionTextbox.Multiline = true;
            this.ProgramDescriptionTextbox.Name = "ProgramDescriptionTextbox";
            this.ProgramDescriptionTextbox.Size = new System.Drawing.Size(175, 66);
            this.ProgramDescriptionTextbox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Cohort";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SaveProgramButton
            // 
            this.SaveProgramButton.Location = new System.Drawing.Point(196, 188);
            this.SaveProgramButton.Name = "SaveProgramButton";
            this.SaveProgramButton.Size = new System.Drawing.Size(75, 23);
            this.SaveProgramButton.TabIndex = 7;
            this.SaveProgramButton.Text = "Save";
            this.SaveProgramButton.UseVisualStyleBackColor = true;
            this.SaveProgramButton.Click += new System.EventHandler(this.SaveProgramButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(196, 246);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Add Student";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(196, 275);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 9;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AddProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 346);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SaveProgramButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProgramDescriptionTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProgramDurationTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProgramNameTextbox);
            this.Controls.Add(this.label1);
            this.Name = "AddProgramForm";
            this.Text = "AddProgramForm";
            this.Load += new System.EventHandler(this.AddProgramForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProgramNameTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProgramDurationTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProgramDescriptionTextbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SaveProgramButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button CloseButton;
    }
}