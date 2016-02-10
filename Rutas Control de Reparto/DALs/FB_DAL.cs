using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using Rutas_Control_de_Reparto.Modelos;
using System.Data;

namespace Rutas_Control_de_Reparto.DALs
{
    public class FB_DAL
    {
        private FbConnection Conexion;
        private FbCommand Comando;
        private FbDataAdapter Adapter;

        public FB_DAL()
        {
            Conexion = new FbConnection();
            Comando = new FbCommand();
            Adapter = new FbDataAdapter();
        }

        private string StringDeConexion()
        {
            var Configuracion = Properties.Settings.Default;

            FbConnectionStringBuilder FBCSB = new FbConnectionStringBuilder();

            FBCSB.DataSource = Configuracion.FBServer;
            FBCSB.Database = Configuracion.FBDatabase;
            FBCSB.UserID = Configuracion.FBUser;
            FBCSB.Password = Configuracion.FBPass;
            FBCSB.Port = Configuracion.FBPort;

            return FBCSB.ConnectionString;
        }

        public Reporte ObtenerDireccion(string folio)
        {
            Reporte datosDireccion = new Reporte();
            
            try
            {
                Conexion.ConnectionString = StringDeConexion();
                Conexion.Open();

                Comando.Connection = Conexion;
                Comando.CommandText =
                    string.Format(@"SELECT 
                                      dc.NOMBRE_CALLE,
                                      dc.NUM_EXTERIOR,
                                      dc.NUM_INTERIOR,
                                      dc.COLONIA,
                                      dc.CODIGO_POSTAL
                                    FROM
                                      DOCTOS_VE ve
                                      INNER JOIN DIRS_CLIENTES dc ON (ve.DIR_CONSIG_ID = dc.DIR_CLI_ID)
                                    WHERE
                                      ve.FOLIO LIKE '{0}'", folio);
                                
                DataTable dtResultado = new DataTable();
                Adapter.SelectCommand = Comando;
                Adapter.Fill(dtResultado);

                foreach (DataRow fila in dtResultado.Rows)
                {
                    datosDireccion.Calle = fila["NOMBRE_CALLE"].ToString();
                    datosDireccion.NumExterior = fila["NUM_EXTERIOR"].ToString();
                    datosDireccion.NumInterior = fila["NUM_INTERIOR"].ToString();
                    datosDireccion.Colonia = fila["COLONIA"].ToString();
                    datosDireccion.CP = fila["CODIGO_POSTAL"].ToString();
                }

                Conexion.Close();
            }
            catch (Exception ex)
            {
                if (Conexion.State != ConnectionState.Closed)
                    Conexion.Close();
                
                throw ex;
            }

            return datosDireccion;
        }
    }
}
