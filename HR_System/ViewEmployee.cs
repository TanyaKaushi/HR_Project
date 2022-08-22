using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace HR_System
{
    public partial class ViewEmployee : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        public ViewEmployee()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadRecords();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {

                Employee frm = new Employee();


                frm.lblId.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                frm.txtEmpCode.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                frm.txtFullName.Text = dataGridView1[3, e.RowIndex].Value.ToString();
                frm.txtNic.Text = dataGridView1[4, e.RowIndex].Value.ToString();
                frm.txtAge.Text = dataGridView1[5, e.RowIndex].Value.ToString();
                frm.txtGender.Text = dataGridView1[6, e.RowIndex].Value.ToString();
                frm.txtDob.Text = dataGridView1[7, e.RowIndex].Value.ToString();
                frm.txtHomeAdd.Text = dataGridView1[8, e.RowIndex].Value.ToString();
                frm.txtMobileNo.Text = dataGridView1[9, e.RowIndex].Value.ToString();
                frm.txtOfficeNo.Text = dataGridView1[10, e.RowIndex].Value.ToString();
                frm.txtDepartment.Text = dataGridView1[11, e.RowIndex].Value.ToString();
                frm.txtEmployyeType.Text = dataGridView1[12, e.RowIndex].Value.ToString();
                frm.txtDesignation.Text = dataGridView1[13, e.RowIndex].Value.ToString();
                frm.txtHiredOn.Text = dataGridView1[14, e.RowIndex].Value.ToString();
                frm.txtEndOn.Text = dataGridView1[15, e.RowIndex].Value.ToString();
                

                frm.btnSave.Enabled = false;
                frm.btnUpdate.Enabled = true;
                frm.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to Delete this Employee?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    cn.Open();
                    cm = new SqlCommand("delete from EMPLOYEE_DETAILS where id like '" + dataGridView1[1, e.RowIndex].Value.ToString() + "'", cn);

                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record Has Been Deleted!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadRecords();
                }
            }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadRecords()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("select * from EMPLOYEE_DETAILS order by empCode", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGridView1.Rows.Add(i, dr["id"].ToString(), dr["empCode"].ToString(), dr["fullName"].ToString(), dr["nic"].ToString(), dr["age"].ToString(), dr["gender"].ToString(), dr["dob"].ToString(), dr["address"].ToString(), dr["mobileNo"].ToString(), dr["officeNumber"].ToString(), dr["department"].ToString(), dr["employeeType"].ToString(), dr["designation"].ToString(), dr["hiredOnDate"].ToString(), dr["endDate"].ToString());
            }
            dr.Close();
            cn.Close();

        }






    }
}
