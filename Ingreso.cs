using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//JacksonGarcia
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlAcceso;


namespace ControlAcceso
{
    public partial class Ingreso : Form 
    {
        //public static Usuario Usuario;
        List<Usuario> Usuarios;

        public Ingreso()
        {
            InitializeComponent();
            Usuarios = BaseDeDatos.Usuarios;
        }      

        private void NombretextUsuario_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            Usuario user = Usuarios.Find((Usuario admin)=> admin.nombre == NombretextUsuario.Text && admin.password == textContraseña.Text);
            if (user != null)
            {
                MessageBox.Show("Ingreso Exitoso");
                frmPrincipal Form = new frmPrincipal();
                Form.ShowDialog();
            }
            else
            {
                MessageBox.Show("!!ERROR!! usuario o contraseña invalido");
                NombretextUsuario.Clear();
                textContraseña.Clear();
                NombretextUsuario.Focus();
                return;             

            }          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void Ingreso_Load(object sender, EventArgs e)
        {

        }       
       
        private void labelUsuario_Click(object sender, EventArgs e)
        {

           
        }
      

        private void labelClinica_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1RC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperacionForms Form = new RecuperacionForms();
            Form.ShowDialog();
        }
    }
}
