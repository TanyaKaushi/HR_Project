using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            customizeDesign();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }


        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200)
            {
                panelMenu.Width = 80;
               // menuPic.Visible = false;
                menuButton.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);

                    submenu_1.Visible = false;
                    submenu_2.Visible = false;
                    submenu_3.Visible = false;
                    submenu_4.Visible = false;
                    submenu_5.Visible = false;
                    submenu_6.Visible = false;
                    submenu_7.Visible = false;
                }
            }
            else
            {
                panelMenu.Width = 260;
                //menuPic.Visible = true;
                menuButton.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "    " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(20, 0, 0, 0);

                }
            }
        }

        //to show subform in the mainform
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel__Main.Controls.Add(childForm);
            panel__Main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

    


        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Dashboard());
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            openChildForm(new Employee());
        }

        private void Home_Click(object sender, EventArgs e)
        {

        }

        private void customizeDesign()
        {
            submenu_1.Visible = false;
            submenu_2.Visible = false;
            submenu_3.Visible = false;
            submenu_4.Visible = false;
            submenu_5.Visible = false;
            submenu_6.Visible = false;
            submenu_7.Visible = false;
            submenu_8.Visible = false;
        }

        private void hideSubmenu()
        {
            if (submenu_1.Visible == true)
                submenu_1.Visible = false;
            if (submenu_2.Visible == true)
                submenu_2.Visible = false;
            if (submenu_3.Visible == true)
                submenu_3.Visible = false;
            if (submenu_4.Visible == true)
                submenu_4.Visible = false;
            if (submenu_5.Visible == true)
                submenu_5.Visible = false;
            if (submenu_6.Visible == true)
                submenu_6.Visible = false;
            if (submenu_7.Visible == true)
                submenu_7.Visible = false;
            if (submenu_8.Visible == true)
                submenu_8.Visible = false;

        }

        private void showSubmenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

    

        private void menubtn_Click(object sender, EventArgs e)
        {
            //CollapseMenu();
        }

    
      

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubmenu(submenu_2);
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new Dashboard());
        }



        private void btn_AddEmployee_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Employee());
            
        }

      
        private void btn_ChemicalInventory_Click_1(object sender, EventArgs e)
        {
            openChildForm(new ChemicalInventory());
        }

        private void btn_ViewChemInventory_Click_1(object sender, EventArgs e)
        {
            openChildForm(new ViewChemical_Inventory());
        }

        private void btn_ChemicalInventory_Click(object sender, EventArgs e)
        {
            openChildForm(new ChemicalInventory());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            showSubmenu(submenu_3);
        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            showSubmenu(submenu_1);
        }

        private void btn_ViewEmployee_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewEmployee());
        }


        private void btn_ViewChemical_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewChemical());
        }

        private void btn_AddChemical_Click(object sender, EventArgs e)
        {
            openChildForm(new Chemical());
        }

        private void btn_AddDepartment_Click(object sender, EventArgs e)
        {
            openChildForm(new Departmant());
        }

        private void btn_Department_Click(object sender, EventArgs e)
        {
            showSubmenu(submenu_4);
        }

        private void btn_ViewDepartment_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewDepartment());
        }

        private void btn_Site_Click(object sender, EventArgs e)
        {
            showSubmenu(submenu_5);
        }

        private void btn_Other1_Click(object sender, EventArgs e)
        {
            showSubmenu(submenu_6);
        }

        private void btn_Other2_Click(object sender, EventArgs e)
        {
            showSubmenu(submenu_7);
        }

        private void btn_AddSite_Click(object sender, EventArgs e)
        {
            openChildForm(new Sites());
        }

        private void btn_ViewSite_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewSites());
        }

        private void btnAttencenceIn_Click(object sender, EventArgs e)
        {
            openChildForm(new Attendence_IN());
        }

        private void btn_ChequeBook_Click(object sender, EventArgs e)
        {
            showSubmenu(submenu_8);
        }

        private void btn_ViewChequeBook_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewChequeBook());
        }

        private void btn_AddChequeBook_Click(object sender, EventArgs e)
        {
            openChildForm(new ChequeBook());
        }
    }
}
