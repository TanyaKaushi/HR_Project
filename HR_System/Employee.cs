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
    public partial class Employee : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public Employee()
        {
            InitializeComponent(); 
            cn = new SqlConnection(dbcon.MyConnection());
            LoadDepartment();
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cn.Close();
            try
            {
                if (MessageBox.Show("Are you sure you want to save this Brand?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTo EMPLOYEE_DETAILS(empCode,fullName,gender,age,nic,dob,address,mobileNo,officeNumber,department,employeeType,designation,hiredOnDate,endDate)" +
                        "VALUEs(@empCode,@fullName,@gender,@age,@nic,@dob,@address,@mobileNo,@officeNumber,@department,@employeeType,@designation,@hiredOnDate,@endDate)", cn);
                   // empCode,fullName,gender,nic,dob,address,mobileNo,officeNumber,department,employeeType,designation,hiredOnDate,endDate

                    cm.Parameters.AddWithValue("@empCode", txtEmpCode.Text);
                    cm.Parameters.AddWithValue("@fullName", txtFullName.Text);
                    cm.Parameters.AddWithValue("@gender", txtGender.Text);
                    cm.Parameters.AddWithValue("@age", txtAge.Text);
                    cm.Parameters.AddWithValue("@nic", txtNic.Text);
                   
                    cm.Parameters.AddWithValue("@dob", txtDob.Value.Date);
                    cm.Parameters.AddWithValue("@address", txtHomeAdd.Text);
                    cm.Parameters.AddWithValue("@mobileNo", txtMobileNo.Text);
                    cm.Parameters.AddWithValue("@officeNumber", txtOfficeNo.Text);
                    cm.Parameters.AddWithValue("@department", txtDepartment.Text);
                    cm.Parameters.AddWithValue("@employeeType", txtEmployyeType.Text);
                    cm.Parameters.AddWithValue("@designation", txtDesignation.Text);
                    cm.Parameters.AddWithValue("@hiredOnDate", txtHiredOn.Value.Date);
                    cm.Parameters.AddWithValue("@endDate", txtEndOn.Value.Date);
                    
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
            
            txtEmpCode.Clear();
            txtFullName.Clear();
            txtGender.SelectedIndex = -1;
            txtAge.Clear();
            txtNic.Clear();

            txtDob.Value = DateTime.Now;
            txtHomeAdd.Clear(); 
            txtMobileNo.Clear();
            txtOfficeNo.Clear();
            txtDepartment.SelectedIndex = -1;
            txtEmployyeType.SelectedIndex = -1;
            txtDesignation.Clear();
            txtHiredOn.Value = DateTime.Now;
            txtEndOn.Value = DateTime.Now;


        }

        public void LoadDepartment()
        {

            txtDepartment.Items.Clear();

            cn.Open();

            cm = new SqlCommand("select departmentName from Department ", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                txtDepartment.Items.Add(dr[0].ToString());



            }
           
            dr.Close();
            cn.Close();

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            LoadDepartment();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (MessageBox.Show("Are you sure you want to Update this Employee?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("update EMPLOYEE_DETAILS set empCode = @empCode,fullName = @fullName,gender = @gender,age = @age,nic = @nic,dob = @dob,address = @address,mobileNo = @mobileNo,officeNumber = @officeNumber,department = @department,employeeType = @employeeType,designation = @designation,hiredOnDate = @hiredOnDate,endDate = @endDate " +
                        "where id like '" + lblId.Text + "'", cn);


                    // empCode = @empCode,fullName = @fullName,gender = @gender,age = @age,nic = @nic,dob = @dob,address = @address,mobileNo = @mobileNo,officeNumber = @officeNumber,department = @department,employeeType = @employeeType,designation = @designation,hiredOnDate = @hiredOnDate,endDate = @endDate


                    cm.Parameters.AddWithValue("@empCode", txtEmpCode.Text);
                    cm.Parameters.AddWithValue("@fullName", txtFullName.Text);
                    cm.Parameters.AddWithValue("@gender", txtGender.Text);
                    cm.Parameters.AddWithValue("@age", txtAge.Text);
                    cm.Parameters.AddWithValue("@nic", txtNic.Text);

                    cm.Parameters.AddWithValue("@dob", txtDob.Value.Date);
                    cm.Parameters.AddWithValue("@address", txtHomeAdd.Text);
                    cm.Parameters.AddWithValue("@mobileNo", txtMobileNo.Text);
                    cm.Parameters.AddWithValue("@officeNumber", txtOfficeNo.Text);
                    cm.Parameters.AddWithValue("@department", txtDepartment.Text);
                    cm.Parameters.AddWithValue("@employeeType", txtEmployyeType.Text);
                    cm.Parameters.AddWithValue("@designation", txtDesignation.Text);
                    cm.Parameters.AddWithValue("@hiredOnDate", txtHiredOn.Value.Date);
                    cm.Parameters.AddWithValue("@endDate", txtEndOn.Value.Date);


                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record Has Been Updated!");
                    clear();

                    ViewEmployee frm = new ViewEmployee();
                    frm.LoadRecords();

                    this.Dispose();


                }


            }
            catch (Exception ex)
            {

            }

        }

        private void txtEmpCode_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
