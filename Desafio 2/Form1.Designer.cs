namespace ParcialGrafo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNoDirigido = new System.Windows.Forms.RadioButton();
            this.rbDirigido = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRecorrido = new System.Windows.Forms.TextBox();
            this.btnProfundida = new System.Windows.Forms.Button();
            this.btnAnchura = new System.Windows.Forms.Button();
            this.CMSCrearVertice = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoVérticeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarVérticeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarArcoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pizarra = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.CMSCrearVertice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Simulador de Grafos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNoDirigido);
            this.groupBox1.Controls.Add(this.rbDirigido);
            this.groupBox1.Location = new System.Drawing.Point(27, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 61);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo:";
            // 
            // rbNoDirigido
            // 
            this.rbNoDirigido.AutoSize = true;
            this.rbNoDirigido.Location = new System.Drawing.Point(111, 26);
            this.rbNoDirigido.Name = "rbNoDirigido";
            this.rbNoDirigido.Size = new System.Drawing.Size(104, 23);
            this.rbNoDirigido.TabIndex = 1;
            this.rbNoDirigido.TabStop = true;
            this.rbNoDirigido.Text = "No Dirigido";
            this.rbNoDirigido.UseVisualStyleBackColor = true;
            this.rbNoDirigido.CheckedChanged += new System.EventHandler(this.rbNoDirigido_CheckedChanged);
            // 
            // rbDirigido
            // 
            this.rbDirigido.AutoSize = true;
            this.rbDirigido.Location = new System.Drawing.Point(24, 26);
            this.rbDirigido.Name = "rbDirigido";
            this.rbDirigido.Size = new System.Drawing.Size(81, 23);
            this.rbDirigido.TabIndex = 0;
            this.rbDirigido.TabStop = true;
            this.rbDirigido.Text = "Dirigido";
            this.rbDirigido.UseVisualStyleBackColor = true;
            this.rbDirigido.CheckedChanged += new System.EventHandler(this.rbDirigido_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.txtBuscar);
            this.groupBox2.Location = new System.Drawing.Point(273, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 76);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar nodo:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscar.Location = new System.Drawing.Point(162, 29);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(36, 33);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Ir";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtBuscar.Location = new System.Drawing.Point(36, 34);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 23);
            this.txtBuscar.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtRecorrido);
            this.groupBox3.Controls.Add(this.btnProfundida);
            this.groupBox3.Controls.Add(this.btnAnchura);
            this.groupBox3.Location = new System.Drawing.Point(718, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 530);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recorrido:";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(21, 112);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(192, 412);
            this.listBox1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Iniciar en:";
            // 
            // txtRecorrido
            // 
            this.txtRecorrido.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtRecorrido.Location = new System.Drawing.Point(100, 34);
            this.txtRecorrido.Name = "txtRecorrido";
            this.txtRecorrido.Size = new System.Drawing.Size(100, 23);
            this.txtRecorrido.TabIndex = 9;
            // 
            // btnProfundida
            // 
            this.btnProfundida.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnProfundida.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProfundida.Location = new System.Drawing.Point(116, 68);
            this.btnProfundida.Name = "btnProfundida";
            this.btnProfundida.Size = new System.Drawing.Size(97, 38);
            this.btnProfundida.TabIndex = 1;
            this.btnProfundida.Text = "Profundidad";
            this.btnProfundida.UseVisualStyleBackColor = false;
            this.btnProfundida.Click += new System.EventHandler(this.btnProfundida_Click);
            // 
            // btnAnchura
            // 
            this.btnAnchura.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAnchura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAnchura.Location = new System.Drawing.Point(21, 68);
            this.btnAnchura.Name = "btnAnchura";
            this.btnAnchura.Size = new System.Drawing.Size(79, 38);
            this.btnAnchura.TabIndex = 0;
            this.btnAnchura.Text = "Anchura";
            this.btnAnchura.UseVisualStyleBackColor = false;
            this.btnAnchura.Click += new System.EventHandler(this.btnAnchura_Click);
            // 
            // CMSCrearVertice
            // 
            this.CMSCrearVertice.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMSCrearVertice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoVérticeToolStripMenuItem,
            this.eliminarVérticeToolStripMenuItem,
            this.eliminarArcoToolStripMenuItem});
            this.CMSCrearVertice.Name = "CMSCrearVertice";
            this.CMSCrearVertice.Size = new System.Drawing.Size(182, 76);
            this.CMSCrearVertice.Opening += new System.ComponentModel.CancelEventHandler(this.CMSCrearVertice_Opening);
            // 
            // nuevoVérticeToolStripMenuItem
            // 
            this.nuevoVérticeToolStripMenuItem.Name = "nuevoVérticeToolStripMenuItem";
            this.nuevoVérticeToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.nuevoVérticeToolStripMenuItem.Text = "Nuevo Vértice";
            this.nuevoVérticeToolStripMenuItem.Click += new System.EventHandler(this.nuevoVérticeToolStripMenuItem_Click);
            // 
            // eliminarVérticeToolStripMenuItem
            // 
            this.eliminarVérticeToolStripMenuItem.Name = "eliminarVérticeToolStripMenuItem";
            this.eliminarVérticeToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.eliminarVérticeToolStripMenuItem.Text = "Eliminar Vértice";
            this.eliminarVérticeToolStripMenuItem.Click += new System.EventHandler(this.eliminarVérticeToolStripMenuItem_Click);
            // 
            // eliminarArcoToolStripMenuItem
            // 
            this.eliminarArcoToolStripMenuItem.Name = "eliminarArcoToolStripMenuItem";
            this.eliminarArcoToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.eliminarArcoToolStripMenuItem.Text = "Eliminar Arco";
            this.eliminarArcoToolStripMenuItem.Click += new System.EventHandler(this.eliminarArcoToolStripMenuItem_Click);
            // 
            // Pizarra
            // 
            this.Pizarra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Pizarra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pizarra.BackgroundImage")));
            this.Pizarra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pizarra.Location = new System.Drawing.Point(12, 152);
            this.Pizarra.Name = "Pizarra";
            this.Pizarra.Size = new System.Drawing.Size(700, 390);
            this.Pizarra.TabIndex = 1;
            this.Pizarra.Click += new System.EventHandler(this.Pizarra_Click);
            this.Pizarra.Paint += new System.Windows.Forms.PaintEventHandler(this.Pizarra_Paint);
            this.Pizarra.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pizarra_MouseClick);
            this.Pizarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pizarra_MouseDown);
            this.Pizarra.MouseLeave += new System.EventHandler(this.Pizarra_MouseLeave);
            this.Pizarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pizarra_MouseMove);
            this.Pizarra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pizarra_MouseUp);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitButton.Location = new System.Drawing.Point(820, 564);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(111, 38);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Salir";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(1009, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(230, 184);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(980, 614);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pizarra);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador de Grafos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.CMSCrearVertice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pizarra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRecorrido;
        private System.Windows.Forms.Button btnProfundida;
        private System.Windows.Forms.Button btnAnchura;
        public System.Windows.Forms.RadioButton rbDirigido;
        private System.Windows.Forms.ContextMenuStrip CMSCrearVertice;
        private System.Windows.Forms.ToolStripMenuItem nuevoVérticeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarVérticeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarArcoToolStripMenuItem;
        public System.Windows.Forms.RadioButton rbNoDirigido;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

