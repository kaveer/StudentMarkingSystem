using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using StudentMarkingSystem.Repository;
using System.Data.SqlClient;

namespace StudentMarkingSystem.UIComponent.Admin
{
    public partial class UILecturer : UserControl
    {
        Regex reg = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
        UserViewModel user = new UserViewModel();
        Security security = new Security();

        public UILecturer()
        {
            InitializeComponent();
        }

        private void BtnAddLecturer_Click(object sender, EventArgs e)
        {
            setUser(user);
            if (IsValidation(user))
            {
                try
                {
                    EncryptPassword(user);
                    AddLecturer(user);
                    MessageBox.Show("New Lecturer Added");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void AddLecturer(UserViewModel user)
        {
            AddUserCredentials(user);
            RetrieveUserId(user);
            AddUserInfo(user);


        }

        private void AddUserInfo(UserViewModel user)
        {
            DbConfiguration configuration = new DbConfiguration();
            SqlCommand com = new SqlCommand();
            DataSet dataSet = new DataSet();
            com.Connection = new SqlConnection(configuration.GetConnectionString());
            com.Parameters.Add(new SqlParameter("@userId", user.UserId));
            com.Parameters.Add(new SqlParameter("@firstname", user.UserFirstName));
            com.Parameters.Add(new SqlParameter("@lastname", user.UserLastName));
            com.Parameters.Add(new SqlParameter("@address", user.UserAddress));
            com.Parameters.Add(new SqlParameter("@contact", user.Contact));
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "AddUserInfo";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(dataSet);
        }

        private void RetrieveUserId(UserViewModel user)
        {
            DbConfiguration configuration = new DbConfiguration();
            SqlCommand com = new SqlCommand();
            DataSet dataSet = new DataSet();
            com.Connection = new SqlConnection(configuration.GetConnectionString());
            com.Parameters.Add(new SqlParameter("@email", user.EmailAddress));
            com.Parameters.Add(new SqlParameter("@password", user.UserPassword));
            com.Parameters.Add(new SqlParameter("@status", user.UserStatus));
            com.Parameters.Add(new SqlParameter("@type", user.UserType));
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "RetrieveUserIdByEmail";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(dataSet);

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                user.UserId = Convert.ToInt32(row["UserId"].ToString());
            }
        }

        private void AddUserCredentials(UserViewModel user)
        {
            DbConfiguration configuration = new DbConfiguration();
            SqlCommand com = new SqlCommand();
            DataSet dataSet = new DataSet();
            com.Connection = new SqlConnection(configuration.GetConnectionString());
            com.Parameters.Add(new SqlParameter("@email", user.EmailAddress));
            com.Parameters.Add(new SqlParameter("@password", user.UserPassword));
            com.Parameters.Add(new SqlParameter("@status", user.UserStatus));
            com.Parameters.Add(new SqlParameter("@type", user.UserType));
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "AddUserCredential";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(dataSet);
        }

        private void EncryptPassword(UserViewModel user)
        {
            user.UserPassword = security.PasswordEncryption(user.UserPassword);
        }

        private bool IsValidation(UserViewModel user)
        {
            bool result = true;
            if (string.IsNullOrWhiteSpace(user.EmailAddress))
            {
                MessageBox.Show("Enter Email Address");
                return result = false;
            }
            if (!reg.IsMatch(TxtEmail.Text))
            {
                MessageBox.Show("Invalid email format");
                return result = false;
            }
            if (!string.IsNullOrWhiteSpace(TxtEmail.Text))
            {
                result = security.IsMailExist(user);
            }
            if (string.IsNullOrWhiteSpace(user.UserPassword))
            {
                MessageBox.Show("Enter Password");
                return result = false;
            }
            if (user.UserPassword != user.ConfirmPassword)
            {
                MessageBox.Show("Password doesn't match");
                return result = false;
            }
            if (string.IsNullOrWhiteSpace(user.UserFirstName))
            {
                MessageBox.Show("Enter firstname");
                return result = false;
            }
            if (string.IsNullOrWhiteSpace(user.UserLastName))
            {
                MessageBox.Show("Enter Lastname");
                return result = false;
            }

            return result;
        }

        private void setUser(UserViewModel user)
        {
            if (string.IsNullOrWhiteSpace(TxtContact.Text))
                TxtContact.Text = "0";

            user.EmailAddress = TxtEmail.Text;
            user.UserPassword = TxtPassword.Text;
            user.ConfirmPassword = TxtConfirmPassword.Text;
            user.UserFirstName = TxtFirstName.Text;
            user.UserLastName = TxtLastName.Text;
            user.UserAddress = TxtAddress.Text;
            user.Contact = Convert.ToInt32(TxtContact.Text);
            user.UserStatus = "active";
            user.UserType = "lecturer";
        }

        private void BtnDeleteLecturer_Click(object sender, EventArgs e)
        {

        }

        private void UILecturer_Load(object sender, EventArgs e)
        {

        }

        public void RetrieveUser()
        {
            DbConfiguration configuration = new DbConfiguration();
            SqlCommand com = new SqlCommand();
            DataSet dataSet = new DataSet();
            com.Connection = new SqlConnection(configuration.GetConnectionString());
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "RetrieveUser";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(dataSet);
        }
    }
}
