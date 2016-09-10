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
using StudentMarkingSystem.Forms;
using StudentMarkingSystem.Repository;

namespace StudentMarkingSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            UserViewModel user = new UserViewModel();
            if (MapViewModel(user) == false)
                return;
            RetrieveUser(user);
        }

        public void RetrieveUser(UserViewModel user)
        {
            DbConfiguration configuration = new DbConfiguration();

            SqlCommand com = new SqlCommand();
            DataSet dataSet = new DataSet();
            com.Connection = new SqlConnection(configuration.GetConnectionString());
            com.Parameters.Add(new SqlParameter("@EmailAddress", user.EmailAddress));
            com.Parameters.Add(new SqlParameter("@Password", user.UserPassword));
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "Login";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(dataSet);

            if (dataSet.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No account with this credential");
                return;
            }
            else
            {
                foreach (DataRow item in dataSet.Tables[0].Rows)
                {
                    user.UserId = Convert.ToInt32(item["UserId"]);
                    user.UserInfoId = Convert.ToInt32(item["UserInfoId"]);
                    user.UserFirstName = item["UserFirstName"].ToString();
                    user.UserLastName = item["UserLastName"].ToString();
                    user.EmailAddress = item["EmailAddress"].ToString();
                    user.UserAddress = item["UserAddress"].ToString();
                    user.Contact = Convert.ToInt32(item["Contact"]);
                    user.UserPassword = item["UserPassword"].ToString();
                    user.UserStatus = item["UserStatus"].ToString();
                    user.UserType = item["UserType"].ToString();
                }

                if (!CheckStatus(user) == true)
                    return;
                CheckType(user);
            }
        }

        public bool MapViewModel(UserViewModel user)
        {
            if (string.IsNullOrWhiteSpace(EmailAddressTextBox.Text))
            {
                MessageBox.Show("Enter Email Address");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(PasswordTextbox.Text))
            {
                MessageBox.Show("Enter Password");
                return false;
            }
            else
            {
                user.EmailAddress = EmailAddressTextBox.Text;
                user.UserPassword = PasswordTextbox.Text;
                return true;
            }
        }

        public bool CheckStatus(UserViewModel user)
        {
            if (user.UserStatus == "deactive")
            {
                MessageBox.Show("This Account is deactivated");
                return false;
            }

            return true;
        }

        public void CheckType(UserViewModel user)
        {
            if (user.UserType == "admin")
            {
                AdminHomeForm admin = new AdminHomeForm();
                admin.Show();
            }
            if (user.UserType == "lecturer")
            {
                LecturerHomeForm lecturer = new LecturerHomeForm();
                lecturer.Show();
            }
        }
    }
}