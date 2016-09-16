using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentMarkingSystem.Models;
using StudentMarkingSystem.Repository;

namespace StudentMarkingSystem.Forms
{
    public partial class AddProgramForm : Form
    {
        public AddProgramForm()
        {
            InitializeComponent();
        }

        private void AddProgramForm_Load(object sender, EventArgs e)
        {

        }

        private void SaveProgramButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ProgramNameTextbox.Text))
            {
                MessageBox.Show("Enter Program Name");
                return;
            }
            
            ProgramViewModel program = new ProgramViewModel()
            {
                ProgramName = ProgramNameTextbox.Text,
                ProgramDescription = ProgramDescriptionTextbox.Text,
                ProgramDuration = Convert.ToInt32(ProgramDurationTextbox.Text),
                ProgramStatus = "active"
            };

            SaveProgram(program);
        }

        public void SaveProgram(ProgramViewModel program)
        {
            DbConfiguration configuration = new DbConfiguration();

            SqlCommand com = new SqlCommand();
            DataSet dataSet = new DataSet();
            com.Connection = new SqlConnection(configuration.GetConnectionString());
            com.Parameters.Add(new SqlParameter("@name", program.ProgramName));
            com.Parameters.Add(new SqlParameter("@descrip", program.ProgramDescription));
            com.Parameters.Add(new SqlParameter("@duration", program.ProgramDuration));
            com.Parameters.Add(new SqlParameter("@status", program.ProgramStatus));
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "AddProgram";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(dataSet);

            DialogResult dialog = MessageBox.Show("Program Successfully Added");
            if (dialog == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void ProgramDurationTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
