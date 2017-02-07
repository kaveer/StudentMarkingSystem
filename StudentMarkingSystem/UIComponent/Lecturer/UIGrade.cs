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
        GradeViewModel grade = new GradeViewModel();
        HistoryViewModel history = new HistoryViewModel();

        public UIGrade()
        {
            InitializeComponent();
        }

        private void UIGrade_Load(object sender, EventArgs e)
        {
            RetrieveProgram();

            grade.userId = LoginForm.userId;
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
            RetrieveStudentByCohortName(cohortName);
        }

        private void RetrieveStudentByCohortName(string cohortName)
        {
            DdlStudent.Items.Clear();

            DbConfiguration configuration = new DbConfiguration();
            SqlCommand com = new SqlCommand();
            DataSet dataSet = new DataSet();
            com.Connection = new SqlConnection(configuration.GetConnectionString());
            com.Parameters.Add(new SqlParameter("@cohort", cohortName));
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "RetrieveStudentByCohortName";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(dataSet);

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                DdlStudent.Items.Add(row["firstname"] + " " + row["lastname"]);
            }
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

        private void BtnAddGrade_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                
                SetText();
                ChangeGradeStatus();
                SaveGrade();
                SaveHistory();
                MessageBox.Show("Grade successfully saved");
            }
        }

        private void ChangeGradeStatus()
        {
            DbConfiguration configuration = new DbConfiguration();
            SqlCommand com = new SqlCommand();
            DataSet dataSet = new DataSet();
            com.Connection = new SqlConnection(configuration.GetConnectionString());
            //com.Parameters.Add(new SqlParameter("@userId", grade.userId));
            com.Parameters.Add(new SqlParameter("@moduleId", grade.moduleId));
            com.Parameters.Add(new SqlParameter("@StudentId", grade.studentId));
            //com.Parameters.Add(new SqlParameter("@grade", grade.grade));
            com.Parameters.Add(new SqlParameter("@gradeStatus", "0"));
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "UpdateGradeStatus";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(dataSet);
        }

        private void SetText()
        {
            grade.grade = Convert.ToDecimal(txtbxGrade.Text);
            grade.gradeStatus = "active";
        }

        private void SaveHistory()
        {
            SetHistoryModel();

            DbConfiguration configuration = new DbConfiguration();
            SqlCommand com = new SqlCommand();
            DataSet dataSet = new DataSet();
            com.Connection = new SqlConnection(configuration.GetConnectionString());
            com.Parameters.Add(new SqlParameter("@moduleId", history.moduleId));
            com.Parameters.Add(new SqlParameter("@historyDate", history.historyDate));
            com.Parameters.Add(new SqlParameter("@historyDescription", history.historyDescription));
            com.Parameters.Add(new SqlParameter("@status", history.historyStatus));
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "AddHistory";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(dataSet);
        }

        private void SetHistoryModel()
        {
            history.moduleId = grade.moduleId;
            history.historyDate = DateTime.Now;
            history.historyDescription = string.Format("Grade {2} added for student {0} by lecturer {1} for the module {3}", DdlStudent.SelectedItem.ToString(), LoginForm.userName , grade.grade , DdlModule.SelectedItem.ToString());
            history.historyStatus = "active";
        }

        private void SaveGrade()
        {
            DbConfiguration configuration = new DbConfiguration();
            SqlCommand com = new SqlCommand();
            DataSet dataSet = new DataSet();
            com.Connection = new SqlConnection(configuration.GetConnectionString());
            com.Parameters.Add(new SqlParameter("@userId", grade.userId));
            com.Parameters.Add(new SqlParameter("@moduleId", grade.moduleId));
            com.Parameters.Add(new SqlParameter("@StudentId", grade.studentId));
            com.Parameters.Add(new SqlParameter("@grade", grade.grade));
            com.Parameters.Add(new SqlParameter("@gradeStatus", grade.gradeStatus));
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "AddGrade";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(dataSet);
        }

        private bool IsValid()
        {
            bool result = true;

            if (DdlProgramme.SelectedIndex == -1)
            {
                MessageBox.Show("Select programme");
                return false;
            }
            if (DdlCohort.SelectedIndex == -1)
            {
                MessageBox.Show("Select cohort");
                return false;
            }
            if (DdlModule.SelectedIndex == -1)
            {
                MessageBox.Show("Select module");
                return false;
            }
            if (DdlStudent.SelectedIndex == -1)
            {
                MessageBox.Show("Select student");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtbxGrade.Text))
            {
                MessageBox.Show("Enter grade for the selected student");
                return false;
            }

            return result;
        }

        private void txtbxGrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            const int BACKSPACE = 8;
            const int DECIMAL_POINT = 46;
            const int ZERO = 48;
            const int NINE = 57;
            const int NOT_FOUND = -1;

            int keyvalue = (int)e.KeyChar; // not really necessary to cast to int

            if ((keyvalue == BACKSPACE) ||
            ((keyvalue >= ZERO) && (keyvalue <= NINE))) return;
            // Allow the first (but only the first) decimal point
            if ((keyvalue == DECIMAL_POINT) &&
            (txtbxGrade.Text.IndexOf(".") == NOT_FOUND)) return;
            // Allow nothing else
            e.Handled = true;
        }

        private void DdlModule_SelectedIndexChanged(object sender, EventArgs e)
        {
            string moduleName = DdlModule.SelectedItem.ToString();

            GetModuleIdBymoduleName(moduleName);
        }

        private void GetModuleIdBymoduleName(string moduleName)
        {
            DbConfiguration configuration = new DbConfiguration();
            SqlCommand com = new SqlCommand();
            DataSet dataSet = new DataSet();
            com.Connection = new SqlConnection(configuration.GetConnectionString());
            com.Parameters.Add(new SqlParameter("@moduleName", moduleName));
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "RetrieveModuleIdByModuleName";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(dataSet);

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                grade.moduleId = Convert.ToInt32(row["moduleId"].ToString());
            }
        }

        private void DdlStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] student = DdlStudent.SelectedItem.ToString().Split(' ');

            GetStudentIdByStudentName(student);
        }

        private void GetStudentIdByStudentName(string[] student)
        {
            DbConfiguration configuration = new DbConfiguration();
            SqlCommand com = new SqlCommand();
            DataSet dataSet = new DataSet();
            com.Connection = new SqlConnection(configuration.GetConnectionString());
            com.Parameters.Add(new SqlParameter("@firstname", student[0]));
            com.Parameters.Add(new SqlParameter("@lastname", student[1]));
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "RetrieveStudentIdByStudentName";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(dataSet);

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                grade.studentId = Convert.ToInt32(row["studentId"].ToString());
            }
        }
    }
}
