namespace Rutas_Control_de_Reparto.GUIs
{
    partial class FrmConfiguracion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSQLiteCobranza = new System.Windows.Forms.TextBox();
            this.btnBuscarCobranza = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbPuerto = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txbContraseña = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbBaseDeDatos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbServidor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarReparto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbSQLiteReparto = new System.Windows.Forms.TextBox();
            this.ofdSqlite = new System.Windows.Forms.OpenFileDialog();
            this.txbSucursal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbPuerto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Configuración";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "SQLite Cobranza:";
            // 
            // txbSQLiteCobranza
            // 
            this.txbSQLiteCobranza.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSQLiteCobranza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSQLiteCobranza.Location = new System.Drawing.Point(142, 36);
            this.txbSQLiteCobranza.Name = "txbSQLiteCobranza";
            this.txbSQLiteCobranza.Size = new System.Drawing.Size(554, 26);
            this.txbSQLiteCobranza.TabIndex = 3;
            // 
            // btnBuscarCobranza
            // 
            this.btnBuscarCobranza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarCobranza.Location = new System.Drawing.Point(702, 36);
            this.btnBuscarCobranza.Name = "btnBuscarCobranza";
            this.btnBuscarCobranza.Size = new System.Drawing.Size(38, 26);
            this.btnBuscarCobranza.TabIndex = 4;
            this.btnBuscarCobranza.Text = "...";
            this.btnBuscarCobranza.UseVisualStyleBackColor = true;
            this.btnBuscarCobranza.Click += new System.EventHandler(this.btnBuscarSqlite_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuardar.Location = new System.Drawing.Point(355, 477);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 28);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txbSucursal);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txbPuerto);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txbContraseña);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txbUsuario);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txbBaseDeDatos);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbServidor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 317);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Microsip";
            // 
            // txbPuerto
            // 
            this.txbPuerto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPuerto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPuerto.Location = new System.Drawing.Point(232, 219);
            this.txbPuerto.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txbPuerto.Name = "txbPuerto";
            this.txbPuerto.Size = new System.Drawing.Size(120, 26);
            this.txbPuerto.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(170, 221);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 18);
            this.label8.TabIndex = 25;
            this.label8.Text = "Puerto:";
            // 
            // txbContraseña
            // 
            this.txbContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbContraseña.Location = new System.Drawing.Point(232, 187);
            this.txbContraseña.Name = "txbContraseña";
            this.txbContraseña.PasswordChar = '*';
            this.txbContraseña.Size = new System.Drawing.Size(201, 26);
            this.txbContraseña.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(138, 190);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Contraseña:";
            // 
            // txbUsuario
            // 
            this.txbUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbUsuario.Location = new System.Drawing.Point(232, 155);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(201, 26);
            this.txbUsuario.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Usuario:";
            // 
            // txbBaseDeDatos
            // 
            this.txbBaseDeDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbBaseDeDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbBaseDeDatos.Location = new System.Drawing.Point(232, 123);
            this.txbBaseDeDatos.Name = "txbBaseDeDatos";
            this.txbBaseDeDatos.Size = new System.Drawing.Size(431, 26);
            this.txbBaseDeDatos.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Base de datos:";
            // 
            // txbServidor
            // 
            this.txbServidor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbServidor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbServidor.Location = new System.Drawing.Point(232, 91);
            this.txbServidor.Name = "txbServidor";
            this.txbServidor.Size = new System.Drawing.Size(431, 26);
            this.txbServidor.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Servidor:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnBuscarReparto);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txbSQLiteReparto);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txbSQLiteCobranza);
            this.groupBox2.Controls.Add(this.btnBuscarCobranza);
            this.groupBox2.Location = new System.Drawing.Point(12, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 100);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SQLite";
            // 
            // btnBuscarReparto
            // 
            this.btnBuscarReparto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarReparto.Location = new System.Drawing.Point(702, 68);
            this.btnBuscarReparto.Name = "btnBuscarReparto";
            this.btnBuscarReparto.Size = new System.Drawing.Size(38, 26);
            this.btnBuscarReparto.TabIndex = 7;
            this.btnBuscarReparto.Text = "...";
            this.btnBuscarReparto.UseVisualStyleBackColor = true;
            this.btnBuscarReparto.Click += new System.EventHandler(this.btnBuscarReparto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "SQLite Reparto:";
            // 
            // txbSQLiteReparto
            // 
            this.txbSQLiteReparto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSQLiteReparto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSQLiteReparto.Location = new System.Drawing.Point(142, 68);
            this.txbSQLiteReparto.Name = "txbSQLiteReparto";
            this.txbSQLiteReparto.Size = new System.Drawing.Size(554, 26);
            this.txbSQLiteReparto.TabIndex = 6;
            // 
            // ofdSqlite
            // 
            this.ofdSqlite.FileName = "*.*";
            // 
            // txbSucursal
            // 
            this.txbSucursal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSucursal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSucursal.Location = new System.Drawing.Point(232, 59);
            this.txbSucursal.Name = "txbSucursal";
            this.txbSucursal.Size = new System.Drawing.Size(431, 26);
            this.txbSucursal.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(160, 62);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 18);
            this.label9.TabIndex = 27;
            this.label9.Text = "Sucursal:";
            // 
            // FrmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 512);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmConfiguracion";
            this.Text = "Rutas - Configuración";
            this.Load += new System.EventHandler(this.FrmConfiguracion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbPuerto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbSQLiteCobranza;
        private System.Windows.Forms.Button btnBuscarCobranza;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown txbPuerto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbContraseña;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbBaseDeDatos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbServidor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.OpenFileDialog ofdSqlite;
        private System.Windows.Forms.Button btnBuscarReparto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbSQLiteReparto;
        private System.Windows.Forms.TextBox txbSucursal;
        private System.Windows.Forms.Label label9;
    }
}