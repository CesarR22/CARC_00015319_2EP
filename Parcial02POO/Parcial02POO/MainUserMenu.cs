using System;
using System.Windows.Forms;

namespace Parcial02POO
{
    public partial class MainUserMenu : UserControl
    {
        private bool AdminUser = false;
        public MainUserMenu()
        {
            InitializeComponent();
            TabForUsers();
        }

        public void TabForUsers()
        {
            if (AdminUser == true)
            {
                tabMenu.TabPages.Remove(Order);
                tabMenu.TabPages.Remove(Address);
                tabMenu.TabPages.Remove(UserOrderList);
            }
            else
            {
                tabMenu.TabPages[3].Hide();
                tabMenu.TabPages[4].Hide();
                tabMenu.TabPages[5].Hide();
            }
        }

        private void Users_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}