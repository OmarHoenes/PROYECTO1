using PROYECTO1.CLASES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO1.OperacionesBasicas
{
    public partial class frmDivision : Form
    {
        public frmDivision()
        {
            InitializeComponent();
        }

        private void frmDivision_Load(object sender, EventArgs e)
        {
            txtA.Enabled = false;
            txtB.Enabled = false;
        }

        private void rdbBasico_CheckedChanged(object sender, EventArgs e)
        {
            Random r1 = new Random(DateTime.Now.Second);

            txtA.Text = Convert.ToString(r1.Next(1, 10));
            txtB.Text = Convert.ToString(r1.Next(1, 10));

        }

        private void rdbMedio_CheckedChanged(object sender, EventArgs e)
        {
            Random r1 = new Random(DateTime.Now.Second);

            txtA.Text = Convert.ToString(r1.Next(10, 100));
            txtB.Text = Convert.ToString(r1.Next(10, 100));
        }

        private void rdbAvanzado_CheckedChanged(object sender, EventArgs e)
        {
            Random r1 = new Random(DateTime.Now.Second);

            txtA.Text = Convert.ToString(r1.Next(100, 999));
            txtB.Text = Convert.ToString(r1.Next(100, 999));
        }
        //publico
        int contB = 0, contM = 0;

        private void procedimiento()
            {
            //declarar variable
            int a, b, rusuario, rsistema;

            // asigarle variables a los valores de los cuadros de texto
            if ((txtA.Text == "") || (txtB.Text == "") || (txtR.Text == ""))
            {
                MessageBox.Show("No selecciono ninguno de los ivels o no ingreso su respuesta", "Error");
                txtR.Focus();
                return;
            }
            bool r1 = int.TryParse(txtR.Text, out rusuario);
            if (r1 == false)
            {
                MessageBox.Show("Debe ingresar un valor númerico");
                txtR.Clear();
                txtR.Focus();
                return;
            }

            a = Convert.ToInt32(txtA.Text);
            b = Convert.ToInt32(txtB.Text);
             rusuario = Convert.ToInt32(txtR.Text);

            //calcular
            //rsistema = a / b;
            claseDivision cd = new claseDivision();
            rsistema = Convert.ToInt32(cd.Divi(a, b));

            //COMPARAR VALORES
            intentos(rusuario, rsistema);

        }

        private void btnRevisar_Click(object sender, EventArgs e)
        {
           procedimiento();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1) Debe Generar Valores con el radio Button.\n2) Debe Agregar una respuesta. \n3) Debe Darle al Boton Revisar para verificar su respuesta. \n4)Al Tercer Error Termina el juego", "!!! Boton De Ayuda Division ¡¡¡", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void intentos(int rusuario, int rsistema)
        {
            //comparar valores
            if (rsistema == rusuario)
            {
                contB++;
                MessageBox.Show("La respuesta es correcta " + "Respuestas correctas: " + contB);
                label5.Text = Convert.ToString(contB);
                txtA.Text = "";
                txtB.Text = "";
                txtR.Text = "";

            }
            else
            {
                contM++;
                MessageBox.Show("La respuesta es incorrecta" + "La respuesta correcta es: " + rsistema);
                MessageBox.Show("Respuestas Incorrectas: " + contM);
                label6.Text = Convert.ToString(contM);
                txtA.Text = "";
                txtB.Text = "";
                txtR.Text = "";
            }
            if (contM == 3)
            {
                MessageBox.Show("JUEGO TERMINADO", "Limite de respuestas incorrectas");
                Close();
            }
        }
    }
}
