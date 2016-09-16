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
    public partial class ViewProgramForm : Form
    {
        public ViewProgramForm()
        {
            InitializeComponent();
        }

        private void ViewProgramForm_Load(object sender, EventArgs e)
        {
            RetrieveProgram();
        }

        private void RetrieveProgram()
        {
            DbConfiguration configuration = new DbConfiguration();

            SqlCommand com = new SqlCommand();
            DataSet dataSet = new DataSet();
            com.Connection = new SqlConnection(configuration.GetConnectionString());
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "ViewProgram";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(dataSet);

            if (dataSet.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No Program In the System");
                return;
            }
            else
            {
                foreach (DataRow item in dataSet.Tables[0].Rows)
                {
                    ProgramDropDownList.Items.Add(item["ProgramName"].ToString());
                }
            }
        }

        private void RetrieveProgramByName(ProgramViewModel program)
        {
            DbConfiguration configuration = new DbConfiguration();

            SqlCommand com = new SqlCommand();
            DataSet dataSet = new DataSet();
            com.Connection = new SqlConnection(configuration.GetConnectionString());
            com.Parameters.Add(new SqlParameter("@programName", ProgramDropDownList.SelectedItem.ToString()));
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "ViewProgramByName";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(dataSet);

            if (dataSet.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No Program in the system");
                return;
            }
            else
            {
                foreach (DataRow item in dataSet.Tables[0].Rows)
                {
                    program.ProgramId = Convert.ToInt32(item["ProgramId"]);
                    program.ProgramName = item["ProgramName"].ToString();
                    program.ProgramDuration = Convert.ToInt32(item["Duration"]);
                    program.ProgramDescription = item["ProgramDescription"].ToString();
                    program.ProgramStatus = item["ProgramStatus"].ToString();
                }
            }
            
        }

        private void ProgramDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProgramViewModel program = new ProgramViewModel();

            RetrieveProgramByName(program);

            DurationTextbox.Text =  program.ProgramDuration.ToString();
            Descriptiontextbox.Text= program.ProgramDescription ;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
