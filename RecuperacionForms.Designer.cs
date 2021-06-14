
namespace ControlAcceso
{
    partial class RecuperacionForms
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
            this.LabelRtaSecreta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RtaSecretatextBox = new System.Windows.Forms.TextBox();
            this.passNuevaLabel = new System.Windows.Forms.Label();
            this.PassConfirm = new System.Windows.Forms.Label();
            this.PassNuevaBox = new System.Windows.Forms.TextBox();
            this.PassConfirmtextBox = new System.Windows.Forms.TextBox();
            this.btncambiar = new System.Windows.Forms.Button();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.labelusuario = new System.Windows.Forms.Label();
            this.usuariocombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LabelRtaSecreta
            // 
            this.LabelRtaSecreta.AutoSize = true;
            this.LabelRtaSecreta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRtaSecreta.Location = new System.Drawing.Point(28, 59);
            this.LabelRtaSecreta.Name = "LabelRtaSecreta";
            this.LabelRtaSecreta.Size = new System.Drawing.Size(209, 20);
            this.LabelRtaSecreta.TabIndex = 0;
            this.LabelRtaSecreta.Text = "Cual es tu codigo secreto?";
            this.LabelRtaSecreta.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 1;
            // 
            // RtaSecretatextBox
            // 
            this.RtaSecretatextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtaSecretatextBox.Location = new System.Drawing.Point(28, 87);
            this.RtaSecretatextBox.Name = "RtaSecretatextBox";
            this.RtaSecretatextBox.Size = new System.Drawing.Size(236, 22);
            this.RtaSecretatextBox.TabIndex = 2;
            this.RtaSecretatextBox.UseSystemPasswordChar = true;
            this.RtaSecretatextBox.TextChanged += new System.EventHandler(this.RtaSecretatextBox_TextChanged);
            // 
            // passNuevaLabel
            // 
            this.passNuevaLabel.AutoSize = true;
            this.passNuevaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passNuevaLabel.Location = new System.Drawing.Point(28, 145);
            this.passNuevaLabel.Name = "passNuevaLabel";
            this.passNuevaLabel.Size = new System.Drawing.Size(103, 20);
            this.passNuevaLabel.TabIndex = 3;
            this.passNuevaLabel.Text = "Nueva Clave";
            this.passNuevaLabel.Click += new System.EventHandler(this.passNueva_Click);
            // 
            // PassConfirm
            // 
            this.PassConfirm.AutoSize = true;
            this.PassConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassConfirm.Location = new System.Drawing.Point(24, 189);
            this.PassConfirm.Name = "PassConfirm";
            this.PassConfirm.Size = new System.Drawing.Size(124, 20);
            this.PassConfirm.TabIndex = 4;
            this.PassConfirm.Text = "Confirme Clave";
            // 
            // PassNuevaBox
            // 
            this.PassNuevaBox.Enabled = false;
            this.PassNuevaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassNuevaBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PassNuevaBox.Location = new System.Drawing.Point(28, 164);
            this.PassNuevaBox.Name = "PassNuevaBox";
            this.PassNuevaBox.Size = new System.Drawing.Size(236, 22);
            this.PassNuevaBox.TabIndex = 5;
            this.PassNuevaBox.UseSystemPasswordChar = true;
            this.PassNuevaBox.TextChanged += new System.EventHandler(this.PassNuevaBox_TextChanged);
            // 
            // PassConfirmtextBox
            // 
            this.PassConfirmtextBox.Enabled = false;
            this.PassConfirmtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassConfirmtextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PassConfirmtextBox.Location = new System.Drawing.Point(28, 213);
            this.PassConfirmtextBox.Name = "PassConfirmtextBox";
            this.PassConfirmtextBox.Size = new System.Drawing.Size(236, 22);
            this.PassConfirmtextBox.TabIndex = 6;
            this.PassConfirmtextBox.UseSystemPasswordChar = true;
            this.PassConfirmtextBox.TextChanged += new System.EventHandler(this.PassConfirmtextBox_TextChanged);
            // 
            // btncambiar
            // 
            this.btncambiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncambiar.ForeColor = System.Drawing.Color.OliveDrab;
            this.btncambiar.Location = new System.Drawing.Point(28, 241);
            this.btncambiar.Name = "btncambiar";
            this.btncambiar.Size = new System.Drawing.Size(236, 25);
            this.btncambiar.TabIndex = 7;
            this.btncambiar.Text = "Cambiar";
            this.btncambiar.UseVisualStyleBackColor = true;
            this.btncambiar.Click += new System.EventHandler(this.btncambiar_Click);
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperar.ForeColor = System.Drawing.Color.OliveDrab;
            this.btnRecuperar.Location = new System.Drawing.Point(28, 115);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(236, 27);
            this.btnRecuperar.TabIndex = 8;
            this.btnRecuperar.Text = "Recuperar";
            this.btnRecuperar.UseVisualStyleBackColor = true;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // labelusuario
            // 
            this.labelusuario.AutoSize = true;
            this.labelusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusuario.Location = new System.Drawing.Point(7, 9);
            this.labelusuario.Name = "labelusuario";
            this.labelusuario.Size = new System.Drawing.Size(85, 25);
            this.labelusuario.TabIndex = 9;
            this.labelusuario.Text = "Usuario:";
            this.labelusuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // usuariocombo
            // 
            this.usuariocombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usuariocombo.FormattingEnabled = true;
            this.usuariocombo.Location = new System.Drawing.Point(98, 10);
            this.usuariocombo.Name = "usuariocombo";
            this.usuariocombo.Size = new System.Drawing.Size(166, 24);
            this.usuariocombo.TabIndex = 11;
            this.usuariocombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // RecuperacionForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 312);
            this.Controls.Add(this.usuariocombo);
            this.Controls.Add(this.labelusuario);
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.btncambiar);
            this.Controls.Add(this.PassConfirmtextBox);
            this.Controls.Add(this.PassNuevaBox);
            this.Controls.Add(this.PassConfirm);
            this.Controls.Add(this.passNuevaLabel);
            this.Controls.Add(this.RtaSecretatextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelRtaSecreta);
            this.Name = "RecuperacionForms";
            this.Text = "Recuperacion de Contraseñas";
            this.Load += new System.EventHandler(this.RecuperacionForms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelRtaSecreta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RtaSecretatextBox;
        private System.Windows.Forms.Label passNuevaLabel;
        private System.Windows.Forms.Label PassConfirm;
        private System.Windows.Forms.TextBox PassNuevaBox;
        private System.Windows.Forms.TextBox PassConfirmtextBox;
        private System.Windows.Forms.Button btncambiar;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.Label labelusuario;
        private System.Windows.Forms.ComboBox usuariocombo;
    }
}