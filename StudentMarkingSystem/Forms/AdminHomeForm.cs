using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMarkingSystem.Forms
{
    public partial class AdminHomeForm : Form
    {
        public AdminHomeForm()
        {
            InitializeComponent();
        }

        

        private void AdminHomeForm_Load(object sender, EventArgs e)
        {
            username_label.Text = LoginForm.userName;
        }
    }
}
