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
    
    public partial class ViewSites : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        public ViewSites()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadRecords();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView2.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {

                Sites frm = new Sites();


                frm.lbId.Text = dataGridView2[1, e.RowIndex].Value.ToString();
                frm.txtName.Text = dataGridView2[2, e.RowIndex].Value.ToString();
                frm.txtAddress.Text = dataGridView2[3, e.RowIndex].Value.ToString();
                frm.txtNumber.Text = dataGridView2[4, e.RowIndex].Value.ToString();
                frm.txtEmail.Text = dataGridView2[5, e.RowIndex].Value.ToString();

                frm.btnSave.Enabled = false;
                frm.btnUpdate.Enabled = true;
                frm.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to Delete this site?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    cn.Open();
                    cm = new SqlCommand("delete from sites where id like '" + dataGridView2[1, e.RowIndex].Value.ToString() + "'", cn);

                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record Has Been Deleted!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadRecords();
                }
            }

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
                dataGridView2.Rows.Add(i, dr["id"].ToString(), dr["sitename"].ToString(), dr["address"].ToString(), dr["telephone"].ToString(), dr["email"].ToString());
            }
            dr.Close();
            cn.Close();

        }



    }
}
