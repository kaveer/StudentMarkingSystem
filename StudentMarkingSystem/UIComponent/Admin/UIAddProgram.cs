using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentMarkingSystem.Repository;
using System.Data.SqlClient;
using StudentMarkingSystem.Models;

namespace StudentMarkingSystem.UIComponent.Admin
{
    public partial class UIAddProgram : UserControl
    {
        ProgramViewModel program = new ProgramViewModel();

        public UIAddProgram()
        {
            InitializeComponent();
        }

        private void UIAddProgram_Load(object sender, EventArgs e)
        {
            RetrieveProgram(program);
        }

        public void RetrieveProgram(ProgramViewModel program)
        {
            DbConfiguration configuration = new DbConfiguration();
            SqlCommand com = new SqlCommand();
            DataSet dataSet = new DataSet();
            com.Connection = new SqlConnection(configuration.GetConnectionString());
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "RetrieveProgram";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(dataSet);

            DataTable table = new DataTable();
            adapter.Fill(table);
            BindToGridView(table);

            if (dataSet.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No programme in the system");
                return;
            }

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                DropDownListProgramme.Items.Add(row["ProgramName"].ToString());
            }
        }

        private void BindToGridView(DataTable table)
        {
            GridViewProgramme.DataSource = table;
            GridViewProgramme.Columns[0].Visible = false;
            GridViewProgramme.Columns[4].Visible = false;
            //dataGridView1.DataBindings.ToString();
        }

        private void DropDownListProgramme_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbConfiguration configuration = new DbConfiguration();
            SqlCommand com = new SqlCommand();
            DataSet dataSet = new DataSet();
            com.Connection = new SqlConnection(configuration.GetConnectionString());
            com.Parameters.Add(new SqlParameter("@programName", DropDownListProgramme.SelectedItem.ToString()));
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "RetrieveProgramByName";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(dataSet);

            if (dataSet.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No programme in the system");
                return;
            }

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                RetrieveProgramByName(row, program);
            }

           
        }

        private void RetrieveProgramByName(DataRow row, ProgramViewModel program)
        {
            program.ProgramId = Convert.ToInt32(row["ProgramId"]);
            TextboxProgramName.Text = program.ProgramName = row["ProgramName"].ToString();
            TextboxDuration.Text = Convert.ToString(program.ProgramDuration = Convert.ToInt32(row["Duration"]));
            TextboxDescription.Text =  program.ProgramDescription = row["ProgramDescription"].ToString();
            program.ProgramStatus = row["ProgramStatus"].ToString();     
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if(DropDownListProgramme.Text == "")
            {
                MessageBox.Show("Select a programme to update");
                return;
            }

            UpdateProgramme(program);
              
        }

        private void UpdateProgramme(ProgramViewModel program)
        {
            program.ProgramName = TextboxProgramName.Text;
            program.ProgramDuration = Convert.ToInt32(TextboxDuration.Text);
            program.ProgramDescription = TextboxDescription.Text;

            DbConfiguration configuration = new DbConfiguration();
            SqlCommand com = new SqlCommand();
            DataSet dataSet = new DataSet();
            com.Connection = new SqlConnection(configuration.GetConnectionString());
            com.Parameters.Add(new SqlParameter("@programId", program.ProgramId));
            com.Parameters.Add(new SqlParameter("@programName", program.ProgramName));
            com.Parameters.Add(new SqlParameter("@programDuration", program.ProgramDuration));
            com.Parameters.Add(new SqlParameter("@programDescrip", program.ProgramDescription));
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "UpdateProgramById";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(dataSet);

            MessageBox.Show("Programme updated");
        }

        private void ButtonDeleteProgramme_Click(object sender, EventArgs e)
        {
            if (DropDownListProgramme.Text == "")
            {
                MessageBox.Show("Select a programme to delete");
                return;
            }

            DeleteProgramme(program);
        }

        private void DeleteProgramme(ProgramViewModel program)
        {
            DbConfiguration configuration = new DbConfiguration();
            SqlCommand com = new SqlCommand();
            DataSet dataSet = new DataSet();
            com.Connection = new SqlConnection(configuration.GetConnectionString());
            com.Parameters.Add(new SqlParameter("@programId", program.ProgramId));
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "DeleteProgramById";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(dataSet);

            RemoveTextboxString();
            RetrieveProgram(program);

            MessageBox.Show("Programme Deleted");
        }

        public void RemoveTextboxString()
        {
            DropDownListProgramme.Items.Clear();
            TextboxProgramName.Text = "";
            TextboxDuration.Text = "";
            TextboxDescription.Text = "";
        }

        private void ButtonAddProgram_Click(object sender, EventArgs e)
        {
            if (!HasEnteredData())
                return;

            AddProgram();

        }

        private void AddProgram()
        {
            DbConfiguration configuration = new DbConfiguration();
            SqlCommand com = new SqlCommand();
            DataSet dataSet = new DataSet();
            com.Connection = new SqlConnection(configuration.GetConnectionString());
            com.Parameters.Add(new SqlParameter("@name", TextboxAddName.Text));
            com.Parameters.Add(new SqlParameter("@descrip", TextboxAddDescription.Text));
            com.Parameters.Add(new SqlParameter("@duration", TextboxAddDuration.Text));
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "AddProgram";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(dataSet);

            RemoveTextboxString();
            RetrieveProgram(program);
        }

        private bool HasEnteredData()
        {
            bool dataEntered = false;

            if (string.IsNullOrWhiteSpace(TextboxAddName.Text))
            {
                MessageBox.Show("Enter Programme name");
                return dataEntered;
            }
            if (string.IsNullOrWhiteSpace(TextboxAddDuration.Text))
            {
                MessageBox.Show("Enter duration of the programme");
                return dataEntered;
            }

            return dataEntered = true;
            
        }
    }
}
