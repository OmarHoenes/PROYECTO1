using PROYECTO1.CLASES;
using System;
using System.Collections;
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
    public partial class frmRegistroUsuarios : Form
    {
        public frmRegistroUsuarios()
        {
            InitializeComponent();
        }
        //CREAR NUESTRO ARREGO ARRAYLIST
        ArrayList datosUsuarios = new ArrayList();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRevisar_Click(object sender, EventArgs e)
        {
            if ((txtN.Text == "") || (txtP.Text == ""))
            {
                errorProvider1.SetError(txtN, "Debe ingresar el nombre o los puntos");
                return;
            }
            errorProvider1.SetError(txtN, "");


            //genero instancia
            usuario miUsuario = new usuario();
            miUsuario.nombre = txtN.Text;
            miUsuario.puntos = Convert.ToInt32(txtP.Text);

            //agregar la info a la arraylist
            datosUsuarios.Add(miUsuario);

            //agregar la info al datagrid
            Datos.DataSource = null;
            Datos.DataSource = datosUsuarios;
            limpiar();


        }

        // limpiar
        private void limpiar()
        {

            txtN.Text = "";
            txtP.Text = "";
            txtN.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            guardarArchivo();
        }
        //metodo para guardar la info en un archivo de texto
        private void guardarArchivo()
        {
            //genero instancia de la clase usuario
            usuario miUsuario = new usuario();

            TextWriter escribir = new StreamWriter("Datos.txt");
            escribir.Close();
            foreach (usuario usuario in datosUsuarios)
            {
                StreamWriter agregar = File.AppendText("Datos.txt");
                agregar.WriteLine(usuario.nombre + "|" + usuario.puntos);
                agregar.Close();

            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            cargarUsuarios();
        }
        //metodo para leer el archivo de text
        public void cargarUsuarios()
        {
            try
            {
                StreamReader leer = new StreamReader("Datos.txt");
                string aux;
                string linea;
                string nombre;
                int puntos;
                int pos;

                // ciclo para lectura de los datos de los usuarios
                while ((linea = leer.ReadLine()) != null)
                {
                    //debemos extraer el nombre
                    pos = linea.IndexOf('|');
                    aux = linea.Substring(0, pos);
                    nombre = aux;

                    linea = linea.Substring(pos + 1);

                    //puntos
                    puntos = Convert.ToInt32(linea);

                    //genero instancia a la clase usuario
                    usuario miUsuario = new usuario();
                    miUsuario.nombre = nombre;
                    miUsuario.puntos = puntos;
                    //llenamos el arreglo de tipo arraylist
                    datosUsuarios.Add(miUsuario);
                    Datos.DataSource = null;
                    Datos.DataSource = datosUsuarios;


                }
                leer.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void frmRegistroUsuarios_Load(object sender, EventArgs e)
        {
            cargarUsuarios();
        }
    }
}
