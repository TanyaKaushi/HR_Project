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
    public partial class ViewChemical_Inventory : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();

        public ViewChemical_Inventory()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadRecords();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView2.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to Delete this History?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    cn.Open();
                    cm = new SqlCommand("delete from ChemicalHistory where id like '" + dataGridView2[1, e.RowIndex].Value.ToString() + "'", cn);

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
            cm = new SqlCommand("select * from ChemicalHistory where purchesdate between '" + datetime1.Value.ToString() + "' and '" + datetime2.Value.ToString() + "' order by id", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGridView2.Rows.Add(i, dr["id"].ToString(), dr["chemicalname"].ToString(), dr["qty"].ToString(), dr["stockinby"].ToString(), dr["purchesdate"].ToString(), dr["unitprice"].ToString(), dr["Total"].ToString());
            }
            dr.Close();
            cn.Close();

        }

        private void datetime1_ValueChanged(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void datetime2_ValueChanged(object sender, EventArgs e)
        {
            LoadRecords();
        }
    }
}
