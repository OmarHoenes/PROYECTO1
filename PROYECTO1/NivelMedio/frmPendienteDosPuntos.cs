using PROYECTO1.CLASES;
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

namespace PROYECTO1.NivelMedio
{
    public partial class frmPendienteDosPuntos : Form
    {
        public frmPendienteDosPuntos()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rdbBasico_CheckedChanged(object sender, EventArgs e)
        {

            Random r1 = new Random(DateTime.Now.Second);

            txtY1.Text = Convert.ToString(r1.Next(1, 10));
            txtY2.Text = Convert.ToString(r1.Next(1, 10));
            txtX1.Text = Convert.ToString(r1.Next(1, 10));
            txtX2.Text = Convert.ToString(r1.Next(1, 10));
            
        }

        private void rdbMedio_CheckedChanged(object sender, EventArgs e)
        {
            Random r1 = new Random(DateTime.Now.Second);

            txtY1.Text = Convert.ToString(r1.Next(10, 100));
            txtY2.Text = Convert.ToString(r1.Next(10, 100));
            txtX1.Text = Convert.ToString(r1.Next(10, 100));
            txtX2.Text = Convert.ToString(r1.Next(10, 100));
            
        }

        private void rdbAvanzado_CheckedChanged(object sender, EventArgs e)
        {
            Random r1 = new Random(DateTime.Now.Second);

            txtY1.Text = Convert.ToString(r1.Next(100, 999));
            txtY2.Text = Convert.ToString(r1.Next(100, 999));
            txtX1.Text = Convert.ToString(r1.Next(100, 999));
            txtX2.Text = Convert.ToString(r1.Next(100, 999));
            
        }
        int contB = 0, contM = 0;

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void limpiar()
        {
            rdbBasico.Checked = false;
            rdbMedio.Checked = false;
            rdbAvanzado.Checked = false;
            txtY1.Clear();
            txtY2.Clear();
            txtX1.Clear();
            txtX2.Clear();
            txtM.Clear();

            //Borramos la info de las filas del datagrid
            Datos1.Rows.Clear();
            Datos1.Refresh();
            //borramos los puntos del grafico y el titulo
            chart2.Titles.Clear();
            foreach (var series in chart2.Series)
            {
                series.Points.Clear();
            }
        }

        private void frmPendienteDosPuntos_Load(object sender, EventArgs e)
        {
            btnNuevo.Enabled =false;
            txtY1.Enabled = false;
            txtY2.Enabled = false;
            txtX1.Enabled = false;
            txtX2.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if (btnRevisar.Enabled == true)
            {
                btnNuevo.Enabled = true;
            }
        }

        private void btnRevisar_Click(object sender, EventArgs e)
        {
            //declarar variable
            double y1, y2, x1, x2, m, rusuario, rsistema;

            // asigarle varables a los valores de los cuadros de texto
            if ((txtY1.Text == "") || (txtY2.Text == "") || (txtX1.Text == "") || (txtX2.Text == "") || (txtM.Text == ""))
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




            y1 = Convert.ToDouble(txtY1.Text);
            y2 = Convert.ToDouble(txtY2.Text);
            x1 = Convert.ToDouble(txtX1.Text);
            x2 = Convert.ToDouble(txtX2.Text);
            m = Convert.ToDouble(txtM.Text);
            rusuario = Convert.ToDouble(txtM.Text);

            //calcular
            //rsistema = m = (y2 - y1) / (x2 - x1);
            clasePendienteDosPuntos cdp = new clasePendienteDosPuntos();
            rsistema = Convert.ToDouble(cdp.claseDosPuntos(y1,y2,x2,x1));

            intentos(rusuario,rsistema);
            RevisarPuntoPendiente();
        }

        private void txtM_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        int y1, y, m, b;

        private void btnRevDos_Click(object sender, EventArgs e)
        {
            RevisarPuntoPendiente();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1) Debe Generar Valores con el radio Button o en el boton generar para usar los graficos.\n2) Debe Agregar una respuesta. \n3) Debe Darle al Boton Revisar para verificar su respuesta. \n4)Al Tercer Error Termina el juego", "!!! Boton De Ayuda Calculo de la Pendiente A partir de 2 Puntos¡¡¡", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void GenerarPendienteDos_Click(object sender, EventArgs e)
        {
            GenerarPendienteDosPuntos();
           
        }

        //Metodo Generar Datos pa el DattaGrid
        private void GenerarPendienteDosPuntos()
        {
            btnNuevo.Enabled = true;
            //Generar Valores Aleatorios para la cantidad de datos de la tabla
            int min = 2;
            int max = Convert.ToInt32(nudNumeroDos.Value);
            //C genero valores aleatorios para variable m y b

            //Generamos instancia a la clase OperacionsM
            NivelMedio.OperacionesM om = new NivelMedio.OperacionesM();

            b = om.valorX1(min, max);
            m = om.valorX1(min, max);

            //Creamos Variable para generar valores aleatorios sobre la cantidad
            //de datos que apareceran en dattaGrid
            int varCiclo = om.valorCiclo2(b, m);
            for (int i = 1; i <= varCiclo; i++)
            {
                //Controlamos el numero de filas de el datta Grid
                int n = Datos1.Rows.Add();
                //AGregamos informacion al DattaGrid a la columna eje X
                Datos1.Rows[n].Cells[0].Value = i;
                //Agregamos ecuacion lineal del Eje Y
                y = (m * i) + b;
                //Agregamos la informacion a la columna del eje Y dentro del DattaGrid
                Datos1.Rows[n].Cells[1].Value = y;

                //AGregamos informacion al DattaGrid a la columna eje X1
                Datos1.Rows[n].Cells[2].Value = i;
                //Agregamos ecuacion lineal del Eje Y2
                y1 = (m * i) + b;
                //Agregamos la informacion a la columna del eje Y dentro del DattaGrid
                Datos1.Rows[n].Cells[3].Value = y1;
            }
            //Generar el numero aleatorio para x de acuerdo a los datos ingresados en el DattaGrid
            txtX1.Text = Convert.ToString(om.valorX1(min, varCiclo));
            txtX2.Text = Convert.ToString(om.valorX2(min, varCiclo));
            //Generar el numero aleatorio para b de acuerdo a los datos ingresados en el DattaGrid
            txtY1.Text = Convert.ToString(om.valorY1(min, max));
            txtY2.Text = Convert.ToString(om.valorY2(min, max));

            //debemos declarar 2 arreglos para llenar nuestra grafica
            //Necesitamos para valores de x, Y
            int[] valorX = new int[Datos1.Rows.Count - 1];
            int[] valorY = new int[Datos1.Rows.Count - 1];
            int[] valorX1 = new int[Datos1.Rows.Count - 1];
            int[] valorY1 = new int[Datos1.Rows.Count - 1];
            //Llenar los arreglos con la informacion que tiene el datagrid para x , y
            for (int i = 0; i < valorX.Length; i++)
            {
                valorX[i] = Convert.ToInt32(Datos1.Rows[i].Cells[0].Value);
                valorY[i] = Convert.ToInt32(Datos1.Rows[i].Cells[1].Value);

                valorX1[i] = Convert.ToInt32(Datos1.Rows[i].Cells[0].Value);
                valorY1[i] = Convert.ToInt32(Datos1.Rows[i].Cells[1].Value);
            }
            //Debemos definir los colores de la grafica (Charp1)
            chart2.Palette = ChartColorPalette.Berry;
            //Definir el titulo del grafico
            chart2.Titles.Add("Calculo de la pendiente en una ecuacion lineal");

            //Creamos un ciclo para llenar el grafico
            for (int j = 0; j < valorX.Length; j++)
            {
                //Definimos el valor maximo para el eje Y con intervalos de acuerdo al criterio del programador
                //Puede ser de uno en uno o de dos en dos
                chart2.ChartAreas[0].AxisY.Maximum = valorY[valorY.Length - 1];
                chart2.ChartAreas[0].AxisY.Interval = 1;
                chart2.ChartAreas[0].AxisY.Maximum = valorY1[valorY1.Length - 1];
                chart2.ChartAreas[0].AxisY.Interval = 1;

                //Generamos los puntos para los ehes X, Y en el Grafico
                chart2.Series[0].Points.AddXY(valorX[j], valorY[j]);
                chart2.Series[1].Points.AddXY(valorX[j], valorY[j]);

                chart2.Series[0].Points.AddXY(valorX1[j], valorY1[j]);
                chart2.Series[1].Points.AddXY(valorX1[j], valorY1[j]);
            }
            //Definimos el tipo de grafico
            chart2.Series["Series1"].ChartType = SeriesChartType.Line;
            chart2.Series["Series2"].ChartType = SeriesChartType.FastPoint;

           
        }

        private void RevisarPuntoPendiente()
        {

            btnNuevo.Enabled = true;
            //Validar el ingreso de la respuesta 
            if (txtM.Text == "")
            {
                MessageBox.Show("No selecciono ninguno de los niveles o no ingreso su respuesta", "Error");
            }

            int m1, x1, b1, ys1;
            m1 = Convert.ToInt32(txtM.Text);
            x1 = Convert.ToInt32(txtX1.Text);
            b1 = Convert.ToInt32(txtY1.Text);
            //Calculamos el valor de Y de acuerdo a la ecuacion original
            OperacionesM om = new OperacionesM();
            ys1 = om.ys1(m, x1, b);
            //Evaluamos el resulttado del usuario
            if (om.ms1(m, x1, b, b1) == m1)
            {
                contB++;
                MessageBox.Show("Respuesta Correcta");
                label9.Text = Convert.ToString(contB);
                
                limpiar();

            }
            else
            {
                contM++;
                MessageBox.Show("Respuesta Incorrecta" + "\n\r" + "La respuesta correcta es: " + om.ms(m, x1, b, b1));
                label8.Text = Convert.ToString(contM);
                limpiar();
            }
            if (contM == 3)
            {
                MessageBox.Show("JUEGO TERMINADO", "Limite de respuestas incorrectas");
                Close();
            }

        }

        private void intentos(double rusuario, double rsistema)
        {
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
                txtM.Text = "";

            }
            else
            {
                contM++;
                MessageBox.Show("La respuesta es incorrecta " + "La respuesta correcta es: " + rsistema.ToString("N2"));
                MessageBox.Show("Respuestas Incorrectas: " + contM);
                label8.Text = Convert.ToString(contM);
                txtY1.Text = "";
                txtY2.Text = "";
                txtX1.Text = "";
                txtX2.Text = "";
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
