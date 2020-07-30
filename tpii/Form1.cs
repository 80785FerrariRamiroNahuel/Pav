using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpii
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            String usuario = txtUsuario.Text;
            String password = txtPassword.Text;
            if (usuario == "" || password == "")
            {
                MessageBox.Show("Ingrese un Usuario  y/o Contraseña", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
              

            }
            else
            if (usuario == "Admin" && password == "123456")
            {   
                MessageBox.Show("Login OK", "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


            }
            else
            {
                MessageBox.Show("Ingrese un Usuario  y/o Contraseña correcto", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}   
