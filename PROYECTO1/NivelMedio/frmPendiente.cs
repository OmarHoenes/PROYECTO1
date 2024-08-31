using PROYECTO1.CLASES;
using PROYECTO1.NivelMedio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PROYECTO1.CalculoPendiente
{
    public partial class frmPendiente : Form
    {
        public frmPendiente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRevisar_Click(object sender, EventArgs e)
        {

        }

        private void txtR_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmPendiente_Load(object sender, EventArgs e)
        {
            //bloquear el cuadro de texto para la respuesta
            //txtM.Enabled = false;
            btnNuevo.Enabled = true;
            txtY.Enabled = false;
            txtB.Enabled = false;
            txtX.Enabled = false;



        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarT();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rdbBasico_CheckedChanged(object sender, EventArgs e)
        {

            Random r1 = new Random(DateTime.Now.Second);

            txtY.Text = Convert.ToString(r1.Next(1, 10));
            txtB.Text = Convert.ToString(r1.Next(1, 10));
            txtX.Text = Convert.ToString(r1.Next(1, 10));
            
        }

        private void rdbMedio_CheckedChanged(object sender, EventArgs e)
        {
            Random r1 = new Random(DateTime.Now.Second);

            txtY.Text = Convert.ToString(r1.Next(10, 100));
            txtB.Text = Convert.ToString(r1.Next(10, 100));
            txtX.Text = Convert.ToString(r1.Next(10, 100));
            
        }

        private void rdbAvanzado_CheckedChanged(object sender, EventArgs e)
        {
            Random r1 = new Random(DateTime.Now.Second);

            txtY.Text = Convert.ToString(r1.Next(100, 999));
            txtB.Text = Convert.ToString(r1.Next(100, 999));
            txtX.Text = Convert.ToString(r1.Next(100, 999));
            
        }
        int contB = 0, contM = 0;

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if (btnRevisar.Enabled == true)
            {
                btnNuevo.Enabled = true;
            }

        }

        private void txtM_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                txtM.Clear();
                MessageBox.Show("Debe ingresar únicamente valores numericos", "Error");

                return;

            }*/

        }

        private void btnRevisar_Click_1(object sender, EventArgs e)
        {
            //declarar variable
            double y, b, x, rusuario, rsistema;

            // asigarle varables a los valores de los cuadros de texto
            if ((txtY.Text == "") || (txtB.Text == "") || (txtX.Text == "") || (txtM.Text == ""))
            {
                MessageBox.Show("No selecciono ninguno de los niveles o no ingreso su respuesta", "Error");

                return;
            }

            bool rm = Double.TryParse(txtM.Text, out rusuario);
            if (rm == false)
            {
                MessageBox.Show("Debe ingresar un valor númerico para M", "Error");
                txtM.Text = "";
                txtM.Focus();
                return;
            }



            y = Convert.ToDouble(txtY.Text);
            b = Convert.ToDouble(txtB.Text);
            x = Convert.ToDouble(txtX.Text);
            rusuario = Convert.ToDouble(txtM.Text);

            //calcular
            //rsistema =  (y - b) / x;
            clasePendiente cp = new clasePendiente();
            rsistema = cp.clasePend(y, b, x);

            intentos(rsistema, rusuario);
            RevisarGrafica();

        }
        

        private void btnRev_Click(object sender, EventArgs e)
        {
            RevisarGrafica();
        }

        private void RevisarGrafica()
        {
            //Validar el ingreso de la respuesta 
            if (txtM.Text == "")
            {
                limpiarT();
                return;
            }

            int m1, x1, b1, ys1;
            m1 = Convert.ToInt32(txtM.Text);
            x1 = Convert.ToInt32(txtX.Text);
            b1 = Convert.ToInt32(txtB.Text);
            //Calculamos el valor de Y de acuerdo a la ecuacion original
            OperacionesM om = new OperacionesM();
            ys1 = om.ys(m, x1, b);
            //Evaluamos el resulttado del usuario
            if (om.ms(m, x1, b, b1) == m1)
            {
                contB++;
                MessageBox.Show("Respuesta Correcta");
                label9.Text = Convert.ToString(contB);
                limpiarT();
            }
            else
            {
                contM++;
                MessageBox.Show("Respuesta Incorrecta" + "\n\r" + "La respuesta correcta es: " + om.ms(m, x1, b, b1));
                label8.Text = Convert.ToString(contM);
                limpiarT();
            }

        }

        private void limpiarT()
        {
            rdbBasico.Checked = false;
            rdbMedio.Checked = false;
            rdbAvanzado.Checked = false;
            txtY.Clear();
            txtB.Clear();
            txtX.Clear();
            txtM.Clear();
            //Borramos la info de las filas del datagrid
            Datos.Rows.Clear();
            Datos.Refresh();
            //borramos los puntos del grafico y el titulo
            chart1.Titles.Clear();
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1) Debe Generar Valores con el radio Button o en el boton generar para usar los graficos.\n2) Debe Agregar una respuesta. \n3) Debe Darle al Boton Revisar para verificar su respuesta. \n4)Al Tercer Error Termina el juego", "!!! Boton De Ayuda Calculo de la Pendiente¡¡¡", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //___________________________________________DattaGrid______________>>>>>>>>>>>>>>
        int y, m, b;
        private void GenerarPendiente_Click(object sender, EventArgs e)
        {
            GenerarVG();
        }
        //Metodo para Generar VAlores para la grafica______________________________________________________________________________
        public void GenerarVG()
        {
            //Generar Valores Aleatorios para la cantidad de datos de la tabla
            int min = 2;
            int max = Convert.ToInt32(nudNumero.Value);
            //C genero valores aleatorios para variable m y b

            //Generamos instancia a la clase OperacionsM
            NivelMedio.OperacionesM om = new NivelMedio.OperacionesM();

            b = om.valorX(min, max);
            m = om.valorX(min, max);
            //Creamos Variable para generar valores aleatorios sobre la cantidad
            //de datos que apareceran en dattaGrid
            int varCiclo = om.valorCiclo(b, m);
            for (int i = 1; i <= varCiclo; i++)
            {
                //Controlamos el numero de filas de el datta Grid
                int n = Datos.Rows.Add();
                //AGregamos informacion al DattaGrid a la columna eje X
                Datos.Rows[n].Cells[0].Value = i;
                //Agregamos ecuacion lineal del Eje Y
                y = (m * i) + b;
                //Agregamos la informacion a la columna del eje Y dentro del DattaGrid
                Datos.Rows[n].Cells[1].Value = y;
            }
            //Generar el numero aleatorio para x de acuerdo a los datos ingresados en el DattaGrid
            txtX.Text = Convert.ToString(om.valorX(min, varCiclo));
            //Generar el numero aleatorio para b de acuerdo a los datos ingresados en el DattaGrid
            txtB.Text = Convert.ToString(om.valorY(min, max));

            //debemos declarar 2 arreglos para llenar nuestra grafica
            //Necesitamos para valores de x, Y
            int[] valorX = new int[Datos.Rows.Count - 1];
            int[] valorY = new int[Datos.Rows.Count - 1];
            //Llenar los arreglos con la informacion que tiene el datagrid para x , y
            for (int i = 0; i < valorX.Length; i++)
            {
                valorX[i] = Convert.ToInt32(Datos.Rows[i].Cells[0].Value);
                valorY[i] = Convert.ToInt32(Datos.Rows[i].Cells[1].Value);
            }
            //Debemos definir los colores de la grafica (Charp1)
            chart1.Palette = ChartColorPalette.Berry;
            //Definir el titulo del grafico
            chart1.Titles.Add("Calculo de la pendiente en una ecuacion lineal");
            //Creamos un ciclo para llenar el grafico
            for (int j = 0; j < valorX.Length; j++)
            {
                //Definimos el valor maximo para el eje Y con intervalos de acuerdo al criterio del programador
                //Puede ser de uno en uno o de dos en dos
                chart1.ChartAreas[0].AxisY.Maximum = valorY[valorY.Length - 1];
                chart1.ChartAreas[0].AxisY.Interval = 1;

                //Generamos los puntos para los ehes X, Y en el Grafico
                chart1.Series[0].Points.AddXY(valorX[j], valorY[j]);
                chart1.Series[1].Points.AddXY(valorX[j], valorY[j]);
            }
            //Definimos el tipo de grafico
            chart1.Series["Series1"].ChartType = SeriesChartType.Line;
            chart1.Series["Series2"].ChartType = SeriesChartType.FastPoint;
        }

        private void intentos(double rsistema, double rusuario)
        {


            //comparar valores
            if (rsistema == rusuario)
            {
                contB++;
                MessageBox.Show("La respuesta es correcta " + "Respuestas correctas: " + contB);
                label9.Text = Convert.ToString(contB);
                txtY.Text = "";
                txtB.Text = "";
                txtX.Text = "";
                txtM.Text = "";

            }
            else
            {
                contM++;
                MessageBox.Show("La respuesta es incorrecta " + "La respuesta correcta es: " + rsistema.ToString("N2"));
                MessageBox.Show("Respuestas Incorrectas: " + contM);
                label8.Text = Convert.ToString(contM);
                txtY.Text = "";
                txtB.Text = "";
                txtX.Text = "";
                txtM.Text = "";

            }
            if (contM == 3)
            {
                MessageBox.Show("JUEGO TERMINADO", "Limite de respuestas incorrectas");
                Close();
            }
        }
    }
}
