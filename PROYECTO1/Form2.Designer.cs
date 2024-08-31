namespace PROYECTO1
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesBásicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divisiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nivelMedioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendienteDosPuntosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teoremaDePitagorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumaDeVectoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nivelAvanzadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaDeEcuacionesDePrimerGradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaDeEcuacionesDeSegundoGradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.operacionesBásicasToolStripMenuItem,
            this.nivelMedioToolStripMenuItem,
            this.nivelAvanzadoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeUsuarioToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(81, 25);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // registroDeUsuarioToolStripMenuItem
            // 
            this.registroDeUsuarioToolStripMenuItem.Name = "registroDeUsuarioToolStripMenuItem";
            this.registroDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.registroDeUsuarioToolStripMenuItem.Text = "Registro de Usuario";
            this.registroDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.registroDeUsuarioToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(226, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // operacionesBásicasToolStripMenuItem
            // 
            this.operacionesBásicasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumaToolStripMenuItem,
            this.restaToolStripMenuItem,
            this.multiplicaciónToolStripMenuItem,
            this.divisiónToolStripMenuItem});
            this.operacionesBásicasToolStripMenuItem.Name = "operacionesBásicasToolStripMenuItem";
            this.operacionesBásicasToolStripMenuItem.Size = new System.Drawing.Size(176, 25);
            this.operacionesBásicasToolStripMenuItem.Text = "Operaciones Básicas";
            this.operacionesBásicasToolStripMenuItem.Click += new System.EventHandler(this.operacionesBásicasToolStripMenuItem_Click);
            // 
            // sumaToolStripMenuItem
            // 
            this.sumaToolStripMenuItem.Name = "sumaToolStripMenuItem";
            this.sumaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.sumaToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.sumaToolStripMenuItem.Text = "Suma";
            this.sumaToolStripMenuItem.Click += new System.EventHandler(this.sumaToolStripMenuItem_Click);
            // 
            // restaToolStripMenuItem
            // 
            this.restaToolStripMenuItem.Name = "restaToolStripMenuItem";
            this.restaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.restaToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.restaToolStripMenuItem.Text = "Resta";
            this.restaToolStripMenuItem.Click += new System.EventHandler(this.restaToolStripMenuItem_Click);
            // 
            // multiplicaciónToolStripMenuItem
            // 
            this.multiplicaciónToolStripMenuItem.Name = "multiplicaciónToolStripMenuItem";
            this.multiplicaciónToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.multiplicaciónToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.multiplicaciónToolStripMenuItem.Text = "Multiplicación";
            this.multiplicaciónToolStripMenuItem.Click += new System.EventHandler(this.multiplicaciónToolStripMenuItem_Click);
            // 
            // divisiónToolStripMenuItem
            // 
            this.divisiónToolStripMenuItem.Name = "divisiónToolStripMenuItem";
            this.divisiónToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.divisiónToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.divisiónToolStripMenuItem.Text = "División";
            this.divisiónToolStripMenuItem.Click += new System.EventHandler(this.divisiónToolStripMenuItem_Click);
            // 
            // nivelMedioToolStripMenuItem
            // 
            this.nivelMedioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pendienteToolStripMenuItem,
            this.pendienteDosPuntosToolStripMenuItem,
            this.teoremaDePitagorasToolStripMenuItem,
            this.sumaDeVectoresToolStripMenuItem});
            this.nivelMedioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nivelMedioToolStripMenuItem.Name = "nivelMedioToolStripMenuItem";
            this.nivelMedioToolStripMenuItem.Size = new System.Drawing.Size(95, 25);
            this.nivelMedioToolStripMenuItem.Text = "Nivel Medio";
            // 
            // pendienteToolStripMenuItem
            // 
            this.pendienteToolStripMenuItem.Name = "pendienteToolStripMenuItem";
            this.pendienteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.pendienteToolStripMenuItem.Size = new System.Drawing.Size(408, 22);
            this.pendienteToolStripMenuItem.Text = "Cálculo de la pendiente";
            this.pendienteToolStripMenuItem.Click += new System.EventHandler(this.cálculoDeLaPendienteToolStripMenuItem1_Click);
            // 
            // pendienteDosPuntosToolStripMenuItem
            // 
            this.pendienteDosPuntosToolStripMenuItem.Name = "pendienteDosPuntosToolStripMenuItem";
            this.pendienteDosPuntosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D6)));
            this.pendienteDosPuntosToolStripMenuItem.Size = new System.Drawing.Size(408, 22);
            this.pendienteDosPuntosToolStripMenuItem.Text = "Cálculo de la pendiente a partir de dos puntos";
            this.pendienteDosPuntosToolStripMenuItem.Click += new System.EventHandler(this.cálculoDeLaPendienteAPartirDeDosPuntosToolStripMenuItem_Click);
            // 
            // teoremaDePitagorasToolStripMenuItem
            // 
            this.teoremaDePitagorasToolStripMenuItem.Name = "teoremaDePitagorasToolStripMenuItem";
            this.teoremaDePitagorasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D7)));
            this.teoremaDePitagorasToolStripMenuItem.Size = new System.Drawing.Size(408, 22);
            this.teoremaDePitagorasToolStripMenuItem.Text = "Teorema de Pitagoras";
            this.teoremaDePitagorasToolStripMenuItem.Click += new System.EventHandler(this.teoremaDePitagorasToolStripMenuItem_Click);
            // 
            // sumaDeVectoresToolStripMenuItem
            // 
            this.sumaDeVectoresToolStripMenuItem.Name = "sumaDeVectoresToolStripMenuItem";
            this.sumaDeVectoresToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D8)));
            this.sumaDeVectoresToolStripMenuItem.Size = new System.Drawing.Size(408, 22);
            this.sumaDeVectoresToolStripMenuItem.Text = "Suma de Vectores";
            this.sumaDeVectoresToolStripMenuItem.Click += new System.EventHandler(this.sumaDeVectoresToolStripMenuItem_Click);
            // 
            // nivelAvanzadoToolStripMenuItem
            // 
            this.nivelAvanzadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaDeEcuacionesDePrimerGradoToolStripMenuItem,
            this.sistemaDeEcuacionesDeSegundoGradoToolStripMenuItem,
            this.toolStripMenuItem1});
            this.nivelAvanzadoToolStripMenuItem.Name = "nivelAvanzadoToolStripMenuItem";
            this.nivelAvanzadoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D2)));
            this.nivelAvanzadoToolStripMenuItem.Size = new System.Drawing.Size(143, 25);
            this.nivelAvanzadoToolStripMenuItem.Text = "Nivel Avanzado";
            // 
            // sistemaDeEcuacionesDePrimerGradoToolStripMenuItem
            // 
            this.sistemaDeEcuacionesDePrimerGradoToolStripMenuItem.Name = "sistemaDeEcuacionesDePrimerGradoToolStripMenuItem";
            this.sistemaDeEcuacionesDePrimerGradoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1)));
            this.sistemaDeEcuacionesDePrimerGradoToolStripMenuItem.Size = new System.Drawing.Size(451, 26);
            this.sistemaDeEcuacionesDePrimerGradoToolStripMenuItem.Text = "Sistema de ecuaciones de primer grado";
            this.sistemaDeEcuacionesDePrimerGradoToolStripMenuItem.Click += new System.EventHandler(this.sistemaDeEcuacionesDePrimerGradoToolStripMenuItem_Click);
            // 
            // sistemaDeEcuacionesDeSegundoGradoToolStripMenuItem
            // 
            this.sistemaDeEcuacionesDeSegundoGradoToolStripMenuItem.Name = "sistemaDeEcuacionesDeSegundoGradoToolStripMenuItem";
            this.sistemaDeEcuacionesDeSegundoGradoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.sistemaDeEcuacionesDeSegundoGradoToolStripMenuItem.Size = new System.Drawing.Size(451, 26);
            this.sistemaDeEcuacionesDeSegundoGradoToolStripMenuItem.Text = "Sistema de ecuaciones de segundo grado";
            this.sistemaDeEcuacionesDeSegundoGradoToolStripMenuItem.Click += new System.EventHandler(this.sistemaDeEcuacionesDeSegundoGradoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D3)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(451, 26);
            this.toolStripMenuItem1.Text = "Sistema de ecuaciones de Tercer  grado";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAyuda.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.Location = new System.Drawing.Point(508, -7);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(60, 36);
            this.btnAyuda.TabIndex = 17;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Formulario Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesBásicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplicaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divisiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nivelMedioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendienteDosPuntosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teoremaDePitagorasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumaDeVectoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nivelAvanzadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaDeEcuacionesDePrimerGradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaDeEcuacionesDeSegundoGradoToolStripMenuItem;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}