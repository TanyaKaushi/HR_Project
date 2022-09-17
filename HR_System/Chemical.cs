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
    public partial class Chemical : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
       // ViewChemical frmlist;
        public Chemical()
        //ViewChemical flist
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
           // frmlist = flist;
        }

        private void Chemical_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
                 try
            {
                if (MessageBox.Show("Are you sure you want to save this chemical?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTo chemical(chemicalName)VALUEs(@chemicalName)", cn);
                    cm.Parameters.AddWithValue("@chemicalName", txtChemical.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record Has Been Saved!");
                    // clear();
                    // frmlist.LoadRecords();
                    txtChemical.Clear();


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
                if (MessageBox.Show("Are you sure you want to Update this Brand?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ViewChemical frm = new ViewChemical();
                    cn.Open();
                    cm = new SqlCommand("update chemical set chemicalName = @chemicalName where id like '" + lblId.Text + "'", cn);
                    cm.Parameters.AddWithValue("@chemicalName", txtChemical.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    frm.LoadRecords();
                    MessageBox.Show("Record Has Been Updated!");
                    // clear();
                   

                    
                    this.Dispose();
                   

                }


            }
            catch (Exception ex)
            {

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
