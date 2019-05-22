namespace IxCacaoApp.Vista
{
    partial class AgregarProd
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
            this.l_mensajes = new System.Windows.Forms.Label();
            this.b_Restablecer = new System.Windows.Forms.Button();
            this.b_Guardar = new System.Windows.Forms.Button();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_idProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_origen = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_porc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_aroma = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_inclusion = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_choc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_preUn = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_stock = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // l_mensajes
            // 
            this.l_mensajes.AutoSize = true;
            this.l_mensajes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_mensajes.ForeColor = System.Drawing.Color.Maroon;
            this.l_mensajes.Location = new System.Drawing.Point(43, 289);
            this.l_mensajes.Name = "l_mensajes";
            this.l_mensajes.Size = new System.Drawing.Size(156, 19);
            this.l_mensajes.TabIndex = 23;
            this.l_mensajes.Text = "Zona de mensajes";
            this.l_mensajes.Click += new System.EventHandler(this.l_mensajes_Click);
            // 
            // b_Restablecer
            // 
            this.b_Restablecer.BackColor = System.Drawing.Color.Cornsilk;
            this.b_Restablecer.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Restablecer.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.b_Restablecer.Image = global::IxCacaoApp.Properties.Resources.ix_cacao;
            this.b_Restablecer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b_Restablecer.Location = new System.Drawing.Point(745, 174);
            this.b_Restablecer.Name = "b_Restablecer";
            this.b_Restablecer.Size = new System.Drawing.Size(176, 40);
            this.b_Restablecer.TabIndex = 21;
            this.b_Restablecer.Text = "Restablecer";
            this.b_Restablecer.UseVisualStyleBackColor = false;
            this.b_Restablecer.Click += new System.EventHandler(this.b_Restablecer_Click_1);
            // 
            // b_Guardar
            // 
            this.b_Guardar.BackColor = System.Drawing.Color.Cornsilk;
            this.b_Guardar.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Guardar.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.b_Guardar.Image = global::IxCacaoApp.Properties.Resources.ix_cacao;
            this.b_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b_Guardar.Location = new System.Drawing.Point(565, 174);
            this.b_Guardar.Name = "b_Guardar";
            this.b_Guardar.Size = new System.Drawing.Size(174, 40);
            this.b_Guardar.TabIndex = 20;
            this.b_Guardar.Text = "Guardar";
            this.b_Guardar.UseVisualStyleBackColor = false;
            this.b_Guardar.Click += new System.EventHandler(this.b_Guardar_Click);
            // 
            // tb_nombre
            // 
            this.tb_nombre.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_nombre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nombre.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_nombre.Location = new System.Drawing.Point(210, 59);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(268, 27);
            this.tb_nombre.TabIndex = 17;
            this.tb_nombre.TextChanged += new System.EventHandler(this.tb_nombre_TextChanged);
            // 
            // tb_idProd
            // 
            this.tb_idProd.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_idProd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_idProd.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_idProd.Location = new System.Drawing.Point(18, 58);
            this.tb_idProd.Name = "tb_idProd";
            this.tb_idProd.Size = new System.Drawing.Size(145, 27);
            this.tb_idProd.TabIndex = 16;
            this.tb_idProd.TextChanged += new System.EventHandler(this.tb_idProd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Id Producto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(205, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 26);
            this.label5.TabIndex = 25;
            this.label5.Text = "Nombre";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(520, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 26);
            this.label3.TabIndex = 26;
            this.label3.Text = "Origen";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cb_origen
            // 
            this.cb_origen.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cb_origen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_origen.ForeColor = System.Drawing.SystemColors.Window;
            this.cb_origen.FormattingEnabled = true;
            this.cb_origen.Items.AddRange(new object[] {
            "seleccione",
            "Chile",
            "Ecuador",
            "Colombia"});
            this.cb_origen.Location = new System.Drawing.Point(525, 58);
            this.cb_origen.Name = "cb_origen";
            this.cb_origen.Size = new System.Drawing.Size(162, 27);
            this.cb_origen.TabIndex = 27;
            this.cb_origen.SelectedIndexChanged += new System.EventHandler(this.cb_origen_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(722, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 26);
            this.label6.TabIndex = 28;
            this.label6.Text = "Porcentaje";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tb_porc
            // 
            this.tb_porc.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_porc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_porc.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_porc.Location = new System.Drawing.Point(727, 59);
            this.tb_porc.Name = "tb_porc";
            this.tb_porc.Size = new System.Drawing.Size(99, 27);
            this.tb_porc.TabIndex = 29;
            this.tb_porc.TextChanged += new System.EventHandler(this.tb_porc_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 26);
            this.label7.TabIndex = 30;
            this.label7.Text = "Aroma";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cb_aroma
            // 
            this.cb_aroma.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cb_aroma.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_aroma.ForeColor = System.Drawing.SystemColors.Window;
            this.cb_aroma.FormattingEnabled = true;
            this.cb_aroma.Items.AddRange(new object[] {
            "Frutal",
            "Menta"});
            this.cb_aroma.Location = new System.Drawing.Point(87, 122);
            this.cb_aroma.Name = "cb_aroma";
            this.cb_aroma.Size = new System.Drawing.Size(185, 27);
            this.cb_aroma.TabIndex = 31;
            this.cb_aroma.SelectedIndexChanged += new System.EventHandler(this.cb_aroma_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(278, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 26);
            this.label8.TabIndex = 32;
            this.label8.Text = "Inclusion";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // cb_inclusion
            // 
            this.cb_inclusion.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cb_inclusion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_inclusion.ForeColor = System.Drawing.SystemColors.Window;
            this.cb_inclusion.FormattingEnabled = true;
            this.cb_inclusion.Items.AddRange(new object[] {
            "inclusion 1",
            "inclusion 2"});
            this.cb_inclusion.Location = new System.Drawing.Point(369, 122);
            this.cb_inclusion.Name = "cb_inclusion";
            this.cb_inclusion.Size = new System.Drawing.Size(203, 27);
            this.cb_inclusion.TabIndex = 33;
            this.cb_inclusion.SelectedIndexChanged += new System.EventHandler(this.cb_inclusion_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(578, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 26);
            this.label9.TabIndex = 34;
            this.label9.Text = "Chocolatero";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // cb_choc
            // 
            this.cb_choc.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cb_choc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_choc.ForeColor = System.Drawing.SystemColors.Window;
            this.cb_choc.FormattingEnabled = true;
            this.cb_choc.Items.AddRange(new object[] {
            "choco 1",
            "choco 2"});
            this.cb_choc.Location = new System.Drawing.Point(687, 122);
            this.cb_choc.Name = "cb_choc";
            this.cb_choc.Size = new System.Drawing.Size(223, 27);
            this.cb_choc.TabIndex = 35;
            this.cb_choc.SelectedIndexChanged += new System.EventHandler(this.cb_choc_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 26);
            this.label4.TabIndex = 36;
            this.label4.Text = "Precio Unitario";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tb_preUn
            // 
            this.tb_preUn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_preUn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_preUn.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_preUn.Location = new System.Drawing.Point(146, 183);
            this.tb_preUn.Name = "tb_preUn";
            this.tb_preUn.Size = new System.Drawing.Size(174, 27);
            this.tb_preUn.TabIndex = 37;
            this.tb_preUn.TextChanged += new System.EventHandler(this.tb_preUn_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(326, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 26);
            this.label10.TabIndex = 38;
            this.label10.Text = "Stock";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // tb_stock
            // 
            this.tb_stock.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_stock.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_stock.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_stock.Location = new System.Drawing.Point(385, 183);
            this.tb_stock.Name = "tb_stock";
            this.tb_stock.Size = new System.Drawing.Size(174, 27);
            this.tb_stock.TabIndex = 39;
            this.tb_stock.TextChanged += new System.EventHandler(this.tb_stock_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_choc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_preUn);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tb_stock);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cb_aroma);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cb_inclusion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_idProd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.b_Restablecer);
            this.groupBox1.Controls.Add(this.tb_porc);
            this.groupBox1.Controls.Add(this.tb_nombre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cb_origen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.b_Guardar);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox1.Location = new System.Drawing.Point(18, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(943, 232);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar Datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Beige;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(30, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 36);
            this.label2.TabIndex = 41;
            this.label2.Text = "Agregar Productos";
            // 
            // AgregarProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(973, 322);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.l_mensajes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarProd";
            this.Text = "AgregarProd";
            this.Load += new System.EventHandler(this.AgregarProd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_mensajes;
        private System.Windows.Forms.Button b_Restablecer;
        private System.Windows.Forms.Button b_Guardar;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.TextBox tb_idProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_origen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_porc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_aroma;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_inclusion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_choc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_preUn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_stock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
    }
}