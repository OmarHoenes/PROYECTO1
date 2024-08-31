using PROYECTO1.CLASES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PROYECTO1.NivelMedio
{
    public partial class frmTeoremaPitagoras : Form
    {
        public frmTeoremaPitagoras()
        {
            InitializeComponent();
        }

        private void TeoremaPitagoras_Load(object sender, EventArgs e)
        {
              txtA.Enabled = false;
              txtB.Enabled = false;
              txtC.Enabled = false; 

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rdbBasico_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbHip.Checked == true)
            {
                txtA.Enabled = false;
                txtB.Enabled = false;
                Random r1 = new Random(DateTime.Now.Second);

                txtA.Text = Convert.ToString(r1.Next(1, 10));
                txtB.Text = Convert.ToString(r1.Next(1, 10));
            }
            if (rdbHip.Checked == false)
            {
                txtA.Enabled = true;
                txtB.Enabled = true;
                txtA.Clear();
                txtB.Clear();
            }
        }

        private void rdbMedio_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbOp.Checked == true)
            {
                txtC.Enabled = false;
                txtB.Enabled = false;
                Random r1 = new Random(DateTime.Now.Second);

                txtC.Text = Convert.ToString(r1.Next(10, 100));
                txtB.Text = Convert.ToString(r1.Next(10, 100));
            }
            if (rdbOp.Checked == false)
            {
                txtC.Enabled = true;
                txtB.Enabled = true;
                txtC.Clear();
                txtB.Clear();
            }
        }


        private void rdbAd_CheckedChanged(object sender, EventArgs e)
        {

            if (rdbAd.Checked == true)
            {
                txtC.Enabled = false;
                txtA.Enabled = false;
                Random r1 = new Random(DateTime.Now.Second);

                txtC.Text = Convert.ToString(r1.Next(100, 999));
                txtA.Text = Convert.ToString(r1.Next(100, 999));
            }
            if (rdbAd.Checked == false)
            {
                txtC.Enabled = true;
                txtA.Enabled = true;
                txtC.Clear();
                txtA.Clear();
            }
        }


        private void btnGenerar_Click(object sender, EventArgs e)
        {


        }
        int contB = 0, contM = 0;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void limpiar()
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            rdbHip.Checked = false;
            rdbAd.Checked = false;
            rdbOp.Checked = false;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnRevisar_Click(object sender, EventArgs e)
        {

            procedimiento();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1) Debe Generar Valores con el radio Button.\n2) Debe Agregar una respuesta. \n3) Debe Darle al Boton Revisar para verificar su respuesta. \n4)Al Tercer Error Termina el juego", "!!! Boton De Ayuda Teorema de Pitagoras¡¡¡", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void procedimiento()
        {
            double a, b, c, rsistema, rsistemaO, rsistemaA, rusuario, rusuarioO, rusuarioA;

            if (rdbHip.Checked == false && rdbOp.Checked == false && rdbAd.Checked == false)
            {

                MessageBox.Show("Debe seleccionar una opción", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                groupBox1.BackColor = Color.Red;

                return;
            }
            //VALIDACION PARA QUE NO INGRESEN LETRAS
            bool rm = double.TryParse(txtC.Text, out rusuario);
            if (rm == false)
            {
                MessageBox.Show("Debe ingresar un valor númerico para C", "Error");
                txtC.Text = "";
                txtC.Focus();
                return;
            }
            bool r = double.TryParse(txtA.Text, out rusuarioO);
            if (r == false)
            {
                MessageBox.Show("Debe ingresar un valor númerico para A", "Error");
                txtA.Text = "";
                txtA.Focus();
                return;
            }
            bool br = double.TryParse(txtB.Text, out rusuarioA);
            if (br == false)
            {
                MessageBox.Show("Debe ingresar un valor númerico para B", "Error");
                txtB.Text = "";
                txtB.Focus();
                return;
            }


            if (rdbHip.Checked == true)
            {
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                rusuario = Convert.ToDouble(txtC.Text);

                //rsistema = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                clasePitagoras cp = new clasePitagoras();
                rsistema = cp.c1(a, b);

                if (rsistema == rusuario)
                {
                    contB++;
                    MessageBox.Show("La respuesta es correcta " + "Respuestas correctas: " + contB);
                    label9.Text = Convert.ToString(contB);
                    txtA.Text = "";
                    txtB.Text = "";
                    txtC.Text = "";
                }
                else
                {
                    contM++;
                    MessageBox.Show("La respuesta es incorrecta " + "La respuesta correcta es: " + rsistema.ToString("N2"));
                    MessageBox.Show("Respuestas Incorrectas: " + contM);
                    label8.Text = Convert.ToString(contM);
                    txtA.Text = "";
                    txtB.Text = "";
                    txtC.Text = "";
                }
                if (contM == 3)
                {
                    MessageBox.Show("JUEGO TERMINADO", "Limite de respuestas incorrectas");
                    Close();
                }
            }

            if (rdbOp.Checked == true)
            {
                c = Convert.ToDouble(txtC.Text);
                b = Convert.ToDouble(txtB.Text);
                rusuarioO = Convert.ToDouble(txtA.Text);

                //rsistemaO = Math.Sqrt(Math.Pow(c, 2) + Math.Pow(b, 2));
                clasePitagoras cp = new clasePitagoras();
                rsistemaO = cp.a1(c, b);

                if (rsistemaO == rusuarioO)
                {
                    contB++;
                    MessageBox.Show("La respuesta es correcta " + "Respuestas correctas: " + contB);
                    label9.Text = Convert.ToString(contB);
                    txtA.Text = "";
                    txtB.Text = "";
                    txtC.Text = "";
                }
                else
                {
                    contM++;
                    MessageBox.Show("La respuesta es incorrecta " + "La respuesta correcta es: " + rsistemaO.ToString("N2"));
                    MessageBox.Show("Respuestas Incorrectas: " + contM);
                    label8.Text = Convert.ToString(contM);
                    txtA.Text = "";
                    txtB.Text = "";
                    txtC.Text = "";
                }
                if (contM == 3)
                {
                    MessageBox.Show("JUEGO TERMINADO", "Limite de respuestas incorrectas");
                    Close();
                }
            }
            if (rdbAd.Checked == true)
            {
                c = Convert.ToDouble(txtC.Text);
                a = Convert.ToDouble(txtA.Text);
                rusuarioA = Convert.ToDouble(txtB.Text);

                //rsistemaA = Math.Sqrt(Math.Pow(c, 2) + Math.Pow(a, 2));
                clasePitagoras cp = new clasePitagoras();
                rsistemaA = cp.b1(c, a);

                if (rsistemaA == rusuarioA)
                {
                    contB++;
                    MessageBox.Show("La respuesta es correcta " + "Respuestas correctas: " + contB);
                    label9.Text = Convert.ToString(contB);
                    txtA.Text = "";
                    txtB.Text = "";
                    txtC.Text = "";


                }
                else
                {
                    contM++;
                    MessageBox.Show("La respuesta es incorrecta " + "La respuesta correcta es: " + rsistemaA.ToString("N2"));
                    MessageBox.Show("Respuestas Incorrectas: " + contM);
                    label8.Text = Convert.ToString(contM);
                    txtA.Text = "";
                    txtB.Text = "";
                    txtC.Text = "";

                }
                if (contM == 3)
                {
                    MessageBox.Show("JUEGO TERMINADO", "Limite de respuestas incorrectas");
                    Close();
                }

            }
        }




    }
}
