using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentMarkingSystem.UIComponent.Lecturer;

namespace StudentMarkingSystem.Forms
{
    public partial class LecturerHomeForm : Form
    {
        LoginForm login = new LoginForm();
        UIGrade grade = new UIGrade();

        public LecturerHomeForm()
        {
            InitializeComponent();
        }

        private void LecturerHomeForm_Load(object sender, EventArgs e)
        {
            username_label.Text = LoginForm.userName;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
        }

        private void BtnGrade_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(grade);
        }
    }
}
