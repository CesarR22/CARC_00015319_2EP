using System;
using System.Data;
using System.Windows.Forms;

namespace Parcial02POO
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e) 
        {
            if (TxtBoxUser.Text.Equals("") || TxtBoxPass.Text.Equals(""))
            {
                MessageBox.Show("CAMPOS VACIOS");
            }
            else
            {
                try
                {
                    string query = $"SELECT username, userType FROM APPUSER WHERE username = '{TxtBoxUser.Text}' " +
                                   $"AND password = '{TxtBoxPass.Text}'";

                    var command = ConnectionDB.ExecuteQuery(query);

                    DataTableReader dr;
                    dr = command.CreateDataReader();
                    string user;
                    bool Admin = true;

                    if (dr.Read())
                    {
                        Admin = dr.GetBoolean(1);
                        user = dr.GetString(0);
                        MessageBox.Show("Inicio Correctamente");
                        if (Admin == true)
                        {
                            MessageBox.Show("Bienvenido Admin " + user);
                            
                        }
                        else
                        {
                            MessageBox.Show("Bienvenido " + user);
                        }

                        frmMainMenu ventana = new frmMainMenu(user, Admin);
                        ventana.ShowDialog();

                    }
                    else
                        MessageBox.Show("Usuario o Contraseña incorrectas");

                }
                catch (Exception exception)
                {
                    MessageBox.Show("ERROR!!!");
                }
            }
        }
        private void TxtBoxPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar((Keys.Enter))) LoginButton_Click(sender, e);
        }
    }
}