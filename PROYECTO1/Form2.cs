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

namespace PROYECTO1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //generar instasia
            OperacionesBasicas.frmSuma fs=new OperacionesBasicas.frmSuma();
            fs.MdiParent = this;
            fs.Show();
        }

        private void restaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperacionesBasicas.frmResta fr = new OperacionesBasicas.frmResta();
            fr.MdiParent = this;
            fr.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void multiplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperacionesBasicas.frmMultiplicacion fm = new OperacionesBasicas.frmMultiplicacion();
            fm.MdiParent = this;
            fm.Show();
        }

        private void divisiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperacionesBasicas.frmDivision fd = new OperacionesBasicas.frmDivision();
            fd.MdiParent = this;
            fd.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cálculoDeLaPendienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CalculoPendiente.frmPendiente fp = new CalculoPendiente.frmPendiente();
            fp.MdiParent = this;
            fp.Show();
        }

        private void cálculoDeLaPendienteAPartirDeDosPuntosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           NivelMedio.frmPendienteDosPuntos fp2 = new NivelMedio.frmPendienteDosPuntos();
            fp2.MdiParent = this;
            fp2.Show();
        }

        private void teoramaDePitagorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void operacionesBásicasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            PROYECTO1.frmRegistroUsuarios ru = new PROYECTO1.frmRegistroUsuarios();
            ru.MdiParent = this;
            ru.Show();
        }
        private void teoremaDePitagorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NivelMedio.frmTeoremaPitagoras tp = new NivelMedio.frmTeoremaPitagoras();
            tp.MdiParent = this;
            tp.Show();
        }

        private void sumaDeVectoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NivelMedio.frmVectores fv = new NivelMedio.frmVectores();
            fv.MdiParent = this;
            fv.Show();
        }

        private void sistemaDeEcuacionesDePrimerGradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nivel_Avanzado.frmEcuacionesPrimerGrado e1 = new Nivel_Avanzado.frmEcuacionesPrimerGrado();
            e1.MdiParent = this;
            e1.Show();
        }

        private void sistemaDeEcuacionesDeSegundoGradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nivel_Avanzado.frmSegundoGrado e2 = new Nivel_Avanzado .frmSegundoGrado();
            e2.MdiParent = this;
            e2.Show();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1) Debe seleccionar Un nivel para Trabajar las respectivas operaciones.\n2)Al selecionar un Nivel se abrira un formulario para la  operacion deseada.", "!!! Boton De Ayuda ¡¡¡", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
