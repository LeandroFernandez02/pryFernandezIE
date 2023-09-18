
namespace pryFernandezIES
{
    partial class frmCargarProveedor
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
            this.btnSeleccionCarpeta = new System.Windows.Forms.Button();
            this.fbdSeleccionCarpeta = new System.Windows.Forms.FolderBrowserDialog();
            this.lblRuta = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombreArchivo = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSeleccionCarpeta
            // 
            this.btnSeleccionCarpeta.Location = new System.Drawing.Point(239, 100);
            this.btnSeleccionCarpeta.Name = "btnSeleccionCarpeta";
            this.btnSeleccionCarpeta.Size = new System.Drawing.Size(170, 36);
            this.btnSeleccionCarpeta.TabIndex = 0;
            this.btnSeleccionCarpeta.Text = "Seleccion Carpeta";
            this.btnSeleccionCarpeta.UseVisualStyleBackColor = true;
            this.btnSeleccionCarpeta.Click += new System.EventHandler(this.btnSeleccionCarpeta_Click);
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(332, 157);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(0, 13);
            this.lblRuta.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(239, 243);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(170, 36);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.Location = new System.Drawing.Point(239, 198);
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.Size = new System.Drawing.Size(170, 20);
            this.txtNombreArchivo.TabIndex = 3;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(203, 157);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(123, 13);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Direccion Seleccionada:";
            // 
            // frmCargarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 522);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtNombreArchivo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.btnSeleccionCarpeta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCargarProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSeleccionCarpeta;
        private System.Windows.Forms.FolderBrowserDialog fbdSeleccionCarpeta;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombreArchivo;
        private System.Windows.Forms.Label lblDireccion;
    }
}