using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using StudentMarkingSystem.Models;
using StudentMarkingSystem.Repository;

namespace StudentMarkingSystem.UIComponent.Admin
{
    public partial class UIStudent : UserControl
    {
        private StudentViewModel student = new StudentViewModel();

        public UIStudent()
        {
            InitializeComponent();
        }

        private void UIStudent_Load(object sender, EventArgs e)
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
                DDLAddProgramme.Items.Add(row["ProgramName"].ToString());
            }
        }

        private void DDLAddProgramme_SelectedIndexChanged(object sender, EventArgs e)
        {
            string programmeName = DDLAddProgramme.SelectedItem.ToString();
            RetrieveCohortByProgrammeName(programmeName);
        }

        private void RetrieveCohortByProgrammeName(string programmeName)
        {
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
                DDLAddCohort.Items.Add(row["Cohort"]);
            }
        }

        private void DDLAddCohort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cohortName = DDLAddCohort.SelectedItem.ToString();
            RetrieveCohortByCohortName(cohortName, student);
        }

        private void RetrieveCohortByCohortName(string cohortName, StudentViewModel student)
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
                student.CohortId = Convert.ToInt32(row["CohortId"]);
            }
        }

        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            if (DDLAddProgramme.Text == "")
            {
                MessageBox.Show("Select a programme");
                return;
            }
            if (DDLAddCohort.Text == "")
            {
                MessageBox.Show("Select cohort");
                return;
            }

            AddStudent(SetStudentDetails(student));
        }

        private void AddStudent(StudentViewModel student)
        {
            DbConfiguration configuration = new DbConfiguration();
            SqlCommand com = new SqlCommand();
            DataSet dataSet = new DataSet();
            com.Connection = new SqlConnection(configuration.GetConnectionString());
            com.Parameters.Add(new SqlParameter("@cohortId", student.CohortId));
            com.Parameters.Add(new SqlParameter("@index", student.IndexNo));
            com.Parameters.Add(new SqlParameter("@firstname", student.StudentFirstname));
            com.Parameters.Add(new SqlParameter("@lastname", student.StudentLastname));
            com.Parameters.Add(new SqlParameter("@email", student.StudentEmail));
            com.Parameters.Add(new SqlParameter("@address", student.StudentAddress));
            com.Parameters.Add(new SqlParameter("@contact", student.StudentContact));
            com.Parameters.Add(new SqlParameter("@status", student.StudentStatus));
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "AddStudent";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(dataSet);

            MessageBox.Show("New student added");
        }

        private StudentViewModel SetStudentDetails(StudentViewModel student)
        {
            student.IndexNo = TxtbxIndex.Text;
            student.StudentFirstname = TxtbxFirstName.Text;
            student.StudentLastname = TxtbxLastname.Text;
            student.StudentEmail = TxtbxEmail.Text;
            student.StudentAddress = TxtbxAddress.Text;
            student.StudentContact = Convert.ToInt32(TxtbxContact.Text);
            student.StudentStatus = "active";

            return student;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtbxIndex.Text = null;
            TxtbxFirstName.Text = null;
            TxtbxLastname.Text = null;
            TxtbxEmail.Text = null;
            TxtbxAddress.Text = null;
            TxtbxContact.Text = null;
        }
    }
}