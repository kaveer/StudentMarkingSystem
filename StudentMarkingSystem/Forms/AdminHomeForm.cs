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

        private void AddProgramButton_Click(object sender, EventArgs e)
        {
            AddProgramForm addProgram = new AddProgramForm();
            addProgram.ShowDialog();
        }

        private void ViewProgramButton_Click(object sender, EventArgs e)
        {
            ViewProgramForm viewProgram = new ViewProgramForm();
            viewProgram.ShowDialog();
        }
    }
}
