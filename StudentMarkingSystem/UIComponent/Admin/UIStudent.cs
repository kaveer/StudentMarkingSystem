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
        string programmeName;
        string cohortName;
        string index;

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
                dropDownListProgramme_update.Items.Add(row["ProgramName"].ToString());
            }
        }

        private void DDLAddProgramme_SelectedIndexChanged(object sender, EventArgs e)
        {
            DDLAddCohort.Items.Clear();
            programmeName = DDLAddProgramme.SelectedItem.ToString();
            RetrieveCohortByProgrammeName(programmeName , "save");
        }

        private void dropDownListProgramme_update_SelectedIndexChanged(object sender, EventArgs e)
        {
            dropDownListCohort_update.Items.Clear();
            programmeName = dropDownListProgramme_update.SelectedItem.ToString();
            RetrieveCohortByProgrammeName(programmeName, "update/delete");
        }

        private void RetrieveCohortByProgrammeName(string programmeName ,string operationType)
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

            if(operationType == "save")
            {
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    DDLAddCohort.Items.Add(row["Cohort"]);
                }
            }
            if(operationType == "update/delete")
            {
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    dropDownListCohort_update.Items.Add(row["Cohort"]);
                }
            }

           
        }

        private void dropDownListCohort_update_SelectedIndexChanged(object sender, EventArgs e)
        {
            cohortName = dropDownListCohort_update.SelectedItem.ToString();
            RetrieveIndexByCohortName(cohortName , programmeName);
        }

        private void RetrieveIndexByCohortName(string cohortName , string programmeName)
        {
            DbConfiguration configuration = new DbConfiguration();
            SqlCommand com = new SqlCommand();
            DataSet dataSet = new DataSet();
            com.Connection = new SqlConnection(configuration.GetConnectionString());
            com.Parameters.Add(new SqlParameter("@cohortName", cohortName));
            com.Parameters.Add(new SqlParameter("@programmeName", programmeName));
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "RetrieveStudentDetailsByCohortName";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(dataSet);

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                dropDownlistIndex_update.Items.Add(row["StudentIndex"]);
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
            if (string.IsNullOrWhiteSpace(TxtbxIndex.Text))
            {
                MessageBox.Show("Enter index number");
                return;
            }
            if (string.IsNullOrWhiteSpace(TxtbxFirstName.Text))
            {
                MessageBox.Show("Enter firstname of student");
                return;
            }
            if (string.IsNullOrWhiteSpace(TxtbxLastname.Text))
            {
                MessageBox.Show("Enter lastname of student");
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
            if (string.IsNullOrWhiteSpace(TxtbxContact.Text))
            {
                TxtbxContact.Text = "0000000";
            }
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

        private void dropDownlistIndex_update_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = dropDownlistIndex_update.SelectedItem.ToString();
            RetriveStudentDetailsByIndex(cohortName, programmeName, index , student);
        }

        private void RetriveStudentDetailsByIndex(string cohortName, string programmeName, string index , StudentViewModel student)
        {
            DbConfiguration configuration = new DbConfiguration();
            SqlCommand com = new SqlCommand();
            DataSet dataSet = new DataSet();
            com.Connection = new SqlConnection(configuration.GetConnectionString());
            com.Parameters.Add(new SqlParameter("@cohortName", cohortName));
            com.Parameters.Add(new SqlParameter("@programmeName", programmeName));
            com.Parameters.Add(new SqlParameter("@index", index));
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "RetrieveStudentDetailsByIndex";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(dataSet);

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
              student.StudentFirstname =  studentFirstName_update.Text = row["StudentFirstname"].ToString();
              student.StudentLastname=  studentLastName_update.Text = row["StudentLastname"].ToString();
              student.StudentEmail =  emailAddress_update.Text = row["StudentEmail"].ToString();
              student.StudentAddress =  studentAddress_update.Text = row["StudentAddress"].ToString();
              student.StudentContact = Convert.ToInt32( contactNumber_update.Text = row["StudentContact"].ToString());
              student.IndexNo = index;
              student.StudentStatus = row["StudentStatus"].ToString();
              student.CohortId = Convert.ToInt32(row["CohortId"]);
              student.StudentId = Convert.ToInt32(row["StudentId"]);
            }
        }

        private void ButtonUpdateStudent_Click(object sender, EventArgs e)
        {
            GetStudentDetails(student);
            UpdateStudentDetails(student);

            
        }

        private void GetStudentDetails(StudentViewModel student)
        {
            student.StudentFirstname = studentFirstName_update.Text;
            student.StudentLastname = studentLastName_update.Text;
            student.StudentEmail = emailAddress_update.Text;
            student.StudentAddress = studentAddress_update.Text;
            student.StudentContact = Convert.ToInt32(contactNumber_update.Text);
        }

        private void UpdateStudentDetails(StudentViewModel student)
        {
            DbConfiguration configuration = new DbConfiguration();
            SqlCommand com = new SqlCommand();
            DataSet dataSet = new DataSet();
            com.Connection = new SqlConnection(configuration.GetConnectionString());
            com.Parameters.Add(new SqlParameter("@firstname", student.StudentFirstname));
            com.Parameters.Add(new SqlParameter("@lastname", student.StudentLastname));
            com.Parameters.Add(new SqlParameter("@email", student.StudentEmail));
            com.Parameters.Add(new SqlParameter("@address", student.StudentAddress));
            com.Parameters.Add(new SqlParameter("@contact", student.StudentContact));
            com.Parameters.Add(new SqlParameter("@studentId", student.StudentId));
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "UpdateStudentByIndex";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(dataSet);

            MessageBox.Show(string.Format("Student with index : {0} updated" , student.IndexNo));
        }

        private void ButtonDeleteStudentDetails_Click(object sender, EventArgs e)
        {
            DeleteStudentDetails(student);
        }

        private void DeleteStudentDetails(StudentViewModel student)
        {
            DbConfiguration configuration = new DbConfiguration();
            SqlCommand com = new SqlCommand();
            DataSet dataSet = new DataSet();
            com.Connection = new SqlConnection(configuration.GetConnectionString());
            com.Parameters.Add(new SqlParameter("@studentId" , student.StudentId));
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "DeleteStudentByIndex";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(dataSet);

            ClearControls();
            RetrieveProgram();
            MessageBox.Show("Record deleted");
        }

        private void ClearControls()
        {
            DDLAddProgramme.Items.Clear();
            dropDownListProgramme_update.Items.Clear();
            dropDownListCohort_update.Items.Clear();
            dropDownlistIndex_update.Items.Clear();

            studentFirstName_update.Text = "";
            studentLastName_update.Text = "";
            emailAddress_update.Text = "";
            studentAddress_update.Text = "";
            contactNumber_update.Text = "";
        }
    }
}