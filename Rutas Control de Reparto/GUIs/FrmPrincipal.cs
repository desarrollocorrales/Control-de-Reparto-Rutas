﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Rutas_Control_de_Reparto.Modelos;
using Rutas_Control_de_Reparto.DALs;

namespace Rutas_Control_de_Reparto.GUIs
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            new FrmConfiguracion().ShowDialog();
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            Cargar();
        }
        private List<Reporte> ObtenerDatosSQLite(string SQLPath, DateTime fecha)
        {
            List<Reporte> lstReporte = new List<Reporte>();

            SQLite_DAL sqliteDAL = new SQLite_DAL(SQLPath);
            lstReporte = sqliteDAL.ObtenerDatosReporte(fecha);

            return lstReporte;
        }
        private Reporte ObtenerDireccion(string folio)
        {
            FB_DAL fbDAL = new FB_DAL();
            Reporte Direccion = fbDAL.ObtenerDireccion(folio);

            return Direccion;
        }

        private void Cargar()
        {
            try
            {
                var Configuracion = Properties.Settings.Default;

                List<Reporte> lstReporte = new List<Reporte>();
                lstReporte.AddRange(ObtenerDatosSQLite(Configuracion.SQLiteCobranza, dtpFecha.Value));
                lstReporte.AddRange(ObtenerDatosSQLite(Configuracion.SQLiteReparto, dtpFecha.Value));

                Reporte Direccion = new Reporte();
                foreach (Reporte fila in lstReporte)
                {
                    string FolioNormalizado = NormalizarFolio(fila.FolioFactura);
                    Direccion = ObtenerDireccion(FolioNormalizado);

                    fila.FolioFactura = FolioNormalizado;
                    fila.Calle = Direccion.Calle;
                    fila.NumExterior = Direccion.NumExterior;
                    fila.NumInterior = Direccion.NumInterior;
                    fila.Colonia = Direccion.Colonia;
                    fila.CP = Direccion.CP;
                }

                gridReporte.DataSource = lstReporte.OrderBy(o => o.FolioControl).ToList();
                gvReporte.BestFitColumns();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string NormalizarFolio(string pFolio)
        {
            string serie = string.Empty;
            string folio = string.Empty;
            
            foreach (char caracter in pFolio)
            {
                if (Char.IsLetter(caracter) == true)
                {
                    serie += caracter;
                }
                else if (Char.IsDigit(caracter) == true)
                {
                    folio += caracter;
                }
            }

            var tamSerie = serie.Length;
            var tamFolio = 9 - tamSerie;

            string FolioNormalizado = serie + folio.PadLeft(tamFolio, '0'); ; 
            
            return FolioNormalizado;
        }

        private void gvReporte_EndGrouping(object sender, EventArgs e)
        {
            (sender as DevExpress.XtraGrid.Views.Grid.GridView).ExpandAllGroups();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }
        private void Imprimir()
        {
            var ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Ruta" + dtpFecha.Value.ToString("ddMMyyyy") + ".xls";
            gridReporte.ExportToXls(ruta);

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "EXCEL.EXE";
            startInfo.Arguments = ruta;
            Process.Start(startInfo);
        }
    }
}
