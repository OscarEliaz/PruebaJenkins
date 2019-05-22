namespace IxCacaoApp.Vista
{
    partial class ActualizarProd
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
            this.tb_stock = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_preUn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_choc = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_inclusion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_aroma = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_porc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_origen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.l_mensajes = new System.Windows.Forms.Label();
            this.b_Restablecer = new System.Windows.Forms.Button();
            this.b_Guardar = new System.Windows.Forms.Button();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_idProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_consultar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_stock
            // 
            this.tb_stock.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_stock.Location = new System.Drawing.Point(528, 163);
            this.tb_stock.Name = "tb_stock";
            this.tb_stock.Size = new System.Drawing.Size(103, 27);
            this.tb_stock.TabIndex = 62;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(524, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 21);
            this.label10.TabIndex = 61;
            this.label10.Text = "Stock";
            // 
            // tb_preUn
            // 
            this.tb_preUn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_preUn.Location = new System.Drawing.Point(291, 163);
            this.tb_preUn.Name = "tb_preUn";
            this.tb_preUn.Size = new System.Drawing.Size(174, 27);
            this.tb_preUn.TabIndex = 60;
            this.tb_preUn.TextChanged += new System.EventHandler(this.tb_preUn_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(287, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 59;
            this.label4.Text = "Precio Unitario";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cb_choc
            // 
            this.cb_choc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_choc.FormattingEnabled = true;
            this.cb_choc.Items.AddRange(new object[] {
            "choco 1",
            "choco 2"});
            this.cb_choc.Location = new System.Drawing.Point(30, 163);
            this.cb_choc.Name = "cb_choc";
            this.cb_choc.Size = new System.Drawing.Size(223, 27);
            this.cb_choc.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 21);
            this.label9.TabIndex = 57;
            this.label9.Text = "Chocolatero";
            // 
            // cb_inclusion
            // 
            this.cb_inclusion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_inclusion.FormattingEnabled = true;
            this.cb_inclusion.Items.AddRange(new object[] {
            "inclusion 1",
            "inclusion 2"});
            this.cb_inclusion.Location = new System.Drawing.Point(262, 105);
            this.cb_inclusion.Name = "cb_inclusion";
            this.cb_inclusion.Size = new System.Drawing.Size(203, 27);
            this.cb_inclusion.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(258, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 21);
            this.label8.TabIndex = 55;
            this.label8.Text = "Inclusion";
            // 
            // cb_aroma
            // 
            this.cb_aroma.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_aroma.FormattingEnabled = true;
            this.cb_aroma.Items.AddRange(new object[] {
            "Frutal",
            "Menta"});
            this.cb_aroma.Location = new System.Drawing.Point(29, 106);
            this.cb_aroma.Name = "cb_aroma";
            this.cb_aroma.Size = new System.Drawing.Size(185, 27);
            this.cb_aroma.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 21);
            this.label7.TabIndex = 53;
            this.label7.Text = "Aroma";
            // 
            // tb_porc
            // 
            this.tb_porc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_porc.Location = new System.Drawing.Point(532, 105);
            this.tb_porc.Name = "tb_porc";
            this.tb_porc.Size = new System.Drawing.Size(99, 27);
            this.tb_porc.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(528, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 21);
            this.label6.TabIndex = 51;
            this.label6.Text = "Porcentaje";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cb_origen
            // 
            this.cb_origen.FormattingEnabled = true;
            this.cb_origen.Items.AddRange(new object[] {
            "Chile",
            "Ecuador",
            "Colombia"});
            this.cb_origen.Location = new System.Drawing.Point(504, 46);
            this.cb_origen.Name = "cb_origen";
            this.cb_origen.Size = new System.Drawing.Size(162, 28);
            this.cb_origen.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(504, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 49;
            this.label3.Text = "Origen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(223, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 21);
            this.label5.TabIndex = 48;
            this.label5.Text = "Nombre";
            // 
            // l_mensajes
            // 
            this.l_mensajes.AutoSize = true;
            this.l_mensajes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_mensajes.ForeColor = System.Drawing.Color.Maroon;
            this.l_mensajes.Location = new System.Drawing.Point(24, 14);
            this.l_mensajes.Name = "l_mensajes";
            this.l_mensajes.Size = new System.Drawing.Size(156, 19);
            this.l_mensajes.TabIndex = 46;
            this.l_mensajes.Text = "Zona de mensajes";
            // 
            // b_Restablecer
            // 
            this.b_Restablecer.BackColor = System.Drawing.Color.Cornsilk;
            this.b_Restablecer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Restablecer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_Restablecer.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Restablecer.Image = global::IxCacaoApp.Properties.Resources.ix_cacao;
            this.b_Restablecer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b_Restablecer.Location = new System.Drawing.Point(12, 202);
            this.b_Restablecer.Name = "b_Restablecer";
            this.b_Restablecer.Size = new System.Drawing.Size(214, 40);
            this.b_Restablecer.TabIndex = 45;
            this.b_Restablecer.Text = "Restablecer";
            this.b_Restablecer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_Restablecer.UseVisualStyleBackColor = false;
            this.b_Restablecer.Click += new System.EventHandler(this.b_Restablecer_Click);
            // 
            // b_Guardar
            // 
            this.b_Guardar.BackColor = System.Drawing.Color.Cornsilk;
            this.b_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_Guardar.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Guardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b_Guardar.Image = global::IxCacaoApp.Properties.Resources.ix_cacao;
            this.b_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b_Guardar.Location = new System.Drawing.Point(12, 121);
            this.b_Guardar.Name = "b_Guardar";
            this.b_Guardar.Size = new System.Drawing.Size(214, 40);
            this.b_Guardar.TabIndex = 44;
            this.b_Guardar.Text = "Guardar";
            this.b_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_Guardar.UseVisualStyleBackColor = false;
            this.b_Guardar.Click += new System.EventHandler(this.b_Guardar_Click);
            // 
            // tb_nombre
            // 
            this.tb_nombre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nombre.Location = new System.Drawing.Point(209, 47);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(268, 27);
            this.tb_nombre.TabIndex = 43;
            // 
            // tb_idProd
            // 
            this.tb_idProd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_idProd.Location = new System.Drawing.Point(29, 47);
            this.tb_idProd.Name = "tb_idProd";
            this.tb_idProd.Size = new System.Drawing.Size(145, 27);
            this.tb_idProd.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "Id Producto";
            // 
            // bt_consultar
            // 
            this.bt_consultar.BackColor = System.Drawing.Color.Cornsilk;
            this.bt_consultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_consultar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_consultar.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_consultar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_consultar.Image = global::IxCacaoApp.Properties.Resources.ix_cacao;
            this.bt_consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_consultar.Location = new System.Drawing.Point(12, 37);
            this.bt_consultar.Name = "bt_consultar";
            this.bt_consultar.Size = new System.Drawing.Size(214, 40);
            this.bt_consultar.TabIndex = 63;
            this.bt_consultar.Text = "Consultar";
            this.bt_consultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_consultar.UseVisualStyleBackColor = false;
            this.bt_consultar.Click += new System.EventHandler(this.bt_consultar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_porc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_preUn);
            this.groupBox1.Controls.Add(this.tb_stock);
            this.groupBox1.Controls.Add(this.cb_choc);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cb_origen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cb_aroma);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cb_inclusion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_nombre);
            this.groupBox1.Controls.Add(this.tb_idProd);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 213);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso De Datos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.l_mensajes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 271);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 50);
            this.panel1.TabIndex = 65;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.b_Guardar);
            this.panel2.Controls.Add(this.b_Restablecer);
            this.panel2.Controls.Add(this.bt_consultar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(735, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 271);
            this.panel2.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Beige;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(22, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 36);
            this.label2.TabIndex = 67;
            this.label2.Text = "Actualizar Productos";
            // 
            // ActualizarProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(973, 321);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActualizarProd";
            this.Text = "ActualizarProd";
            this.Load += new System.EventHandler(this.ActualizarProd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_stock;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_preUn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_choc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_inclusion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_aroma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_porc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_origen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label l_mensajes;
        private System.Windows.Forms.Button b_Restablecer;
        private System.Windows.Forms.Button b_Guardar;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.TextBox tb_idProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_consultar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}