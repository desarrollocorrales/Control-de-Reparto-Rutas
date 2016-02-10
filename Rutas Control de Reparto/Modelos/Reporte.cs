using System;

namespace Rutas_Control_de_Reparto.Modelos
{
    public class Reporte
    {
        public int FolioControl { set; get; }
        public string FolioFactura { set; get; }
        public decimal Importe { set; get; }
        public string ClaveCliente { set; get; }
        public string NombreCliente { set; get; }
        public string Calle { set; get; }
        public string NumExterior { set; get; }
        public string NumInterior { set; get; }
        public string Colonia { set; get; }
        public string CP { set; get; }
        public DateTime FechaImpresion { set; get; }
    }
}
