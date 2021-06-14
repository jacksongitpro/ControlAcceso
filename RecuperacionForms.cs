using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//JacksonGarcia

namespace ControlAcceso
{
    public partial class RecuperacionForms : Form
    {

        
            
        public RecuperacionForms()
        {        
            InitializeComponent();
            usuariocombo.DataSource = BaseDeDatos.Usuarios;
            usuariocombo.DisplayMember = "nombre";
            btncambiar.Click += btncambiar_Click;
            //SetUsuario(admincreado);
        }
        List<Usuario> Usuarios = BaseDeDatos.Usuarios;
        private void btncambiar_Click(object sender, EventArgs e)
        {
           

            if (PassConfirmtextBox != PassNuevaBox)
            {
                PassNuevaBox.Clear();
                PassNuevaBox.Focus();
                MessageBox.Show("ingrese claves iguales");
            }
            else
            {
                Usuario user = Usuarios.Find((Usuario admin) => admin.password == PassConfirmtextBox.Text);
                BaseDeDatos.Usuarios.Add(user);
                BaseDeDatos.Usuarios.RemoveAt(0);
                Ingreso Form = new Ingreso();//user
                Form.ShowDialog();
                //admincreado.password = PassNuevaBox.Text;
                //admincreado.nombre = admincreado.nombre;
                //admincreado.codigo = admincreado.codigo;
            }

        }

        //private void btnCancelar_Click(object sender, EventArgs e)
        //{
        //    Usuario user = Usuarios.Find((Usuario admin) => admin.codigo == RtaSecretatextBox.Text);
        //    if (RtaSecretatextBox.Text != admin.codigo)
        //    {
        //        MessageBox.Show("!!ERROR!! Codigo invalido");
        //        RtaSecretatextBox.Clear();
        //        RtaSecretatextBox.Focus();
        //        return;
        //    }
        //    else
        //    {
        //        //MessageBox.Show("!!Bienvenido!!");
        //        RtaSecretatextBox.Clear();
        //        PassNuevaBox.Enabled = true;
        //        PassConfirmtextBox.Enabled = true;

        //    }
        //}


        private void RecuperacionForms_Load(object sender, EventArgs e)
        {

        }

        private void passNueva_Click(object sender, EventArgs e)
        {

        }                
        
        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PassConfirmtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PassNuevaBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {

        }
        private void linkLabel1RC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //RecuperacionForms Form = new RecuperacionForms();
            //Form.ShowDialog();
        }

        private void RtaSecretatextBox_TextChanged(object sender, EventArgs e)
        {
            Usuario user = Usuarios.Find((Usuario admin) => admin.codigo == RtaSecretatextBox.Text); ;
            //if (RtaSecretatextBox.Text == user.codigo)
            //{
            //    PassNuevaBox.Enabled = true;
            //    PassConfirmtextBox.Enabled = true;
            //}
        }
    }
}
