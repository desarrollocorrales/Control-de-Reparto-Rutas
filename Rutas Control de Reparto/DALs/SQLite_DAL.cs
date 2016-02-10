using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using Rutas_Control_de_Reparto.Modelos;

namespace Rutas_Control_de_Reparto.DALs
{
    public class SQLite_DAL
    {
        private string rutaSQL;
        private SQLiteConnection Conexion;
        private SQLiteCommand Comando;
        private SQLiteDataAdapter Adapter;

        public SQLite_DAL(string RutaSQLite)
        {
            rutaSQL = RutaSQLite;
            Conexion = new SQLiteConnection();
            Comando = new SQLiteCommand();
            Adapter = new SQLiteDataAdapter();
        }

        public List<Reporte> ObtenerDatosReporte(DateTime fecha)
        {
            List<Reporte> lstReporte = new List<Reporte>();
            try
            {
                Conexion.ConnectionString = @"Data Source=" + rutaSQL + ";Version=3;";
                Conexion.Open();

                Comando.Connection = Conexion;
                Comando.CommandText =
                        string.Format(@"SELECT 
                                            folio_control,
                                            folio_factura,
                                            importe_factura,
                                            clave_cliente,
                                            nombre_cliente
                                        FROM
                                            manejo_impresiones
                                        WHERE
                                            fecha_impresion = '{0}'", fecha.ToString("yyyy-MM-dd"));
                Adapter.SelectCommand = Comando;
                DataTable dtRespuesta = new DataTable();
                Adapter.Fill(dtRespuesta);

                Reporte filaReporte;
                foreach (DataRow fila in dtRespuesta.Rows)
                {
                    filaReporte = new Reporte();
                    filaReporte.FolioControl = Convert.ToInt32(fila["folio_control"]);
                    filaReporte.ClaveCliente = fila["clave_cliente"].ToString();
                    filaReporte.NombreCliente = fila["nombre_cliente"].ToString();
                    filaReporte.FolioFactura = fila["folio_factura"].ToString();
                    filaReporte.Importe = Convert.ToDecimal(fila["importe_factura"]);
                    lstReporte.Add(filaReporte);
                }

                Conexion.Close();
            }
            catch (Exception ex)
            {
                if (Conexion.State != System.Data.ConnectionState.Closed)
                    Conexion.Close();
                throw ex;
            }

            return lstReporte;
        }

        private string ObtenerStringDeConexion()
        {
            string stringDeConexion = string.Empty;
            stringDeConexion = @"Data Source=c:\mydb.db;Version=3;";
            return stringDeConexion;
        }
    }
}
