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
    public partial class ViewDepartment : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        public ViewDepartment()
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

                Departmant frm = new Departmant();


                frm.lblId.Text = dataGridView2[1, e.RowIndex].Value.ToString();
                frm.txtDepartmentName.Text = dataGridView2[2, e.RowIndex].Value.ToString();

                frm.btnSave.Enabled = false;
                frm.btnUpdate.Enabled = true;
                frm.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to Delete this Department?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    cn.Open();
                    cm = new SqlCommand("delete from Department where id like '" + dataGridView2[1, e.RowIndex].Value.ToString() + "'", cn);

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
            cm = new SqlCommand("select * from Department order by id", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGridView2.Rows.Add(i, dr["id"].ToString(), dr["departmentName"].ToString());
            }
            dr.Close();
            cn.Close();

        }








    }
}
