using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazEmplames
{
    public partial class Login : Form
    {
        public bool loggeado;

        public Login()
        {
            InitializeComponent();
        }

        public bool Logging(string in_user, string in_pass)
        {
            string user = "admin";
            string pass = "admin";

            return (user == in_user && pass == in_pass);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loggeado = Logging(txtUser.Text, txtPass.Text);
            if(loggeado)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas", "Error de Autenticacion");
            }
        }
    }
}
