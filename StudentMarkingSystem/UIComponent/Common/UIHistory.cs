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

namespace StudentMarkingSystem.UIComponent.Common
{
    public partial class UIHistory : UserControl
    {
        HistoryViewModel history = new HistoryViewModel();

        public UIHistory()
        {
            InitializeComponent();
        }

        private void UIHistory_Load(object sender, EventArgs e)
        {
            RetrieveHistory(history);
        }

        public void RetrieveHistory(HistoryViewModel history)
        {
            DbConfiguration configuration = new DbConfiguration();
            SqlCommand com = new SqlCommand();
            DataSet dataSet = new DataSet();
            com.Connection = new SqlConnection(configuration.GetConnectionString());
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "RetrieveHistory";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(dataSet);

            DataTable table = new DataTable();
            adapter.Fill(table);
            BindToGridView(table);

            if (dataSet.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No programme in the system");
                return;
            }

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
               // DropDownListProgramme.Items.Add(row["Programme"].ToString());
            }
        }

        private void BindToGridView(DataTable table)
        {
            GridViewProgramme.DataSource = table;
            GridViewProgramme.Columns[0].Visible = false;
            GridViewProgramme.Columns[1].Visible = false;
            GridViewProgramme.Columns[4].Visible = false;
            GridViewProgramme.Columns[5].Visible = false;
            GridViewProgramme.Columns[3].Width = 500;
            // GridViewProgramme.Columns[3].Visible = false;
            //dataGridView1.DataBindings.ToString();
        }
    }
}
