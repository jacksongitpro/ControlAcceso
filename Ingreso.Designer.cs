
namespace ControlAcceso
//JacksonGarcia
{
    partial class Ingreso
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
            this.labelClinica = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.linkLabel1RC = new System.Windows.Forms.LinkLabel();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.NombretextUsuario = new System.Windows.Forms.TextBox();
            this.textContraseña = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelClinica
            // 
            this.labelClinica.AutoSize = true;
            this.labelClinica.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClinica.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelClinica.Location = new System.Drawing.Point(24, 23);
            this.labelClinica.Name = "labelClinica";
            this.labelClinica.Size = new System.Drawing.Size(231, 38);
            this.labelClinica.TabIndex = 0;
            this.labelClinica.Text = "Clinica ISTEA";
            this.labelClinica.Click += new System.EventHandler(this.labelClinica_Click);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelUsuario.Location = new System.Drawing.Point(27, 66);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(67, 20);
            this.labelUsuario.TabIndex = 1;
            this.labelUsuario.Text = "Usuario";
            this.labelUsuario.Click += new System.EventHandler(this.labelUsuario_Click);
            // 
            // linkLabel1RC
            // 
            this.linkLabel1RC.AutoSize = true;
            this.linkLabel1RC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1RC.Location = new System.Drawing.Point(81, 194);
            this.linkLabel1RC.Name = "linkLabel1RC";
            this.linkLabel1RC.Size = new System.Drawing.Size(103, 17);
            this.linkLabel1RC.TabIndex = 2;
            this.linkLabel1RC.TabStop = true;
            this.linkLabel1RC.Text = "Olvide mi clave";
            this.linkLabel1RC.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1RC_LinkClicked);
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseña.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelContraseña.Location = new System.Drawing.Point(27, 130);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(95, 20);
            this.labelContraseña.TabIndex = 3;
            this.labelContraseña.Text = "Contraseña";
            // 
            // NombretextUsuario
            // 
            this.NombretextUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombretextUsuario.ForeColor = System.Drawing.Color.Blue;
            this.NombretextUsuario.Location = new System.Drawing.Point(31, 89);
            this.NombretextUsuario.Name = "NombretextUsuario";
            this.NombretextUsuario.Size = new System.Drawing.Size(212, 38);
            this.NombretextUsuario.TabIndex = 4;
            this.NombretextUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textContraseña
            // 
            this.textContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textContraseña.ForeColor = System.Drawing.Color.Blue;
            this.textContraseña.Location = new System.Drawing.Point(31, 153);
            this.textContraseña.Name = "textContraseña";
            this.textContraseña.Size = new System.Drawing.Size(212, 38);
            this.textContraseña.TabIndex = 5;
            this.textContraseña.UseSystemPasswordChar = true;
            this.textContraseña.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.OliveDrab;
            this.btnIngresar.Location = new System.Drawing.Point(31, 231);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(212, 45);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 289);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.textContraseña);
            this.Controls.Add(this.NombretextUsuario);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.linkLabel1RC);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.labelClinica);
            this.Name = "Ingreso";
            this.Text = "Ingreso";
            this.Load += new System.EventHandler(this.Ingreso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClinica;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.LinkLabel linkLabel1RC;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.TextBox NombretextUsuario;
        private System.Windows.Forms.TextBox textContraseña;
        public System.Windows.Forms.Button btnIngresar;
    }
}

