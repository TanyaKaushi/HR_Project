using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace HR_System
{
    public partial class Attendence_IN : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        public Attendence_IN()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadRecords();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public void LoadRecords()
        {
            int i = 0;
            dataGridView2.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("select * from sites order by id", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
           //dataGridView2.Rows.Add(i, dr["id"].ToString(), dr["sitename"].ToString(), dr["address"].ToString(), dr["telephone"].ToString(), dr["email"].ToString());
            }
            dr.Close();
            cn.Close();

        }



    }
}
