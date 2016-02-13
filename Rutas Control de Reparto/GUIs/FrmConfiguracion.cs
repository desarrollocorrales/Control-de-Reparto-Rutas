using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rutas_Control_de_Reparto.GUIs
{
    public partial class FrmConfiguracion : Form
    {
        public FrmConfiguracion()
        {
            InitializeComponent();
        }

        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
            Inicializar();
        }
        private void Inicializar()
        {
            var config = Properties.Settings.Default;
            
            txbSQLiteCobranza.Text = config.SQLiteCobranza;
            txbSQLiteReparto.Text = config.SQLiteReparto;
            txbServidor.Text = config.FBServer;
            txbBaseDeDatos.Text = config.FBDatabase;
            txbUsuario.Text = config.FBUser;
            txbContraseña.Text = config.FBPass;
            txbPuerto.Value = config.FBPort;
            txbSucursal.Text = config.Sucursal;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult Respuesta = MessageBox.Show("¿Son datos correctos?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Respuesta == DialogResult.Yes)
            {
                var config = Properties.Settings.Default;

                config.SQLiteReparto = txbSQLiteReparto.Text;
                config.SQLiteCobranza = txbSQLiteCobranza.Text;
                config.FBServer = txbServidor.Text;
                config.FBDatabase = txbBaseDeDatos.Text;
                config.FBUser = txbUsuario.Text;
                config.FBPass = txbContraseña.Text;
                config.FBPort = Convert.ToInt32(txbPuerto.Value);
                config.Sucursal = txbSucursal.Text;
                config.Save();

                MessageBox.Show("Los datos se guardaron con éxito", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnBuscarSqlite_Click(object sender, EventArgs e)
        {
            ofdSqlite.ShowDialog();
            txbSQLiteCobranza.Text = ofdSqlite.FileName;
        }

        private void btnBuscarReparto_Click(object sender, EventArgs e)
        {
            ofdSqlite.ShowDialog();
            txbSQLiteReparto.Text = ofdSqlite.FileName;
        }
    }
}
