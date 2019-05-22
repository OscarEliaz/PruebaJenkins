namespace IxCacaoApp.Vista
{
    partial class fmrCata
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_consultar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_nuevo = new System.Windows.Forms.Button();
            this.bt_actualizar = new System.Windows.Forms.Button();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_idcata = new System.Windows.Forms.TextBox();
            this.l_mensajes = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.dgvCata = new System.Windows.Forms.DataGridView();
            this.dgvId_cata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_borrar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCata)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_consultar);
            this.groupBox2.Controls.Add(this.bt_cancelar);
            this.groupBox2.Controls.Add(this.bt_nuevo);
            this.groupBox2.Controls.Add(this.bt_actualizar);
            this.groupBox2.Controls.Add(this.bt_guardar);
            this.groupBox2.Controls.Add(this.txt_nom);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_fecha);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_idcata);
            this.groupBox2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox2.Location = new System.Drawing.Point(13, 54);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(920, 155);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos De Cata";
            // 
            // bt_consultar
            // 
            this.bt_consultar.BackColor = System.Drawing.Color.Cornsilk;
            this.bt_consultar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_consultar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bt_consultar.Location = new System.Drawing.Point(160, 114);
            this.bt_consultar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_consultar.Name = "bt_consultar";
            this.bt_consultar.Size = new System.Drawing.Size(110, 28);
            this.bt_consultar.TabIndex = 26;
            this.bt_consultar.Text = "Consultar";
            this.bt_consultar.UseVisualStyleBackColor = false;
            this.bt_consultar.Click += new System.EventHandler(this.bt_consultar_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.Cornsilk;
            this.bt_cancelar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bt_cancelar.Location = new System.Drawing.Point(418, 114);
            this.bt_cancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(76, 28);
            this.bt_cancelar.TabIndex = 25;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // bt_nuevo
            // 
            this.bt_nuevo.BackColor = System.Drawing.Color.Cornsilk;
            this.bt_nuevo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_nuevo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bt_nuevo.Location = new System.Drawing.Point(25, 80);
            this.bt_nuevo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_nuevo.Name = "bt_nuevo";
            this.bt_nuevo.Size = new System.Drawing.Size(110, 28);
            this.bt_nuevo.TabIndex = 8;
            this.bt_nuevo.Text = "Nuevo";
            this.bt_nuevo.UseVisualStyleBackColor = false;
            this.bt_nuevo.Click += new System.EventHandler(this.bt_nuevo_Click);
            // 
            // bt_actualizar
            // 
            this.bt_actualizar.BackColor = System.Drawing.Color.Cornsilk;
            this.bt_actualizar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_actualizar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bt_actualizar.Location = new System.Drawing.Point(656, 114);
            this.bt_actualizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_actualizar.Name = "bt_actualizar";
            this.bt_actualizar.Size = new System.Drawing.Size(110, 28);
            this.bt_actualizar.TabIndex = 7;
            this.bt_actualizar.Text = "Actualizar";
            this.bt_actualizar.UseVisualStyleBackColor = false;
            this.bt_actualizar.Click += new System.EventHandler(this.bt_actualizar_Click);
            // 
            // bt_guardar
            // 
            this.bt_guardar.BackColor = System.Drawing.Color.Cornsilk;
            this.bt_guardar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_guardar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bt_guardar.Location = new System.Drawing.Point(779, 80);
            this.bt_guardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(110, 28);
            this.bt_guardar.TabIndex = 6;
            this.bt_guardar.Text = "Guardar";
            this.bt_guardar.UseVisualStyleBackColor = false;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // txt_nom
            // 
            this.txt_nom.BackColor = System.Drawing.Color.Tan;
            this.txt_nom.Location = new System.Drawing.Point(300, 83);
            this.txt_nom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(338, 25);
            this.txt_nom.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(427, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(621, 32);
            this.txt_fecha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(243, 25);
            this.txt_fecha.TabIndex = 3;
            this.txt_fecha.ValueChanged += new System.EventHandler(this.txt_fecha_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(546, 36);
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
            this.txt_idcata.Location = new System.Drawing.Point(160, 34);
            this.txt_idcata.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_idcata.Name = "txt_idcata";
            this.txt_idcata.Size = new System.Drawing.Size(220, 25);
            this.txt_idcata.TabIndex = 0;
            // 
            // l_mensajes
            // 
            this.l_mensajes.AutoSize = true;
            this.l_mensajes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_mensajes.ForeColor = System.Drawing.Color.Maroon;
            this.l_mensajes.Location = new System.Drawing.Point(12, 405);
            this.l_mensajes.Name = "l_mensajes";
            this.l_mensajes.Size = new System.Drawing.Size(124, 16);
            this.l_mensajes.TabIndex = 24;
            this.l_mensajes.Text = "Zona de mensajes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_eliminar);
            this.groupBox1.Controls.Add(this.dgvCata);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox1.Location = new System.Drawing.Point(13, 215);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(920, 177);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado De Catas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.BackColor = System.Drawing.Color.Cornsilk;
            this.bt_eliminar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_eliminar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bt_eliminar.Location = new System.Drawing.Point(25, 392);
            this.bt_eliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(110, 28);
            this.bt_eliminar.TabIndex = 2;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.UseVisualStyleBackColor = false;
            // 
            // dgvCata
            // 
            this.dgvCata.AllowUserToAddRows = false;
            this.dgvCata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvId_cata,
            this.fecha,
            this.nombre});
            this.dgvCata.Location = new System.Drawing.Point(25, 24);
            this.dgvCata.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvCata.Name = "dgvCata";
            this.dgvCata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCata.Size = new System.Drawing.Size(864, 139);
            this.dgvCata.TabIndex = 0;
            this.dgvCata.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCata_CellDoubleClick);
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
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Beige;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 36);
            this.label2.TabIndex = 26;
            this.label2.Text = "Cata";
            // 
            // bt_borrar
            // 
            this.bt_borrar.BackColor = System.Drawing.Color.Cornsilk;
            this.bt_borrar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_borrar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bt_borrar.Location = new System.Drawing.Point(823, 398);
            this.bt_borrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_borrar.Name = "bt_borrar";
            this.bt_borrar.Size = new System.Drawing.Size(110, 28);
            this.bt_borrar.TabIndex = 27;
            this.bt_borrar.Text = "Eliminar";
            this.bt_borrar.UseVisualStyleBackColor = false;
            this.bt_borrar.Click += new System.EventHandler(this.bt_borrar_Click);
            // 
            // fmrCata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(955, 433);
            this.Controls.Add(this.bt_borrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.l_mensajes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmrCata";
            this.Text = "Cata";
            this.Load += new System.EventHandler(this.Cata_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_consultar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_nuevo;
        private System.Windows.Forms.Button bt_actualizar;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txt_fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_idcata;
        private System.Windows.Forms.Label l_mensajes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.DataGridView dgvCata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_borrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvId_cata;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
    }
}