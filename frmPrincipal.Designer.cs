﻿
namespace pryFernandezIES
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnCargarProveedores = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.pnlFormHijo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.pnlFormHijo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(73)))), ((int)(((byte)(123)))));
            this.pnlMenu.Controls.Add(this.btnBuscarProveedor);
            this.pnlMenu.Controls.Add(this.btnAyuda);
            this.pnlMenu.Controls.Add(this.btnCargarProveedores);
            this.pnlMenu.Controls.Add(this.btnClientes);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 561);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.btnBuscarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProveedor.FlatAppearance.BorderSize = 0;
            this.btnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProveedor.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProveedor.Location = new System.Drawing.Point(0, 194);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(200, 37);
            this.btnBuscarProveedor.TabIndex = 3;
            this.btnBuscarProveedor.Text = "Buscar Proveedor";
            this.btnBuscarProveedor.UseVisualStyleBackColor = false;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.btnAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.ForeColor = System.Drawing.Color.White;
            this.btnAyuda.Location = new System.Drawing.Point(0, 237);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(200, 37);
            this.btnAyuda.TabIndex = 2;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnCargarProveedores
            // 
            this.btnCargarProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.btnCargarProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarProveedores.FlatAppearance.BorderSize = 0;
            this.btnCargarProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarProveedores.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarProveedores.ForeColor = System.Drawing.Color.White;
            this.btnCargarProveedores.Location = new System.Drawing.Point(0, 151);
            this.btnCargarProveedores.Name = "btnCargarProveedores";
            this.btnCargarProveedores.Size = new System.Drawing.Size(200, 37);
            this.btnCargarProveedores.TabIndex = 2;
            this.btnCargarProveedores.Text = "Cargar Proveedor";
            this.btnCargarProveedores.UseVisualStyleBackColor = false;
            this.btnCargarProveedores.Click += new System.EventHandler(this.btnCargarProveedores_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Location = new System.Drawing.Point(0, 106);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(200, 37);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.White;
            this.pnlLogo.Controls.Add(this.pctLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.ForeColor = System.Drawing.Color.White;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(200, 100);
            this.pnlLogo.TabIndex = 0;
            // 
            // pctLogo
            // 
            this.pctLogo.Image = global::pryFernandezIES.Properties.Resources.logobbvaBlanco;
            this.pctLogo.Location = new System.Drawing.Point(-40, -35);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(265, 180);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctLogo.TabIndex = 1;
            this.pctLogo.TabStop = false;
            // 
            // pnlFormHijo
            // 
            this.pnlFormHijo.Controls.Add(this.pictureBox1);
            this.pnlFormHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormHijo.Location = new System.Drawing.Point(200, 0);
            this.pnlFormHijo.Name = "pnlFormHijo";
            this.pnlFormHijo.Size = new System.Drawing.Size(734, 561);
            this.pnlFormHijo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::pryFernandezIES.Properties.Resources.imgLogoSeguro;
            this.pictureBox1.Location = new System.Drawing.Point(155, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(427, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.pnlFormHijo);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.pnlFormHijo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnCargarProveedores;
        private System.Windows.Forms.Panel pnlFormHijo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBuscarProveedor;
    }
}