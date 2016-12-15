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

namespace StudentMarkingSystem.UIComponent.Lecturer
{
    public partial class UIGrade : UserControl
    {
        CohortViewModel cohort = new CohortViewModel();
        ModuleViewModel module = new ModuleViewModel();

        public UIGrade()
        {
            InitializeComponent();
        }

        private void UIGrade_Load(object sender, EventArgs e)
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
                DdlProgramme.Items.Add(row["Programme"].ToString());
            }
        }

        private void DdlProgramme_SelectedIndexChanged(object sender, EventArgs e)
        {
            string programmeName = DdlProgramme.SelectedItem.ToString();
            RetrieveCohortByProgrammeName(cohort, programmeName, "add");
        }

        private void RetrieveCohortByProgrammeName(CohortViewModel cohort, string programmeName, string operationType)
        {
            DdlCohort.Items.Clear();

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
                RetrieveCohortByProgrammeName(row, cohort, operationType);
            }
        }

        private void RetrieveCohortByProgrammeName(DataRow row, CohortViewModel cohort, string operationType)
        {
            if (operationType == "add")
            {
                DdlCohort.Items.Add(row["Cohort"]);
            }
        }

        private void DdlCohort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cohortName = DdlCohort.SelectedItem.ToString();
            GetModuleByCohortName(cohortName);
        }

        private void GetModuleByCohortName(string cohortName)
        {
            DdlModule.Items.Clear();

            DbConfiguration configuration = new DbConfiguration();
            SqlCommand com = new SqlCommand();
            DataSet dataSet = new DataSet();
            com.Connection = new SqlConnection(configuration.GetConnectionString());
            com.Parameters.Add(new SqlParameter("@cohort", cohortName));
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "RetrieveModuleByCohortName";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(dataSet);

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                DdlModule.Items.Add(row["name"]);
            }
        }
    }
}
