using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Rutas_Control_de_Reparto.Reportes
{
    public partial class xrReporte : DevExpress.XtraReports.UI.XtraReport
    {
        public string sSucursal;

        public xrReporte()
        {
            InitializeComponent();
        }

        private void xrReporte_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblSucursal.Text = sSucursal;
        }
    }
}
