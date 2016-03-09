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
                                            mi.folio_control, 
                                            mi.id_chofer,
                                            p.nombre as chofer, 
                                            mi.folio_factura, 
                                            mi.importe_factura, 
                                            mi.clave_cliente, 
                                            mi.nombre_cliente,
                                            fd.calle,
                                            fd.numero, 
                                            fd.interior, 
                                            fd.colonia, 
                                            fd.codigo_postal
                                        FROM 
                                            manejo_impresiones mi 
                                            LEFT JOIN personal p ON p.id_personal = mi.id_chofer
                                            LEFT JOIN folio_direccion fd ON fd.folio_factura = mi.folio_factura
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
                    filaReporte.ID_Chofer = Convert.ToInt32(fila["id_chofer"]);
                    filaReporte.Chofer = fila["chofer"].ToString();
                    filaReporte.ClaveCliente = fila["clave_cliente"].ToString();
                    filaReporte.NombreCliente = fila["nombre_cliente"].ToString();
                    filaReporte.FolioFactura = fila["folio_factura"].ToString();
                    filaReporte.Importe = Convert.ToDecimal(fila["importe_factura"]);
                    filaReporte.Calle = Convert.ToString(fila["calle"]);
                    filaReporte.NumExterior = Convert.ToString(fila["numero"]);
                    filaReporte.NumInterior = Convert.ToString(fila["interior"]);
                    filaReporte.Colonia = Convert.ToString(fila["colonia"]);
                    filaReporte.CP = Convert.ToString(fila["codigo_postal"]);
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
        public List<Personal> ObtenerPersonal()
        {
            List<Personal> lstPersonal = new List<Personal>();
            try
            {
                Conexion.ConnectionString = @"Data Source=" + rutaSQL + ";Version=3;";
                Conexion.Open();

                Comando.Connection = Conexion;
                Comando.CommandText = "SELECT id_personal, nombre FROM personal";
                Adapter.SelectCommand = Comando;
                DataTable dtRespuesta = new DataTable();
                Adapter.Fill(dtRespuesta);

                Personal persona;
                foreach (DataRow fila in dtRespuesta.Rows)
                {
                    persona = new Personal();
                    persona.ID = Convert.ToInt32(fila["id_personal"]);
                    persona.Nombre = Convert.ToString(fila["nombre"]);
                    lstPersonal.Add(persona);
                }

                Conexion.Close();
            }
            catch (Exception ex)
            {
                if (Conexion.State != System.Data.ConnectionState.Closed)
                    Conexion.Close();
                throw ex;
            }

            return lstPersonal;
        }        

        private string ObtenerStringDeConexion()
        {
            string stringDeConexion = string.Empty;
            stringDeConexion = @"Data Source=c:\mydb.db;Version=3;";
            return stringDeConexion;
        }
    }
}
