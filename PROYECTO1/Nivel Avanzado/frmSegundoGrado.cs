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

namespace PROYECTO1.Nivel_Avanzado
{
    public partial class frmSegundoGrado : Form
    {
        public frmSegundoGrado()
        {
            InitializeComponent();
        }
        int contB = 0;
        int contM = 0;
        private void btnRevisar_Click(object sender, EventArgs e)
        {

            double a, b, c, rusuario1, rusuario2, rsistema1, rsistema2, discriminante;
            //validaciones de vacio
            if ((txtA.Text == "") || (txtB.Text == "") || (txtC.Text == "") || (txtX1.Text == "") || (txtX2.Text == ""))
            {
                MessageBox.Show("Debe llenar los espacios en blanco o no seleciono uno de los niveles", "Error");
                return;
            }

            //asignamos los valores de los cuadros de texto
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            c = Convert.ToDouble(txtC.Text);


            //validacion de letras
            bool rm = Double.TryParse(txtX1.Text, out rusuario1);
            if (rm == false)
            {
                MessageBox.Show("Debe ingresar un valor númerico para X", "Error");
                txtX1.Text = "";
                txtX1.Focus();
                return;
            }
            bool r = Double.TryParse(txtX2.Text, out rusuario2);
            if (r == false)
            {
                MessageBox.Show("Debe ingresar un valor númerico para Y", "Error");
                txtX2.Text = "";
                txtX2.Focus();
                return;
            }

            discriminante = Math.Pow(b, 2) - 4 * a * c;
            rusuario1 = Convert.ToDouble(txtX1.Text);
            rusuario2 = Convert.ToDouble(txtX2.Text);

            //calculo
            //rsistema1 = ecuacion(a, b, c);
            //rsistema2 = ecuacion1(a, b, c);
            claseEcuacion2 ce2 = new claseEcuacion2();
            if (discriminante == 0 || discriminante < 0)
            {
                MessageBox.Show("La respuesta no tiene solución");
                rdbBasico.Checked = false; rdbMedio.Checked = false; rdbAvanzado.Checked = false;
                txtA.Text = "";
                txtB.Text = "";
                txtC.Text = "";
                txtX1.Text = "";
                txtX2.Text = "";
                return;
            }
            if (discriminante > 0)
            {
                claseEcuacion2 ce = new claseEcuacion2();
                rsistema1 = Math.Round(ce2.ecuacion11(a, b, c), 2);
                rsistema2 = Math.Round(ce2.ecuacion12(a, b, c), 2);
            }
            

            rsistema1 = Math.Round(ce2.ecuacion11(a, b, c), 2);
            rsistema2 = Math.Round(ce2.ecuacion12(a, b, c), 2);

            //comparar valores
            if ((rsistema1 == rusuario1) || (rsistema2 == rusuario2))
            {
                contB++;
                MessageBox.Show("La respuesta es correcta " + "Respuestas correctas: " + contB);
                label11.Text = Convert.ToString(contB);
                txtA.Text = "";
                txtB.Text = "";
                txtC.Text = "";
                txtX1.Text = "";
                txtX2.Text = "";

            }
            else
            {
                contM++;
                MessageBox.Show("La respuesta es incorrecta " + "La respuesta correcta es: " + rsistema1.ToString("N2") + " / " + rsistema2.ToString("N2"));
                MessageBox.Show("Respuestas Incorrectas: " + contM);
                label9.Text = Convert.ToString(contM);
                txtA.Text = "";
                txtB.Text = "";
                txtC.Text = "";
                txtX1.Text = "";
                txtX2.Text = "";

            }
            if (contM == 3)
            {
                MessageBox.Show("JUEGO TERMINADO", "Limite de respuestas incorrectas");
                Close();
            }
            RevisarGrafica();

        }
        private void rdbBasico_CheckedChanged(object sender, EventArgs e)
        {
            int a = -10;
            int b = 10;
            txtA.Text = Convert.ToString(a1(a, b));
            txtB.Text = Convert.ToString(b1(a, b));
            txtC.Text = Convert.ToString(c1(a, b));
            GenerarVG();
            
        } 

        private int a1(int a, int b)
        {
            Random r = new Random();
            return r.Next(a, b);

        }
        private int b1(int a, int b)
        {
            Random r = new Random(DateTime.Now.Second);
            return r.Next(a, b);
        }
        private int c1(int a, int b)
        {
            Random r = new Random(DateTime.Now.Millisecond);
            return r.Next(a, b);
        }

        private void rdbMedio_CheckedChanged(object sender, EventArgs e)
        {
            int a = -20;
            int b = 20;
            txtA.Text = Convert.ToString(a1(a, b));
            txtB.Text = Convert.ToString(b1(a, b));
            txtC.Text = Convert.ToString(c1(a, b));
            GenerarVG();
        }

        private void rdbAvanzado_CheckedChanged(object sender, EventArgs e)
        {
            int a = -30;
            int b = 50;
            txtA.Text = Convert.ToString(a1(a, b));
            txtB.Text = Convert.ToString(b1(a, b));
            txtC.Text = Convert.ToString(c1(a, b));
            GenerarVG();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1) Debe Generar Valores con el radio Button.\n2) Debe Agregar una respuesta. \n3) Debe Darle al Boton Revisar para verificar su respuesta. \n4)Al Tercer Error Termina el juego \n5)si el sistema no tiene solución, llene los campos con ceros.", "!!! Boton De Ayuda Ecuaciones de Segundo Grado¡¡¡", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRev_Click(object sender, EventArgs e)
        {
            RevisarGrafica();
        }
        int y, m, b;

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarT();
        }

        private void GenerarPendiente_Click(object sender, EventArgs e)
        {
            GenerarVG();
        }
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
                Datos.Rows[n].Cells[2].Value = y;
            }
            //Generar el numero aleatorio para x de acuerdo a los datos ingresados en el DattaGrid
            //txtA.Text = Convert.ToString(om.valorX(min, varCiclo));
            //Generar el numero aleatorio para b de acuerdo a los datos ingresados en el DattaGrid
            //txtX.Text = Convert.ToString(om.valorY(min, max));

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

        private void limpiarT()
        {
            rdbBasico.Checked = false;
            rdbMedio.Checked = false;
            rdbAvanzado.Checked = false;
            txtX1.Clear();
            txtX2.Clear();
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
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

        public void RevisarGrafica()
        {
            //Validar el ingreso de la respuesta 
            if (txtX1.Text == "")
            {
                MessageBox.Show("Debe ingresar una respuesta");
                return;
            }
            if (txtX2.Text == "")
            {

                MessageBox.Show("Debe ingresar una respuesta");
                return;
            }

            int m1, x1, b1, ys1;
            m1 = Convert.ToInt32(txtX1.Text);
            x1 = Convert.ToInt32(txtX2.Text);
            b1 = Convert.ToInt32(txtX1.Text);


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
    }
   
}

