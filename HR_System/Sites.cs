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
    public partial class Sites : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        public Sites()
        {
            InitializeComponent();
           
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this Site?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTo sites(sitename,address,telephone,email)VALUEs(@sitename,@address,@telephone,@email)", cn);
                    cm.Parameters.AddWithValue("@sitename", txtName.Text);
                    cm.Parameters.AddWithValue("@address", txtAddress.Text);
                    cm.Parameters.AddWithValue("@telephone", txtNumber.Text);
                    cm.Parameters.AddWithValue("@email", txtEmail.Text);
                    clear();
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record Has Been Saved!");
                  //  clear();
                  //  frmlist.LoadRecords();



                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to Update this department?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("update sites set sitename = @sitename, address = @address, telephone = @telephone, email = @email where id like '" + lbId.Text + "'", cn);
                    //sitename,address,telephone,email

                    cm.Parameters.AddWithValue("@sitename", txtName.Text);
                    cm.Parameters.AddWithValue("@address", txtAddress.Text);
                    cm.Parameters.AddWithValue("@telephone", txtNumber.Text);
                    cm.Parameters.AddWithValue("@email", txtEmail.Text);


                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record Has Been Updated!");
                    clear();
                    //   frmlist.LoadRecords();

                    this.Dispose();


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void clear()
        {

            txtAddress.Clear();
            txtEmail.Clear();
            txtName.Clear();
            txtNumber.Clear();


        }







    }
}
