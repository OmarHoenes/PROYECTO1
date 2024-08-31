using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO1.NivelMedio
{
    public partial class frmVectores : Form
    {
        public frmVectores()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtM_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmVectores_Load(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            txtX1.Enabled = false;
            txtY1.Enabled = false;
            txtX2.Enabled = false;
            txtY2.Enabled = false;
            
        }

        private void rdbBasico_CheckedChanged(object sender, EventArgs e)
        {
            Random r1 = new Random(DateTime.Now.Second);

            txtY1.Text = Convert.ToString(r1.Next(-10, 10));
            txtY2.Text = Convert.ToString(r1.Next(-10, 10));
            txtX1.Text = Convert.ToString(r1.Next(-10, 10));
            txtX2.Text = Convert.ToString(r1.Next(-10, 10));
        }

        private void rdbMedio_CheckedChanged(object sender, EventArgs e)
        {
            Random r1 = new Random(DateTime.Now.Second);

            txtY1.Text = Convert.ToString(r1.Next(-20, 50));
            txtY2.Text = Convert.ToString(r1.Next(-20, 50));
            txtX1.Text = Convert.ToString(r1.Next(-20, 50));
            txtX2.Text = Convert.ToString(r1.Next(-20, 50));
        }

        private void rdbAvanzado_CheckedChanged(object sender, EventArgs e)
        {
            Random r1 = new Random(DateTime.Now.Second);

            txtY1.Text = Convert.ToString(r1.Next(-50, 100));
            txtY2.Text = Convert.ToString(r1.Next(-50, 100));
            txtX1.Text = Convert.ToString(r1.Next(-50, 100));
            txtX2.Text = Convert.ToString(r1.Next(-50, 100));
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            rdbBasico.Checked = false;
            rdbMedio.Checked = false;
            rdbAvanzado.Checked = false;
            txtY1.Clear();
            txtY2.Clear();
            txtX1.Clear();
            txtX2.Clear();
            txtV.Clear();
        }
        int contB = 0, contM = 0;

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if (btnRevisar.Enabled == true)
            {
                btnNuevo.Enabled = true;
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1) Debe Generar Valores con el radio Button.\n2) Debe Agregar una respuesta. \n3) Debe Darle al Boton Revisar para verificar su respuesta. \n4)Al Tercer Error Termina el juego", "!!! Boton De Ayuda Suma de Vectores¡¡¡", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRevisar_Click(object sender, EventArgs e)
        {
            string y1, y2, x1, x2, rusuario,  rsistema;
             

            // asigarle varables a los valores de los cuadros de texto
            if ((txtY1.Text == "") || (txtY2.Text == "") || (txtX1.Text == "") || (txtX2.Text == "") || (txtV.Text == ""))
            {
                MessageBox.Show("No selecciono ninguno de los niveles o no ingreso su respuesta", "Error");

                return;
            }
            /*bool rm = Int32.Tryparse(txtV.Text, out rusuario);
            if (rm == false)
            {
                MessageBox.Show("Debe ingresar un valor númerico para A;B", "Error");
                txtV.Text = "";
                txtV.Focus();
                return;
            }*/
               //capturo los valores de los cuadros de texto

            y1 = Convert.ToString(txtY1.Text);
            y2 = Convert.ToString(txtY2.Text);
            x1 = Convert.ToString(txtX1.Text);
            x2 = Convert.ToString(txtX2.Text);
            //a1 = Convert.ToString(txtV.Text);
            //a2 = Convert.ToString(txtV.Text);
            rusuario = Convert.ToString(txtV.Text);

            //calcular

           
            rsistema = (int.Parse(x1) + int.Parse(x2)).ToString() + "," + (int.Parse(y1) + int.Parse(y2)).ToString();


            //comparar valores
            if (rsistema == rusuario)
            {
                contB++;
                MessageBox.Show("La respuesta es correcta " + "Respuestas correctas: " + contB);
                label9.Text = Convert.ToString(contB);
                txtY1.Text = "";
                txtY2.Text = "";
                txtX1.Text = "";
                txtX2.Text = "";
                txtV.Text = "";

            }
            else
            {
                contM++;
                MessageBox.Show("La respuesta es incorrecta " + "La respuesta correcta es: "  + rsistema.ToString());
                MessageBox.Show("Respuestas Incorrectas: " + contM);
                label8.Text = Convert.ToString(contM);
                txtY1.Text = "";
                txtY2.Text = "";
                txtX1.Text = "";
                txtX2.Text = "";
                txtV.Text = "";

            }
            if (contM == 3)
            {
                MessageBox.Show("JUEGO TERMINADO", "Limite de respuestas incorrectas");
                Close();
            }






        }
    }
}
