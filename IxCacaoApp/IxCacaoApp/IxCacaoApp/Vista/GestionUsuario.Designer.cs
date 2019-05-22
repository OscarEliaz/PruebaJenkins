namespace IxCacaoApp.Vista
{
    partial class GestionUsuario
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_tipoUsuario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nombreUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_conContraseña = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.b_Restablecer = new System.Windows.Forms.Button();
            this.b_Guardar = new System.Windows.Forms.Button();
            this.l_mensajes = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Beige;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(13, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 36);
            this.label2.TabIndex = 91;
            this.label2.Text = "Gestion Usuarios";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b_Restablecer);
            this.groupBox1.Controls.Add(this.b_Guardar);
            this.groupBox1.Controls.Add(this.txt_contraseña);
            this.groupBox1.Controls.Add(this.txt_conContraseña);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_nombreUsuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_tipoUsuario);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(926, 186);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cambiar Contraseña De Usuarios";
            // 
            // cb_tipoUsuario
            // 
            this.cb_tipoUsuario.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cb_tipoUsuario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tipoUsuario.ForeColor = System.Drawing.SystemColors.Window;
            this.cb_tipoUsuario.FormattingEnabled = true;
            this.cb_tipoUsuario.Items.AddRange(new object[] {
            "Seleccione",
            "Administador",
            "Usuario Comun"});
            this.cb_tipoUsuario.Location = new System.Drawing.Point(129, 56);
            this.cb_tipoUsuario.Name = "cb_tipoUsuario";
            this.cb_tipoUsuario.Size = new System.Drawing.Size(185, 27);
            this.cb_tipoUsuario.TabIndex = 32;
            this.cb_tipoUsuario.SelectedIndexChanged += new System.EventHandler(this.cb_tipoUsuario_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tipo Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 34;
            this.label3.Text = "Nombre Usuario";
            // 
            // tb_nombreUsuario
            // 
            this.tb_nombreUsuario.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_nombreUsuario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nombreUsuario.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_nombreUsuario.Location = new System.Drawing.Point(129, 103);
            this.tb_nombreUsuario.Name = "tb_nombreUsuario";
            this.tb_nombreUsuario.Size = new System.Drawing.Size(228, 27);
            this.tb_nombreUsuario.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(363, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 36;
            this.label4.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(363, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 23);
            this.label5.TabIndex = 37;
            this.label5.Text = "Confirmar Contraseña";
            // 
            // txt_conContraseña
            // 
            this.txt_conContraseña.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_conContraseña.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_conContraseña.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_conContraseña.Location = new System.Drawing.Point(524, 143);
            this.txt_conContraseña.Name = "txt_conContraseña";
            this.txt_conContraseña.PasswordChar = '*';
            this.txt_conContraseña.Size = new System.Drawing.Size(208, 27);
            this.txt_conContraseña.TabIndex = 38;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_contraseña.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contraseña.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_contraseña.Location = new System.Drawing.Point(524, 103);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.PasswordChar = '*';
            this.txt_contraseña.Size = new System.Drawing.Size(208, 27);
            this.txt_contraseña.TabIndex = 39;
            // 
            // b_Restablecer
            // 
            this.b_Restablecer.BackColor = System.Drawing.Color.Cornsilk;
            this.b_Restablecer.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Restablecer.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.b_Restablecer.Image = global::IxCacaoApp.Properties.Resources.ix_cacao;
            this.b_Restablecer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b_Restablecer.Location = new System.Drawing.Point(753, 134);
            this.b_Restablecer.Name = "b_Restablecer";
            this.b_Restablecer.Size = new System.Drawing.Size(167, 40);
            this.b_Restablecer.TabIndex = 41;
            this.b_Restablecer.Text = "Restablecer";
            this.b_Restablecer.UseVisualStyleBackColor = false;
            this.b_Restablecer.Click += new System.EventHandler(this.b_Restablecer_Click);
            // 
            // b_Guardar
            // 
            this.b_Guardar.BackColor = System.Drawing.Color.Cornsilk;
            this.b_Guardar.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Guardar.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.b_Guardar.Image = global::IxCacaoApp.Properties.Resources.ix_cacao;
            this.b_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b_Guardar.Location = new System.Drawing.Point(753, 85);
            this.b_Guardar.Name = "b_Guardar";
            this.b_Guardar.Size = new System.Drawing.Size(167, 40);
            this.b_Guardar.TabIndex = 40;
            this.b_Guardar.Text = "Guardar";
            this.b_Guardar.UseVisualStyleBackColor = false;
            this.b_Guardar.Click += new System.EventHandler(this.b_Guardar_Click);
            // 
            // l_mensajes
            // 
            this.l_mensajes.AutoSize = true;
            this.l_mensajes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_mensajes.ForeColor = System.Drawing.Color.Maroon;
            this.l_mensajes.Location = new System.Drawing.Point(15, 269);
            this.l_mensajes.Name = "l_mensajes";
            this.l_mensajes.Size = new System.Drawing.Size(156, 19);
            this.l_mensajes.TabIndex = 93;
            this.l_mensajes.Text = "Zona de mensajes";
            // 
            // GestionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(957, 299);
            this.Controls.Add(this.l_mensajes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "GestionUsuario";
            this.Text = "ConsultarProd";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_tipoUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.TextBox txt_conContraseña;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_nombreUsuario;
        private System.Windows.Forms.Button b_Restablecer;
        private System.Windows.Forms.Button b_Guardar;
        private System.Windows.Forms.Label l_mensajes;
    }
}