using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial02POO
{
    public partial class Form1 : Form
    {
        private UserControl current;
        private Login log = new Login();
        public Form1()
        {
            InitializeComponent();
            current = log;
            DoubleBuffered = true;
            this.Hide();
        } 
    }
}