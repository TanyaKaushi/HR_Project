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
    public partial class ChemicalInventory : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
       

        public ChemicalInventory()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadDepartment();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this Chemical?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTo ChemicalHistory(chemicalname,qty,stockinby,purchesdate,unitprice,Total)VALUEs(@chemicalname,@qty,@stockinby,@purchesdate,@unitprice,@Total)", cn);
                    //chemicalname,qty,stockinby,purchesdate,unitprice,Total
                    cm.Parameters.AddWithValue("@chemicalname", txtChemicalName.Text);
                    cm.Parameters.AddWithValue("@qty", txtQty.Text);
                    cm.Parameters.AddWithValue("@stockinby", txtStockInBy.Text);
                    cm.Parameters.AddWithValue("@purchesdate", txtPurch.Value.Date);
                    cm.Parameters.AddWithValue("@unitprice", txtUnitPrice.Text);
                    cm.Parameters.AddWithValue("@Total", txtCost.Text);
                    


                    cm.ExecuteNonQuery();
                    cn.Close();
                    LoadDepartment();
                    MessageBox.Show("Record Has Been Saved!");
                    clear();
                  //  frmlist.LoadRecords();



                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void clear()
        {
            txtChemicalName.SelectedIndex = -1;
            txtQty.Text = "0";
            txtStockInBy.Clear();
            txtPurch.Value = DateTime.Now;
            txtUnitPrice.Text = "0";
            txtCost.Clear();


        }


        public void LoadDepartment()
        {

            txtChemicalName.Items.Clear();

            cn.Open();

            cm = new SqlCommand("select chemicalName from Chemical ", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                txtChemicalName.Items.Add(dr[0].ToString());



            }

            dr.Close();
            cn.Close();

        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            try {
                if (txtQty.Text != "" && txtUnitPrice.Text != "")
                {

                    // txtCost.Text = Convert.ToString(Convert.ToInt32(txtQty.Text) * Convert.ToInt32(txtUnitPrice.Text));
                    
                    txtCost.Text = Convert.ToString(Convert.ToInt32(txtQty.Text) * Convert.ToInt32(txtUnitPrice.Text));
                }
                else
                {
                    txtCost.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
