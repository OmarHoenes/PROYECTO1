using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public void btnIngresar_Click(object sender, EventArgs e)
        {
            //declarar nuestras variable
            string usuario, clave;
            //asignarles el valor que se ingresa al textBox
            usuario = txtUsuario.Text;
            clave = txtClave.Text;
            //
           /* StreamWriter escribir = new StreamWriter(@"C:\Users\Omar\Desktop\archivo.txt", true);
            try
            {
                escribir.WriteLine("Jugador: " + txtUsuario.Text);
                escribir.WriteLine("Clave: " + txtClave.Text);

            }
            catch
            {
                MessageBox.Show("ERROR");
            }*/
            //
            //realizar algunas validaciones
            if (txtUsuario.Text == "") 
            {
                MessageBox.Show("Debe ingresar un usuario", "Advertencia");
                txtUsuario.Focus();
                return;
            }
            if (txtClave.Text == "")
            {
                MessageBox.Show("Debe ingresar la clave", "Advertencia");
                txtClave.Focus();
                return;
            }

            // generar una instancia al metodo "acceso " de la clase login
            //frmLogin login = new frmLogin();
            //(login.acceso(usuario, clave))
            //condiciones para poder acceder
            if ((usuario == "omar") && (clave == "123"))
            {
                //un instacia al formulario dos
                frmPrincipal fp = new frmPrincipal();
                this.Hide();
                fp.ShowDialog();
                this.Show();
                txtUsuario.Text = "";
                txtClave.Text = "";
                txtUsuario.Focus();
            }
            //condiciones para poder acceder
            if ((usuario == "ivan") && (clave == "123"))
            {
                //un instacia al formulario dos
                frmPrincipal fp = new frmPrincipal();
                this.Hide();
                fp.ShowDialog();
                this.Show();
                txtUsuario.Text = "";
                txtClave.Text = "";
                txtUsuario.Focus();
            }
            if ((usuario == "jose") && (clave == "123"))
            {
                //un instacia al formulario dos
                frmPrincipal fp = new frmPrincipal();
                this.Hide();
                fp.ShowDialog();
                this.Show();
                txtUsuario.Text = "";
                txtClave.Text = "";
                txtUsuario.Focus();
            }
            else
            {
                MessageBox.Show("El usuario o contraseña son iconrrectos", "Error");
                txtUsuario.Text = "";
                txtClave.Text = "";
                txtUsuario.Focus();
            }

            
        }

        // método para acceso del usuario al juego 
        public Boolean acceso(string usuario, string clave)
        { 
        if ((usuario == "omar") && (clave == "123"))
            {
                return true;
            }
            else { return false; }
               
        
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1) Debe ingresar su Usuario.\n2) Debe ingresar su Contraseña.\n3) Al tener los dos campos presione Ingresar", "!!! Boton De Ayuda ¡¡¡", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
    }
}
