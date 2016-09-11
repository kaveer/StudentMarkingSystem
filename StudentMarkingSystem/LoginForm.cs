using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            try
            {
                UserViewModel user = new UserViewModel();
                if (MapViewModel(user) == false)
                    return;
                RetrieveUser(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            Regex reg = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (string.IsNullOrWhiteSpace(EmailAddressTextBox.Text) || !reg.IsMatch(EmailAddressTextBox.Text))
            {
                MessageBox.Show("Invalid email address");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(PasswordTextbox.Text))
            {
                MessageBox.Show("Enter Password");
                return false;
            }
            else
            {
                Security security = new Security();

                user.EmailAddress = EmailAddressTextBox.Text;
                user.UserPassword = security.PasswordEncryption(PasswordTextbox.Text);

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
                this.Hide();
                admin.Show();
            }
            if (user.UserType == "lecturer")
            {
                LecturerHomeForm lecturer = new LecturerHomeForm();
                this.Hide();
                lecturer.Show();
            }
            if (user.UserType == "superuser")
            {
                SuperUserForm superuser = new SuperUserForm();
                this.Hide();
                superuser.Show();
            }
        }
    }
}