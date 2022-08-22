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
    public partial class Departmant : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        public Departmant()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void Departmant_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this Brand?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTo Department(departmentName)VALUEs(@departmentName)", cn);
                    cm.Parameters.AddWithValue("@departmentName", txtDepartmentName.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record Has Been Saved!");
                 //   clear();
                  //  frmlist.LoadRecords();



                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
