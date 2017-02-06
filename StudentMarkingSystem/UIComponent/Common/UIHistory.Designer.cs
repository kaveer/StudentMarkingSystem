namespace StudentMarkingSystem.UIComponent.Common
{
    partial class UIHistory
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GridViewProgramme = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewProgramme)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GridViewProgramme);
            this.groupBox3.Location = new System.Drawing.Point(24, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(678, 313);
            this.groupBox3.TabIndex = 8;
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
            this.GridViewProgramme.Size = new System.Drawing.Size(672, 294);
            this.GridViewProgramme.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "History";
            // 
            // UIHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Name = "UIHistory";
            this.Size = new System.Drawing.Size(722, 633);
            this.Load += new System.EventHandler(this.UIHistory_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewProgramme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView GridViewProgramme;
        private System.Windows.Forms.Label label1;
    }
}
