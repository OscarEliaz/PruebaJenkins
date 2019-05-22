namespace IxCacaoApp.Vista
{
    partial class MenuUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUsuario));
            this.pl_barra = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_mini = new System.Windows.Forms.PictureBox();
            this.bt_cerrar = new System.Windows.Forms.PictureBox();
            this.pl_menu = new System.Windows.Forms.Panel();
            this.bt_CrSesion = new System.Windows.Forms.Button();
            this.bt_cata = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_venta = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pl_vistas = new System.Windows.Forms.Panel();
            this.pl_barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_mini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_cerrar)).BeginInit();
            this.pl_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_barra
            // 
            this.pl_barra.BackColor = System.Drawing.Color.Tan;
            this.pl_barra.Controls.Add(this.label1);
            this.pl_barra.Controls.Add(this.bt_mini);
            this.pl_barra.Controls.Add(this.bt_cerrar);
            this.pl_barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_barra.Location = new System.Drawing.Point(0, 0);
            this.pl_barra.Name = "pl_barra";
            this.pl_barra.Size = new System.Drawing.Size(1174, 35);
            this.pl_barra.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 53;
            this.label1.Text = "IX Cacao Chile";
            // 
            // bt_mini
            // 
            this.bt_mini.BackColor = System.Drawing.Color.SaddleBrown;
            this.bt_mini.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bt_mini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_mini.Image = global::IxCacaoApp.Properties.Resources.Icono_Minimizar1;
            this.bt_mini.Location = new System.Drawing.Point(1085, 4);
            this.bt_mini.Name = "bt_mini";
            this.bt_mini.Size = new System.Drawing.Size(28, 28);
            this.bt_mini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bt_mini.TabIndex = 52;
            this.bt_mini.TabStop = false;
            this.bt_mini.Click += new System.EventHandler(this.bt_mini_Click);
            // 
            // bt_cerrar
            // 
            this.bt_cerrar.BackColor = System.Drawing.Color.SaddleBrown;
            this.bt_cerrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bt_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cerrar.Image = global::IxCacaoApp.Properties.Resources.Icono_cerrar_FN;
            this.bt_cerrar.Location = new System.Drawing.Point(1134, 4);
            this.bt_cerrar.Name = "bt_cerrar";
            this.bt_cerrar.Size = new System.Drawing.Size(28, 28);
            this.bt_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bt_cerrar.TabIndex = 51;
            this.bt_cerrar.TabStop = false;
            this.bt_cerrar.Click += new System.EventHandler(this.bt_cerrar_Click);
            // 
            // pl_menu
            // 
            this.pl_menu.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pl_menu.Controls.Add(this.bt_CrSesion);
            this.pl_menu.Controls.Add(this.bt_cata);
            this.pl_menu.Controls.Add(this.panel3);
            this.pl_menu.Controls.Add(this.bt_venta);
            this.pl_menu.Controls.Add(this.panel2);
            this.pl_menu.Controls.Add(this.panel1);
            this.pl_menu.Controls.Add(this.bt_buscar);
            this.pl_menu.Controls.Add(this.pictureBox2);
            this.pl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pl_menu.Location = new System.Drawing.Point(0, 35);
            this.pl_menu.Name = "pl_menu";
            this.pl_menu.Size = new System.Drawing.Size(200, 447);
            this.pl_menu.TabIndex = 1;
            // 
            // bt_CrSesion
            // 
            this.bt_CrSesion.BackColor = System.Drawing.Color.Cornsilk;
            this.bt_CrSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_CrSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bt_CrSesion.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CrSesion.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bt_CrSesion.Image = ((System.Drawing.Image)(resources.GetObject("bt_CrSesion.Image")));
            this.bt_CrSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_CrSesion.Location = new System.Drawing.Point(0, 404);
            this.bt_CrSesion.Name = "bt_CrSesion";
            this.bt_CrSesion.Size = new System.Drawing.Size(200, 43);
            this.bt_CrSesion.TabIndex = 11;
            this.bt_CrSesion.Text = "Cerrar Sesión";
            this.bt_CrSesion.UseVisualStyleBackColor = false;
            this.bt_CrSesion.Click += new System.EventHandler(this.bt_CrSesion_Click);
            // 
            // bt_cata
            // 
            this.bt_cata.FlatAppearance.BorderSize = 0;
            this.bt_cata.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this.bt_cata.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque;
            this.bt_cata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cata.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cata.Image = global::IxCacaoApp.Properties.Resources.empleados;
            this.bt_cata.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_cata.Location = new System.Drawing.Point(16, 262);
            this.bt_cata.Name = "bt_cata";
            this.bt_cata.Size = new System.Drawing.Size(184, 34);
            this.bt_cata.TabIndex = 6;
            this.bt_cata.Text = "Catas";
            this.bt_cata.UseVisualStyleBackColor = true;
            this.bt_cata.Click += new System.EventHandler(this.bt_cata_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Cornsilk;
            this.panel3.Location = new System.Drawing.Point(0, 262);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(16, 34);
            this.panel3.TabIndex = 5;
            // 
            // bt_venta
            // 
            this.bt_venta.FlatAppearance.BorderSize = 0;
            this.bt_venta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this.bt_venta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque;
            this.bt_venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_venta.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_venta.Image = global::IxCacaoApp.Properties.Resources.venta;
            this.bt_venta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_venta.Location = new System.Drawing.Point(16, 203);
            this.bt_venta.Name = "bt_venta";
            this.bt_venta.Size = new System.Drawing.Size(184, 34);
            this.bt_venta.TabIndex = 4;
            this.bt_venta.Text = "Vender";
            this.bt_venta.UseVisualStyleBackColor = true;
            this.bt_venta.Click += new System.EventHandler(this.bt_venta_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cornsilk;
            this.panel2.Location = new System.Drawing.Point(0, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(16, 34);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.Location = new System.Drawing.Point(0, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 34);
            this.panel1.TabIndex = 2;
            // 
            // bt_buscar
            // 
            this.bt_buscar.FlatAppearance.BorderSize = 0;
            this.bt_buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this.bt_buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque;
            this.bt_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_buscar.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_buscar.Image = global::IxCacaoApp.Properties.Resources.producto;
            this.bt_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_buscar.Location = new System.Drawing.Point(16, 143);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(184, 34);
            this.bt_buscar.TabIndex = 1;
            this.bt_buscar.Text = "Buscar Productos";
            this.bt_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_buscar.UseVisualStyleBackColor = true;
            this.bt_buscar.Click += new System.EventHandler(this.bt_buscar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::IxCacaoApp.Properties.Resources.ix_cacao;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pl_vistas
            // 
            this.pl_vistas.BackColor = System.Drawing.Color.Cornsilk;
            this.pl_vistas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_vistas.Location = new System.Drawing.Point(200, 35);
            this.pl_vistas.Name = "pl_vistas";
            this.pl_vistas.Size = new System.Drawing.Size(974, 447);
            this.pl_vistas.TabIndex = 2;
            // 
            // MenuUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 482);
            this.Controls.Add(this.pl_vistas);
            this.Controls.Add(this.pl_menu);
            this.Controls.Add(this.pl_barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuUsuario";
            this.pl_barra.ResumeLayout(false);
            this.pl_barra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_mini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_cerrar)).EndInit();
            this.pl_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_barra;
        private System.Windows.Forms.Panel pl_menu;
        private System.Windows.Forms.Panel pl_vistas;
        private System.Windows.Forms.PictureBox bt_mini;
        private System.Windows.Forms.PictureBox bt_cerrar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.Button bt_cata;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_venta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_CrSesion;
        private System.Windows.Forms.Label label1;
    }
}