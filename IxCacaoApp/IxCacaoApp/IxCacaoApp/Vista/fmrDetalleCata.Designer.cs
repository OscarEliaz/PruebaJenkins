namespace IxCacaoApp.Vista
{
    partial class fmrDetalleCata
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_idcata = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_idprod = new System.Windows.Forms.TextBox();
            this.bt_consultar = new System.Windows.Forms.Button();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.l_mensajes = new System.Windows.Forms.Label();
            this.bt_imprimir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.dgvDetalleCata = new System.Windows.Forms.DataGridView();
            this.dgvId_cata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_detalleCata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aroma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inclusion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chocolatero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCata)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Beige;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 36);
            this.label2.TabIndex = 27;
            this.label2.Text = "Detalle Cata";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_nom);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_fecha);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_idcata);
            this.groupBox2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox2.Location = new System.Drawing.Point(13, 48);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(774, 119);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos De Cata";
            // 
            // txt_nom
            // 
            this.txt_nom.BackColor = System.Drawing.Color.Tan;
            this.txt_nom.Enabled = false;
            this.txt_nom.Location = new System.Drawing.Point(214, 83);
            this.txt_nom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(338, 25);
            this.txt_nom.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(336, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Enabled = false;
            this.txt_fecha.Location = new System.Drawing.Point(490, 32);
            this.txt_fecha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(243, 25);
            this.txt_fecha.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(416, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Venta";
            // 
            // txt_idcata
            // 
            this.txt_idcata.BackColor = System.Drawing.Color.Tan;
            this.txt_idcata.Enabled = false;
            this.txt_idcata.Location = new System.Drawing.Point(160, 34);
            this.txt_idcata.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_idcata.Name = "txt_idcata";
            this.txt_idcata.Size = new System.Drawing.Size(220, 25);
            this.txt_idcata.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_cancelar);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_nombre);
            this.groupBox3.Controls.Add(this.txt_idprod);
            this.groupBox3.Controls.Add(this.bt_consultar);
            this.groupBox3.Controls.Add(this.bt_guardar);
            this.groupBox3.Location = new System.Drawing.Point(13, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(774, 65);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Producto";
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.Cornsilk;
            this.bt_cancelar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bt_cancelar.Location = new System.Drawing.Point(619, 24);
            this.bt_cancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(114, 28);
            this.bt_cancelar.TabIndex = 33;
            this.bt_cancelar.Text = "Restablecer";
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 14);
            this.label5.TabIndex = 29;
            this.label5.Text = "ID Producto";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.Tan;
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Location = new System.Drawing.Point(157, 24);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(193, 20);
            this.txt_nombre.TabIndex = 28;
            // 
            // txt_idprod
            // 
            this.txt_idprod.BackColor = System.Drawing.Color.Tan;
            this.txt_idprod.Location = new System.Drawing.Point(97, 24);
            this.txt_idprod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_idprod.Name = "txt_idprod";
            this.txt_idprod.Size = new System.Drawing.Size(52, 20);
            this.txt_idprod.TabIndex = 27;
            // 
            // bt_consultar
            // 
            this.bt_consultar.BackColor = System.Drawing.Color.Cornsilk;
            this.bt_consultar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_consultar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bt_consultar.Location = new System.Drawing.Point(358, 24);
            this.bt_consultar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_consultar.Name = "bt_consultar";
            this.bt_consultar.Size = new System.Drawing.Size(33, 28);
            this.bt_consultar.TabIndex = 26;
            this.bt_consultar.Text = "...";
            this.bt_consultar.UseVisualStyleBackColor = false;
            this.bt_consultar.Click += new System.EventHandler(this.bt_consultar_Click);
            // 
            // bt_guardar
            // 
            this.bt_guardar.BackColor = System.Drawing.Color.Cornsilk;
            this.bt_guardar.Enabled = false;
            this.bt_guardar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_guardar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bt_guardar.Location = new System.Drawing.Point(434, 24);
            this.bt_guardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(149, 28);
            this.bt_guardar.TabIndex = 30;
            this.bt_guardar.Text = "Agregar Producto";
            this.bt_guardar.UseVisualStyleBackColor = false;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // l_mensajes
            // 
            this.l_mensajes.AutoSize = true;
            this.l_mensajes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_mensajes.ForeColor = System.Drawing.Color.Maroon;
            this.l_mensajes.Location = new System.Drawing.Point(10, 241);
            this.l_mensajes.Name = "l_mensajes";
            this.l_mensajes.Size = new System.Drawing.Size(124, 16);
            this.l_mensajes.TabIndex = 32;
            this.l_mensajes.Text = "Zona de mensajes";
            // 
            // bt_imprimir
            // 
            this.bt_imprimir.BackColor = System.Drawing.Color.Cornsilk;
            this.bt_imprimir.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_imprimir.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bt_imprimir.Location = new System.Drawing.Point(677, 241);
            this.bt_imprimir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_imprimir.Name = "bt_imprimir";
            this.bt_imprimir.Size = new System.Drawing.Size(110, 28);
            this.bt_imprimir.TabIndex = 31;
            this.bt_imprimir.Text = "Imprimir";
            this.bt_imprimir.UseVisualStyleBackColor = false;
            this.bt_imprimir.Click += new System.EventHandler(this.bt_imprimir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_eliminar);
            this.groupBox1.Controls.Add(this.dgvDetalleCata);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox1.Location = new System.Drawing.Point(12, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 199);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista Chocolates";
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.BackColor = System.Drawing.Color.Cornsilk;
            this.bt_eliminar.Enabled = false;
            this.bt_eliminar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_eliminar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bt_eliminar.Location = new System.Drawing.Point(636, 161);
            this.bt_eliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(133, 28);
            this.bt_eliminar.TabIndex = 3;
            this.bt_eliminar.Text = "Quitar Producto";
            this.bt_eliminar.UseVisualStyleBackColor = false;
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // dgvDetalleCata
            // 
            this.dgvDetalleCata.AllowUserToAddRows = false;
            this.dgvDetalleCata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleCata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvId_cata,
            this.fecha,
            this.nombre,
            this.id_detalleCata,
            this.id_prod,
            this.nom_prod,
            this.origen,
            this.porcentaje,
            this.aroma,
            this.inclusion,
            this.chocolatero});
            this.dgvDetalleCata.Location = new System.Drawing.Point(11, 24);
            this.dgvDetalleCata.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvDetalleCata.Name = "dgvDetalleCata";
            this.dgvDetalleCata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleCata.Size = new System.Drawing.Size(758, 131);
            this.dgvDetalleCata.TabIndex = 1;
            // 
            // dgvId_cata
            // 
            this.dgvId_cata.HeaderText = "ID Cata";
            this.dgvId_cata.Name = "dgvId_cata";
            this.dgvId_cata.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre Cata";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // id_detalleCata
            // 
            this.id_detalleCata.HeaderText = "Id dtBta";
            this.id_detalleCata.Name = "id_detalleCata";
            this.id_detalleCata.ReadOnly = true;
            // 
            // id_prod
            // 
            this.id_prod.HeaderText = "ID Producto";
            this.id_prod.Name = "id_prod";
            this.id_prod.ReadOnly = true;
            // 
            // nom_prod
            // 
            this.nom_prod.HeaderText = "Nombre Producto";
            this.nom_prod.Name = "nom_prod";
            this.nom_prod.ReadOnly = true;
            // 
            // origen
            // 
            this.origen.HeaderText = "Origen";
            this.origen.Name = "origen";
            this.origen.ReadOnly = true;
            // 
            // porcentaje
            // 
            this.porcentaje.HeaderText = "Porcentaje";
            this.porcentaje.Name = "porcentaje";
            this.porcentaje.ReadOnly = true;
            // 
            // aroma
            // 
            this.aroma.HeaderText = "Aroma";
            this.aroma.Name = "aroma";
            // 
            // inclusion
            // 
            this.inclusion.HeaderText = "Inclusion";
            this.inclusion.Name = "inclusion";
            // 
            // chocolatero
            // 
            this.chocolatero.HeaderText = "Chocolatero";
            this.chocolatero.Name = "chocolatero";
            // 
            // fmrDetalleCata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.l_mensajes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_imprimir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "fmrDetalleCata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetalleCata";
            this.Load += new System.EventHandler(this.fmrDetalleCata_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txt_fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_idcata;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_idprod;
        private System.Windows.Forms.Button bt_consultar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.Label l_mensajes;
        private System.Windows.Forms.Button bt_imprimir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDetalleCata;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvId_cata;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_detalleCata;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn aroma;
        private System.Windows.Forms.DataGridViewTextBoxColumn inclusion;
        private System.Windows.Forms.DataGridViewTextBoxColumn chocolatero;
    }
}