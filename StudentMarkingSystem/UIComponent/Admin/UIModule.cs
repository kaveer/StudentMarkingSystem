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
    public partial class UIModule : UserControl
    {
        CohortViewModel cohort = new CohortViewModel();
        ModuleViewModel module = new ModuleViewModel();

        public UIModule()
        {
            InitializeComponent();
        }

        private void UIModule_Load(object sender, EventArgs e)
        {
            RetrieveProgram();
            InitializeSemesterAndYear();
        }

        private void InitializeSemesterAndYear()
        {
            string[] semester = { "1", "2" };
            string[] year = { "1", "2", "3", "4" };
            ddlSemester.Items.Clear();
            ddlYear.Items.Clear();

            foreach (string item in semester)
            {
                ddlSemester.Items.Add(item);
            }
            foreach (string item in year)
            {
                ddlYear.Items.Add(item);
            }
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
                dropDownListProgramme_update.Items.Add(row["Programme"].ToString());
                DDLAddProgramme.Items.Add(row["Programme"].ToString());
            }
        }

        private void DDLAddProgramme_SelectedIndexChanged(object sender, EventArgs e)
        {
            string programmeName = DDLAddProgramme.SelectedItem.ToString();
            RetrieveCohortByProgrammeName(cohort, programmeName, "add");
        }

        private void dropDownListProgramme_update_SelectedIndexChanged(object sender, EventArgs e)
        {
            string programmeName = dropDownListProgramme_update.SelectedItem.ToString();
            RetrieveCohortByProgrammeName(cohort, programmeName, "update");
        }

        private void RetrieveCohortByProgrammeName(CohortViewModel cohort, string programmeName, string operationType)
        {
            dropDownListCohort_update.Items.Clear();
            DDLAddCohort.Items.Clear();

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
                DDLAddCohort.Items.Add(row["Cohort"]);
            }
            else if (operationType == "update")
            {
                dropDownListCohort_update.Items.Add(row["Cohort"]);
            }
        }

        private void BtnAddModule_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                GetCohortIdByCohortName(module);
                SetText(module);
                SaveModule(module);
            }


        }

        private bool IsValid()
        {
            return true;
        }

        private void SaveModule(ModuleViewModel module)
        {
            DbConfiguration configuration = new DbConfiguration();
            SqlCommand com = new SqlCommand();
            DataSet dataSet = new DataSet();
            com.Connection = new SqlConnection(configuration.GetConnectionString());
            com.Parameters.Add(new SqlParameter("@Name", module.Name));
            com.Parameters.Add(new SqlParameter("@Code", module.Code));
            com.Parameters.Add(new SqlParameter("@ModuleStatus", module.ModuleStatus));
            com.Parameters.Add(new SqlParameter("@Semester", module.Semester));
            com.Parameters.Add(new SqlParameter("@SemesterYear", module.SemesterYear));
            com.Parameters.Add(new SqlParameter("@CohortId", module.CohortId));
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "AddModule";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(dataSet);

            MessageBox.Show("New module added");
        }

        private void GetCohortIdByCohortName(ModuleViewModel module)
        {
            DbConfiguration configuration = new DbConfiguration();
            SqlCommand com = new SqlCommand();
            DataSet dataSet = new DataSet();
            com.Connection = new SqlConnection(configuration.GetConnectionString());
            com.Parameters.Add(new SqlParameter("@cohortName", DDLAddCohort.SelectedItem.ToString()));
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "RetrieveCohortByCohortName";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(dataSet);

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                module.CohortId = Convert.ToInt32(row["CohortId"]);
            }
        }

        private void SetText(ModuleViewModel module)
        {
            module.Name = TxtbxModuleName.Text;
            module.Code = TxtbxModuleCode.Text;
            module.ModuleStatus = "active";
            module.Semester = Convert.ToInt32(ddlSemester.SelectedItem.ToString());
            module.SemesterYear = Convert.ToInt32(ddlYear.SelectedItem.ToString());
        }

        private void ButtonDeleteModule_Click(object sender, EventArgs e)
        {
            if(DropDownModule.SelectedIndex == -1)
            {
                MessageBox.Show("Select module to remove");
            }
            else
            {
                string moduleName = DropDownModule.SelectedItem.ToString();
                DeleteModule(moduleName);
                dropDownListProgramme_update.Items.Clear();
                dropDownListCohort_update.Items.Clear();
                DropDownModule.Items.Clear();
                RetrieveProgram();
            }
        }

        private void DeleteModule(string moduleName)
        {
            DbConfiguration configuration = new DbConfiguration();
            SqlCommand com = new SqlCommand();
            DataSet dataSet = new DataSet();
            com.Connection = new SqlConnection(configuration.GetConnectionString());
            com.Parameters.Add(new SqlParameter("@module", moduleName));
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "DeleteModule";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(dataSet);
        }

        private void dropDownListCohort_update_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cohortName = dropDownListCohort_update.SelectedItem.ToString();
            GetModuleByCohortName(cohortName);
        }

        private void GetModuleByCohortName(string cohortName)
        {
            DbConfiguration configuration = new DbConfiguration();
            SqlCommand com = new SqlCommand();
            DataSet dataSet = new DataSet();
            com.Connection = new SqlConnection(configuration.GetConnectionString());
            com.Parameters.Add(new SqlParameter("@cohort", cohortName ));
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "RetrieveModuleByCohortName";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(dataSet);

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                DropDownModule.Items.Add(row["name"]);
            }
        }
    }
}
