using System;
using System.Collections.Concurrent;
using System.Windows.Forms;

namespace Parcial02POO
{
    public partial class frmMainMenu : Form
    {    

        private UserControl current;
        

        public bool Admin01;
        public string username;
        public frmMainMenu(string user, bool admin)
        {
            InitializeComponent();
            username = user;
            Admin01 = admin;
            current = null;
            current = mainUserMenu1;
            
        }
        

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)//Cambiar contra    
        {
            tableLayoutPanel1.Controls.Remove(current);
          
            
            tableLayoutPanel1.SetRowSpan(current, 4);
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)//Volver
        {
            tableLayoutPanel1.Controls.Remove(current);
            tableLayoutPanel1.Controls.Add(mainUserMenu1, 1, 0);
            current = mainUserMenu1;
            tableLayoutPanel1.SetRowSpan(current, 4); 
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            if (Admin01 == true)
            {
                
            }
        }
    }
}