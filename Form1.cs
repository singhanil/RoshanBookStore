using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_prac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelsubC.Visible = false;
        }


        private void hideSubMenu()
        {
            if (panelsubC.Visible == true)
                panelsubC.Visible = false;
        }


        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelsidemenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn__C_Click(object sender, EventArgs e)
        {
            showSubMenu(panelsubC);
        }

        private void btn_F_Click(object sender, EventArgs e)
        {
            //could write hideSubMenu();
            // Should change system drawing to int32 to transform panelsubC to desired height.
            //showSubMenuF(panelsubF);

        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }


        private void btn_N_Click(object sender, EventArgs e)
        {
            //could write hideSubMenu();

        }

        private void btnC_Click(object sender, EventArgs e)
        {

        }

        private void btnM_Click(object sender, EventArgs e)
        {

        }

        private void panelsubN_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}

