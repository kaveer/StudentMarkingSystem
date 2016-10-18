﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentMarkingSystem.UIComponent.Admin;

namespace StudentMarkingSystem.Forms
{
    public partial class AdminHomeForm : Form
    {
        UIAddProgram program = new UIAddProgram();
        UICohort cohort = new UICohort();
        UIStudent student = new UIStudent();
        UILecturer lecturer = new UILecturer();

        public AdminHomeForm()
        {
            InitializeComponent();
        }

        private void AdminHomeForm_Load(object sender, EventArgs e)
        {
            username_label.Text = LoginForm.userName;
        }

        private void BtnProgramme_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(program);
            
        }

        private void BtnCohort_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(cohort);
        }

        private void BtnStudentManagement_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(student);
        }

        private void BtnLecturerManagement_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(lecturer);
        }
    }
}
