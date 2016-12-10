using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentMarkingSystem.Models;
using StudentMarkingSystem.Repository;
using System.Data.SqlClient;

namespace StudentMarkingSystem.UIComponent.Admin
{
    public partial class UICohort : UserControl
    {
        CohortViewModel cohort = new CohortViewModel();

        public UICohort()
        {
            InitializeComponent();
        }

        private void UICohort_Load(object sender, EventArgs e)
        {
            RetrieveProgram();
        }

        public void RetrieveProgram()
        {
            DbConfiguration configuration = new DbConfiguration();
            SqlCommand com = new SqlCommand();
            DataSet dataSet = new DataSet();
            com.Connection = new SqlConnection(configuration.GetConnectionString());
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "RetrieveProgram";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(dataSet);

            if (dataSet.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No programme in the system");
                return;
            }

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                DDLProgramme.Items.Add(row["Programme"].ToString());
                DDLAddProgramme.Items.Add(row["Programme"].ToString());
            }
        }

        private void DDLProgramme_SelectedIndexChanged(object sender, EventArgs e)
        {
            string programmeName = DDLProgramme.SelectedItem.ToString();
            RetrieveCohortByProgrammeName(cohort , programmeName);
        }

        private void RetrieveCohortByProgrammeName(CohortViewModel cohort , string programmeName)
        {
            DDLCohort.Items.Clear();

            DbConfiguration configuration = new DbConfiguration();
            SqlCommand com = new SqlCommand();
            DataSet dataSet = new DataSet();
            com.Connection = new SqlConnection(configuration.GetConnectionString());
            com.Parameters.Add(new SqlParameter("@programName", programmeName));
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "RetrieveCohortByProgrammeName";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(dataSet);

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                RetrieveCohortByProgrammeName(row, cohort);
            }
        }

        private void RetrieveCohortByProgrammeName(DataRow row, CohortViewModel cohort)
        {
            DDLCohort.Items.Add(row["Cohort"]);
        }

        private void DDLCohort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cohortName = DDLCohort.SelectedItem.ToString();
            RetrieveCohortByCohortName( cohortName, cohort);
        }

        private void RetrieveCohortByCohortName(string cohortName, CohortViewModel cohort)
        {
            DbConfiguration configuration = new DbConfiguration();
            SqlCommand com = new SqlCommand();
            DataSet dataSet = new DataSet();
            com.Connection = new SqlConnection(configuration.GetConnectionString());
            com.Parameters.Add(new SqlParameter("@cohortName", cohortName));
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "RetrieveCohortByCohortName";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(dataSet);

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                cohort.CohortId = Convert.ToInt32(row["CohortId"]);
                cohort.ProgramId = Convert.ToInt32(row["ProgrammeId"]);
                TxtBxCohortName.Text = cohort.Cohort = row["Cohort"].ToString();
                cohort.CohortStatus = row["CohortStatus"].ToString();
            }

            
        }

        private void BtnAddCohort_Click(object sender, EventArgs e)
        {
            if (DDLAddProgramme.Text == "")
            {
                MessageBox.Show("Select a programme to add cohort");
                return;
            }
            if (string.IsNullOrWhiteSpace(TxtBxAddCohort.Text))
            {
                MessageBox.Show("Enter cohort name");
                return;
            }

            DbConfiguration configuration = new DbConfiguration();
            SqlCommand com = new SqlCommand();
            DataSet dataSet = new DataSet();
            com.Connection = new SqlConnection(configuration.GetConnectionString());
            com.Parameters.Add(new SqlParameter("@programName", DDLAddProgramme.SelectedItem.ToString()));
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
                RetrieveProgramByName(row, cohort);
            }
            AddCohort(cohort);
        }

        private void AddCohort(CohortViewModel cohort)
        {
            cohort.Cohort = TxtBxAddCohort.Text;

            DbConfiguration configuration = new DbConfiguration();
            SqlCommand com = new SqlCommand();
            DataSet dataSet = new DataSet();
            com.Connection = new SqlConnection(configuration.GetConnectionString());
            com.Parameters.Add(new SqlParameter("@programId", cohort.ProgramId));
            com.Parameters.Add(new SqlParameter("@cohortName", cohort.Cohort));
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "AddCohort";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(dataSet);

            ClearDropDownList();
            RetrieveProgram();

            MessageBox.Show("New Cohort added");

        }

        private void ClearDropDownList()
        {
            DDLProgramme.Items.Clear();
            DDLAddProgramme.Items.Clear();
            DDLCohort.Items.Clear();
        }

        private void RetrieveProgramByName(DataRow row, CohortViewModel cohort)
        {
            cohort.ProgramId = Convert.ToInt32(row["ProgrammeId"]);
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            UpdateCohort(cohort); 
        }

        private void UpdateCohort(CohortViewModel cohort)
        {
            cohort.Cohort = TxtBxCohortName.Text;

            DbConfiguration configuration = new DbConfiguration();
            SqlCommand com = new SqlCommand();
            DataSet dataSet = new DataSet();
            com.Connection = new SqlConnection(configuration.GetConnectionString());
            com.Parameters.Add(new SqlParameter("@cohortId", cohort.CohortId));
            com.Parameters.Add(new SqlParameter("@cohortName", cohort.Cohort));
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "UpdateCohort";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(dataSet);

            ClearDropDownList();
            TxtBxCohortName.Text = "";
            RetrieveProgram();

            MessageBox.Show("Cohort Updated");
        }

        private void ButtonDeleteProgramme_Click(object sender, EventArgs e)
        {
            if (DDLProgramme.Text == "")
            {
                MessageBox.Show("Select a programme to delete cohort");
                return;
            }
            if (DDLCohort.Text == "")
            {
                MessageBox.Show("Select a cohort to delete");
                return;
            }

            DeleteProgramme(cohort);
        }

        private void DeleteProgramme(CohortViewModel cohort)
        {
            DbConfiguration configuration = new DbConfiguration();
            SqlCommand com = new SqlCommand();
            DataSet dataSet = new DataSet();
            com.Connection = new SqlConnection(configuration.GetConnectionString());
            com.Parameters.Add(new SqlParameter("@cohortId", cohort.CohortId));
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "DeleteCohort";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(dataSet);

            ClearDropDownList();
            TxtBxCohortName.Text = "";
            RetrieveProgram();

            MessageBox.Show("Cohort Deleted");
        }
    }
}
