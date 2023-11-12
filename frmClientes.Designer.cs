
namespace pryFernandezIES
{
    partial class frmClientes
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
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblEstadoConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnLocura = new System.Windows.Forms.Button();
            this.btnActividad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(12, 79);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(728, 362);
            this.dgvCliente.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstadoConexion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 543);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(752, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblEstadoConexion
            // 
            this.lblEstadoConexion.Name = "lblEstadoConexion";
            this.lblEstadoConexion.Size = new System.Drawing.Size(28, 17);
            this.lblEstadoConexion.Text = "* * *";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(440, 447);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 2;
            // 
            // btnLocura
            // 
            this.btnLocura.Location = new System.Drawing.Point(546, 445);
            this.btnLocura.Name = "btnLocura";
            this.btnLocura.Size = new System.Drawing.Size(75, 23);
            this.btnLocura.TabIndex = 3;
            this.btnLocura.Text = "Buscar";
            this.btnLocura.UseVisualStyleBackColor = true;
            this.btnLocura.Click += new System.EventHandler(this.btnLocura_Click);
            // 
            // btnActividad
            // 
            this.btnActividad.Location = new System.Drawing.Point(297, 445);
            this.btnActividad.Name = "btnActividad";
            this.btnActividad.Size = new System.Drawing.Size(119, 23);
            this.btnActividad.TabIndex = 4;
            this.btnActividad.Text = "Modificar Actividad";
            this.btnActividad.UseVisualStyleBackColor = true;
            this.btnActividad.Click += new System.EventHandler(this.btnActividad_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 565);
            this.Controls.Add(this.btnActividad);
            this.Controls.Add(this.btnLocura);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmClientes_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstadoConexion;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnLocura;
        private System.Windows.Forms.Button btnActividad;
    }
}