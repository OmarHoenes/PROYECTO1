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
    public partial class frmEcuacionesPrimerGrado : Form
    {
        public frmEcuacionesPrimerGrado()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int contB = 0;
        int contM = 0;
        private void rdbBasico_CheckedChanged(object sender, EventArgs e)
        {
            int a = 1;
            int b = 10;
            txtX1.Text = Convert.ToString(x(a, b));
            txtX2.Text = Convert.ToString(x(a, b) + 1);
            txtY1.Text = Convert.ToString(y(a, b));
            txtY2.Text = Convert.ToString(y(a, b) + 1);
            txtC1.Text = Convert.ToString(c(a, b));
            txtC2.Text = Convert.ToString(c(a, b) + 1);
            GenerarPrimer();

        }
        //metodo para crear valores aleatorios

        private int x(int a, int b)
        {
            Random r = new Random();
            return r.Next(a, b);
        }
        private int y(int a, int b)
        {
            Random r = new Random(DateTime.Now.Second);
            return r.Next(a, b);
        }
        private int c(int a, int b)
        {
            Random r = new Random(DateTime.Now.Millisecond);
            return r.Next(a, b);
        }

        private void rdbMedio_CheckedChanged(object sender, EventArgs e)
        {
            int a = 10;
            int b = 20;
            txtX1.Text = Convert.ToString(x(a, b));
            txtX2.Text = Convert.ToString(x(a, b) + 1);
            txtY1.Text = Convert.ToString(y(a, b));
            txtY2.Text = Convert.ToString(y(a, b) + 1);
            txtC1.Text = Convert.ToString(c(a, b));
            txtC2.Text = Convert.ToString(c(a, b) + 1);
            GenerarPrimer();
        }

        private void rdbAvanzado_CheckedChanged(object sender, EventArgs e)
        {
            int a = 20;
            int b = 50;
            txtX1.Text = Convert.ToString(x(a, b));
            txtX2.Text = Convert.ToString(x(a, b) + 1);
            txtY1.Text = Convert.ToString(y(a, b));
            txtY2.Text = Convert.ToString(y(a, b) + 1);
            txtC1.Text = Convert.ToString(c(a, b));
            txtC2.Text = Convert.ToString(c(a, b) + 1);
            GenerarPrimer();

        }

        private void btnRevisar_Click(object sender, EventArgs e)
        {
            //declaro variables

            int x1, x2, y1, y2, c1, c2;
            double de, rsx, rsy, rx, ry;
            //validaciones de vacio
            if ((txtRX.Text == "") || (txtRY.Text == "") || (txtX1.Text == "") || (txtX2.Text == "") || (txtY1.Text == "") || (txtY2.Text == "") || (txtC1.Text == "") || (txtC2.Text == ""))
            {
                MessageBox.Show("Debe llenar los espacios en blanco o no seleciono uno de los niveles", "Error");

                return;
            }
           

            //asignamos los valores de los cuadros de texto
            x1 = Convert.ToInt32(txtX1.Text);
            x2 = Convert.ToInt32(txtX2.Text);
            y1 = Convert.ToInt32(txtY1.Text);
            y2 = Convert.ToInt32(txtY2.Text);
            c1 = Convert.ToInt32(txtC1.Text);
            c2 = Convert.ToInt32(txtC2.Text);

            //validacion de letras
            bool rm = Double.TryParse(txtRX.Text, out rx);
            if (rm == false)
            {
                MessageBox.Show("Debe ingresar un valor númerico para X", "Error");
                txtRX.Text = "";
                txtRX.Focus();
                return;
            }
            bool r = Double.TryParse(txtRY.Text, out ry);
            if (r == false)
            {
                MessageBox.Show("Debe ingresar un valor númerico para Y", "Error");
                txtRY.Text = "";
                txtRY.Focus();
                return;
            }
            // RESPUESTAS USUARIO
            rx = Convert.ToDouble(txtRX.Text);
            ry = Convert.ToDouble(txtRY.Text);
            //caluclo de la determinante
            // de = ecuacion(x1, x2, y1, y2);
            claseEcuacion1 ce = new claseEcuacion1();
            de = ce.ecuacion1(x1, x2, y1, y2);
            // calculo los valores para x, y
            rsx = Math.Round(ce.ecuacion1(c1, c2, y1, y2) / de,2);
            rsy = Math.Round(ce.ecuacion1(x1, x2, c1, c2) / de,2);
            MessageBox.Show("Respuestas:" + /*de +*/ "x = " + rsx  + "  y = " + rsy);

            // REVISAR SI LAS RESPUESTAS DEL USUA SON CORRECTAS
            // SI EL EJRECICIO TIENE SOLUCION
            if (de == rx)
            {
                contB++;
                MessageBox.Show("Respeustas correctas");
                label11.Text = Convert.ToString(contB);
                limpiar();
                return;
            }
            else if ((rsx == rx) && (rsy == ry))
            {
                contB++;
                MessageBox.Show("Respuesta correcta");
                label11.Text = Convert.ToString(contB);
                limpiar(); 
            }
            else
            {
                contM++;
                MessageBox.Show("Respuesta incorrecta");
                label9.Text = Convert.ToString(contM);
                limpiar();
                if (contM == 3)
                {
                    MessageBox.Show("Limite de respuestas incorrectas" , "JUEGO TERMINADO");
                    this.Close();
                }
                RevisarGrafica();
            }
        }

        //METODO PARA CALCULAR
        //public int ecuacion(int x1, int x2, int y1, int y2, double de)
        //{
             
               // return (x1 * y2) - (x2 * y1);
                /*claseEcuacion1 ce = new claseEcuacion1();
            de = ce.ecuacion1(x1, x2, y1, y2);

            //clasePendiente cp = new clasePendiente();
            //rsistema = cp.clasePend(y, b, x);*/

        //}
        private void limpiar()
        {
            txtX1.Text = "";
            txtX2.Text = "";
            txtY1.Text = "";
            txtY2.Text = "";
            txtC1.Text = "";
            txtC2.Text = "";
            txtRX.Text = "";
            txtRY.Text = "";
            txtRX.Focus();

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

        private void frmEcuacionesPrimerGrado_Load(object sender, EventArgs e)
        {
            bloquear();
        }
        private void bloquear()
        {
            txtX1.Enabled = false;
            txtX2.Enabled = false;
            txtY1.Enabled = false;
            txtY2.Enabled = false;
            txtC1.Enabled = false;
            txtC2.Enabled = false; 
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1) Debe Generar Valores con el radio Button.\n2) Debe Agregar una respuesta. \n3) Debe Darle al Boton Revisar para verificar su respuesta. \n4)Al Tercer Error Termina el juego", "!!! Boton De Ayuda Ecuaciones de Primer Grado¡¡¡", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GenerarPendiente_Click(object sender, EventArgs e)
        {
            GenerarPrimer();
        }
        int yp, m, b;

        private void btnRev_Click(object sender, EventArgs e)
        {
            RevisarGrafica();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }


        public void RevisarGrafica()
        {
            //Validar el ingreso de la respuesta 
            if (txtRX.Text == "")
            {
                MessageBox.Show("Debe ingresar una respuesta");
                return;

            }
            if (txtRY.Text == "")
            {
                MessageBox.Show("Debe ingresar una respuesta");
                return;

            }

            int m1, x1, b1, ys1;
            m1 = Convert.ToInt32(txtRX.Text);
            m1 = Convert.ToInt32(txtRY.Text);
            x1 = Convert.ToInt32(txtX1.Text);
            b1 = Convert.ToInt32(txtY1.Text);
            x1 = Convert.ToInt32(txtX2.Text);
            b1 = Convert.ToInt32(txtY2.Text);
            
            //Calculamos el valor de Y de acuerdo a la ecuacion original
            OperacionesM om = new OperacionesM();
            ys1 = om.ys(m, x1, b);
            //Evaluamos el resulttado del usuario
            if (om.ms(m, x1, b, b1) == m1)
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
            

        }

        public void GenerarPrimer()
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
                yp = (m * i) + b;
                //Agregamos la informacion a la columna del eje Y dentro del DattaGrid
                Datos.Rows[n].Cells[1].Value = yp;
            }
            //Generar el numero aleatorio para x de acuerdo a los datos ingresados en el DattaGrid
            txtX1.Text = Convert.ToString(om.valorX(min, varCiclo));
            //Generar el numero aleatorio para b de acuerdo a los datos ingresados en el DattaGrid
            txtY1.Text = Convert.ToString(om.valorY(min, max));

            txtX2.Text = Convert.ToString(om.valorX(min, varCiclo));
            //Generar el numero aleatorio para b de acuerdo a los datos ingresados en el DattaGrid
            txtY2.Text = Convert.ToString(om.valorY(min, max));

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
    }
}
