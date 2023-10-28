using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryFernandezIES
{
    public partial class frmInicioSesion : Form
    {
        clsBaseDatosUsuarios objBaseDatosUsuario;
        public frmInicioSesion()
        {
            InitializeComponent();

            objBaseDatosUsuario = new clsBaseDatosUsuarios();
            objBaseDatosUsuario.ConectarBD();
        }
         
        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            if (btnInicioSesion.Text == "Siguiente")
            {                              
                //Situacion de error USUARIO  
                if (txtUsuario.Text == string.Empty)
                {                  
                    lblErrorUsuario.Visible = true;
                    lblErrorUsuario.Text = "El Campo Usuario esta Vacio";
                    pnlLineaUsuario.BackColor = Color.Red;                      
                }
                else
                {
                    timer1.Start();
                    lblCopiaUsuario.Text = txtUsuario.Text;
                    btnInicioSesion.Text = "Acceder";
                    txtContraseña.Focus();
                }               
            }
            else if (btnInicioSesion.Text == "Acceder")
            {              
                objBaseDatosUsuario.Login(txtUsuario.Text, txtContraseña.Text, this);
                
                //Situacion de error CONTRASEÑA
                if (txtContraseña.Text == string.Empty)
                {
                    lblErrorContraseña.Visible = true;
                    lblErrorContraseña.Text = "El Campo Contraseña esta Vacio";
                    pnlLineaContraseña.BackColor = Color.Red;                   
                }
            }
        }

        private bool controlTimer = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(!controlTimer)
            {
                pnlUsuario.Left -= 10;
                pnlContraseña.Left -= 10;
                if (pnlContraseña.Left <= 17)
                {
                    timer1.Stop();
                    controlTimer = true;
                }
            }
            else
            {
                pnlUsuario.Left += 10;
                pnlContraseña.Left += 10;
                if (pnlUsuario.Left >= 17)
                {
                    timer1.Stop();
                    txtUsuario.Focus();
                    btnInicioSesion.Text = "Siguiente";
                    controlTimer = false;
                    txtContraseña.Text = string.Empty;
                    lblErrorContraseña.Visible = false;
                }
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            pnlLineaUsuario.BackColor = Color.FromArgb(10, 60, 140);
            lblErrorUsuario.Visible = false;
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            pnlLineaContraseña.BackColor = Color.FromArgb(10, 60, 140);
            lblErrorContraseña.Visible = false;
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            pnlLineaUsuario.BackColor = Color.Black;

        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            pnlLineaContraseña.BackColor = Color.Black;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
