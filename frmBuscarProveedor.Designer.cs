
namespace pryFernandezIES
{
    partial class frmBuscarProveedor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarProveedor));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnEliminarProveedor = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnModificarProveedor = new System.Windows.Forms.Button();
            this.btnNuevoProveedor = new System.Windows.Forms.Button();
            this.btnMostrarProveedor = new System.Windows.Forms.Button();
            this.treDirectorios = new System.Windows.Forms.TreeView();
            this.pnlCargarProveedor = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtJurisd = new System.Windows.Forms.TextBox();
            this.lblJurisd = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtLiquidador = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblLiquidador = new System.Windows.Forms.Label();
            this.lblEntidad = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEntidad = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblApertura = new System.Windows.Forms.Label();
            this.txtJuzg = new System.Windows.Forms.TextBox();
            this.txtApertura = new System.Windows.Forms.TextBox();
            this.lblJuzg = new System.Windows.Forms.Label();
            this.lblNumExpediente = new System.Windows.Forms.Label();
            this.txtNumExpediente = new System.Windows.Forms.TextBox();
            this.dgrArchivos = new System.Windows.Forms.DataGridView();
            this.btnCargarProveedor = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlCargarProveedor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrArchivos)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnEliminarProveedor);
            this.splitContainer1.Panel1.Controls.Add(this.btnLimpiar);
            this.splitContainer1.Panel1.Controls.Add(this.btnModificarProveedor);
            this.splitContainer1.Panel1.Controls.Add(this.btnNuevoProveedor);
            this.splitContainer1.Panel1.Controls.Add(this.btnMostrarProveedor);
            this.splitContainer1.Panel1.Controls.Add(this.treDirectorios);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.Controls.Add(this.pnlCargarProveedor);
            this.splitContainer1.Panel2.Controls.Add(this.dgrArchivos);
            this.splitContainer1.Size = new System.Drawing.Size(752, 565);
            this.splitContainer1.SplitterDistance = 248;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnEliminarProveedor
            // 
            this.btnEliminarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(60)))), ((int)(((byte)(140)))));
            this.btnEliminarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarProveedor.FlatAppearance.BorderSize = 0;
            this.btnEliminarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProveedor.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnEliminarProveedor.Location = new System.Drawing.Point(40, 450);
            this.btnEliminarProveedor.Name = "btnEliminarProveedor";
            this.btnEliminarProveedor.Size = new System.Drawing.Size(161, 41);
            this.btnEliminarProveedor.TabIndex = 4;
            this.btnEliminarProveedor.Tag = "";
            this.btnEliminarProveedor.Text = "Eliminar Proveedor";
            this.btnEliminarProveedor.UseVisualStyleBackColor = false;
            this.btnEliminarProveedor.Visible = false;
            this.btnEliminarProveedor.Click += new System.EventHandler(this.btnEliminarProveedor_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(60)))), ((int)(((byte)(140)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(40, 497);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(161, 41);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Tag = "";
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Visible = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnModificarProveedor
            // 
            this.btnModificarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(60)))), ((int)(((byte)(140)))));
            this.btnModificarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarProveedor.FlatAppearance.BorderSize = 0;
            this.btnModificarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarProveedor.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnModificarProveedor.Location = new System.Drawing.Point(40, 403);
            this.btnModificarProveedor.Name = "btnModificarProveedor";
            this.btnModificarProveedor.Size = new System.Drawing.Size(161, 41);
            this.btnModificarProveedor.TabIndex = 3;
            this.btnModificarProveedor.Tag = "";
            this.btnModificarProveedor.Text = "Modificar Proveedor";
            this.btnModificarProveedor.UseVisualStyleBackColor = false;
            this.btnModificarProveedor.Visible = false;
            this.btnModificarProveedor.Click += new System.EventHandler(this.btnModificarProveedor_Click);
            // 
            // btnNuevoProveedor
            // 
            this.btnNuevoProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(60)))), ((int)(((byte)(140)))));
            this.btnNuevoProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoProveedor.FlatAppearance.BorderSize = 0;
            this.btnNuevoProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoProveedor.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProveedor.ForeColor = System.Drawing.Color.White;
            this.btnNuevoProveedor.Location = new System.Drawing.Point(40, 356);
            this.btnNuevoProveedor.Name = "btnNuevoProveedor";
            this.btnNuevoProveedor.Size = new System.Drawing.Size(161, 41);
            this.btnNuevoProveedor.TabIndex = 2;
            this.btnNuevoProveedor.Tag = "";
            this.btnNuevoProveedor.Text = "Nuevo Proveedor";
            this.btnNuevoProveedor.UseVisualStyleBackColor = false;
            this.btnNuevoProveedor.Visible = false;
            this.btnNuevoProveedor.Click += new System.EventHandler(this.btnNuevoProveedor_Click);
            // 
            // btnMostrarProveedor
            // 
            this.btnMostrarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(60)))), ((int)(((byte)(140)))));
            this.btnMostrarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarProveedor.FlatAppearance.BorderSize = 0;
            this.btnMostrarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarProveedor.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnMostrarProveedor.Location = new System.Drawing.Point(40, 309);
            this.btnMostrarProveedor.Name = "btnMostrarProveedor";
            this.btnMostrarProveedor.Size = new System.Drawing.Size(161, 41);
            this.btnMostrarProveedor.TabIndex = 1;
            this.btnMostrarProveedor.Text = "Mostrar Proveedor";
            this.btnMostrarProveedor.UseVisualStyleBackColor = false;
            this.btnMostrarProveedor.Click += new System.EventHandler(this.btnMostrarProveedor_Click);
            // 
            // treDirectorios
            // 
            this.treDirectorios.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treDirectorios.Location = new System.Drawing.Point(3, 3);
            this.treDirectorios.Name = "treDirectorios";
            this.treDirectorios.Size = new System.Drawing.Size(238, 283);
            this.treDirectorios.TabIndex = 0;
            // 
            // pnlCargarProveedor
            // 
            this.pnlCargarProveedor.Controls.Add(this.groupBox1);
            this.pnlCargarProveedor.Location = new System.Drawing.Point(7, 292);
            this.pnlCargarProveedor.Name = "pnlCargarProveedor";
            this.pnlCargarProveedor.Size = new System.Drawing.Size(481, 270);
            this.pnlCargarProveedor.TabIndex = 2;
            this.pnlCargarProveedor.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtJurisd);
            this.groupBox1.Controls.Add(this.lblJurisd);
            this.groupBox1.Controls.Add(this.lblNumero);
            this.groupBox1.Controls.Add(this.txtLiquidador);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.lblLiquidador);
            this.groupBox1.Controls.Add(this.lblEntidad);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtEntidad);
            this.groupBox1.Controls.Add(this.lblDireccion);
            this.groupBox1.Controls.Add(this.lblApertura);
            this.groupBox1.Controls.Add(this.txtJuzg);
            this.groupBox1.Controls.Add(this.txtApertura);
            this.groupBox1.Controls.Add(this.lblJuzg);
            this.groupBox1.Controls.Add(this.lblNumExpediente);
            this.groupBox1.Controls.Add(this.txtNumExpediente);
            this.groupBox1.Location = new System.Drawing.Point(42, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 229);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // txtJurisd
            // 
            this.txtJurisd.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJurisd.Location = new System.Drawing.Point(205, 142);
            this.txtJurisd.Name = "txtJurisd";
            this.txtJurisd.Size = new System.Drawing.Size(176, 23);
            this.txtJurisd.TabIndex = 15;
            this.txtJurisd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJurisd_KeyPress);
            // 
            // lblJurisd
            // 
            this.lblJurisd.AutoSize = true;
            this.lblJurisd.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJurisd.Location = new System.Drawing.Point(9, 145);
            this.lblJurisd.Name = "lblJurisd";
            this.lblJurisd.Size = new System.Drawing.Size(44, 16);
            this.lblJurisd.TabIndex = 14;
            this.lblJurisd.Text = "JURISD";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(9, 12);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(22, 16);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "N°";
            // 
            // txtLiquidador
            // 
            this.txtLiquidador.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLiquidador.Location = new System.Drawing.Point(205, 197);
            this.txtLiquidador.Name = "txtLiquidador";
            this.txtLiquidador.Size = new System.Drawing.Size(176, 23);
            this.txtLiquidador.TabIndex = 13;
            this.txtLiquidador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLiquidador_KeyPress);
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(205, 9);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(176, 23);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // lblLiquidador
            // 
            this.lblLiquidador.AutoSize = true;
            this.lblLiquidador.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiquidador.Location = new System.Drawing.Point(9, 200);
            this.lblLiquidador.Name = "lblLiquidador";
            this.lblLiquidador.Size = new System.Drawing.Size(157, 16);
            this.lblLiquidador.TabIndex = 12;
            this.lblLiquidador.Text = "LIQUIDADOR RESPONSABLE\t";
            // 
            // lblEntidad
            // 
            this.lblEntidad.AutoSize = true;
            this.lblEntidad.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntidad.Location = new System.Drawing.Point(9, 38);
            this.lblEntidad.Name = "lblEntidad";
            this.lblEntidad.Size = new System.Drawing.Size(57, 16);
            this.lblEntidad.TabIndex = 2;
            this.lblEntidad.Text = "ENTIDAD";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(205, 171);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(176, 23);
            this.txtDireccion.TabIndex = 11;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // txtEntidad
            // 
            this.txtEntidad.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntidad.Location = new System.Drawing.Point(205, 35);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.Size = new System.Drawing.Size(176, 23);
            this.txtEntidad.TabIndex = 3;
            this.txtEntidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntidad_KeyPress);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(9, 174);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(69, 16);
            this.lblDireccion.TabIndex = 10;
            this.lblDireccion.Text = "DIRECCION\t";
            // 
            // lblApertura
            // 
            this.lblApertura.AutoSize = true;
            this.lblApertura.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApertura.Location = new System.Drawing.Point(9, 64);
            this.lblApertura.Name = "lblApertura";
            this.lblApertura.Size = new System.Drawing.Size(66, 16);
            this.lblApertura.TabIndex = 4;
            this.lblApertura.Text = "APERTURA";
            // 
            // txtJuzg
            // 
            this.txtJuzg.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJuzg.Location = new System.Drawing.Point(205, 113);
            this.txtJuzg.Name = "txtJuzg";
            this.txtJuzg.Size = new System.Drawing.Size(176, 23);
            this.txtJuzg.TabIndex = 9;
            this.txtJuzg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJuzg_KeyPress);
            // 
            // txtApertura
            // 
            this.txtApertura.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApertura.Location = new System.Drawing.Point(205, 61);
            this.txtApertura.Name = "txtApertura";
            this.txtApertura.Size = new System.Drawing.Size(176, 23);
            this.txtApertura.TabIndex = 5;
            this.txtApertura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApertura_KeyPress);
            // 
            // lblJuzg
            // 
            this.lblJuzg.AutoSize = true;
            this.lblJuzg.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuzg.Location = new System.Drawing.Point(9, 116);
            this.lblJuzg.Name = "lblJuzg";
            this.lblJuzg.Size = new System.Drawing.Size(35, 16);
            this.lblJuzg.TabIndex = 8;
            this.lblJuzg.Text = "JUZG";
            // 
            // lblNumExpediente
            // 
            this.lblNumExpediente.AutoSize = true;
            this.lblNumExpediente.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumExpediente.Location = new System.Drawing.Point(9, 90);
            this.lblNumExpediente.Name = "lblNumExpediente";
            this.lblNumExpediente.Size = new System.Drawing.Size(90, 16);
            this.lblNumExpediente.TabIndex = 6;
            this.lblNumExpediente.Text = "N° EXPEDIENTE";
            // 
            // txtNumExpediente
            // 
            this.txtNumExpediente.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumExpediente.Location = new System.Drawing.Point(205, 87);
            this.txtNumExpediente.Name = "txtNumExpediente";
            this.txtNumExpediente.Size = new System.Drawing.Size(176, 23);
            this.txtNumExpediente.TabIndex = 7;
            this.txtNumExpediente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumExpediente_KeyPress);
            // 
            // dgrArchivos
            // 
            this.dgrArchivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrArchivos.Location = new System.Drawing.Point(7, 3);
            this.dgrArchivos.Name = "dgrArchivos";
            this.dgrArchivos.ReadOnly = true;
            this.dgrArchivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrArchivos.Size = new System.Drawing.Size(481, 283);
            this.dgrArchivos.TabIndex = 1;
            this.dgrArchivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrArchivos_CellContentClick);
            // 
            // btnCargarProveedor
            // 
            this.btnCargarProveedor.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarProveedor.Location = new System.Drawing.Point(60, 374);
            this.btnCargarProveedor.Name = "btnCargarProveedor";
            this.btnCargarProveedor.Size = new System.Drawing.Size(132, 41);
            this.btnCargarProveedor.TabIndex = 2;
            this.btnCargarProveedor.Tag = "";
            this.btnCargarProveedor.Text = "Nuevo Proveedor";
            this.btnCargarProveedor.UseVisualStyleBackColor = true;
            this.btnCargarProveedor.Click += new System.EventHandler(this.btnNuevoProveedor_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "archivo.png");
            this.imageList1.Images.SetKeyName(1, "carpeta.png");
            this.imageList1.Images.SetKeyName(2, "carpeta-removebg-preview.png");
            this.imageList1.Images.SetKeyName(3, "archivo-removebg-preview.png");
            // 
            // frmBuscarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 565);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBuscarProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBuscarProveedor";
            this.Load += new System.EventHandler(this.frmBuscarProveedor_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlCargarProveedor.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrArchivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treDirectorios;
        private System.Windows.Forms.Button btnMostrarProveedor;
        private System.Windows.Forms.DataGridView dgrArchivos;
        private System.Windows.Forms.Button btnNuevoProveedor;
        private System.Windows.Forms.Panel pnlCargarProveedor;
        private System.Windows.Forms.TextBox txtNumExpediente;
        private System.Windows.Forms.Label lblNumExpediente;
        private System.Windows.Forms.TextBox txtApertura;
        private System.Windows.Forms.Label lblApertura;
        private System.Windows.Forms.TextBox txtEntidad;
        private System.Windows.Forms.Label lblEntidad;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtJuzg;
        private System.Windows.Forms.Label lblJuzg;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtLiquidador;
        private System.Windows.Forms.Label lblLiquidador;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtJurisd;
        private System.Windows.Forms.Label lblJurisd;
        private System.Windows.Forms.Button btnCargarProveedor;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnEliminarProveedor;
        private System.Windows.Forms.Button btnModificarProveedor;
    }
}