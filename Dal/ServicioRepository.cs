using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Oracle.ManagedDataAccess.Client;


namespace Dal
{
    public class ServicioRepository
    {
        private readonly OracleConnection conexion;

        public ServicioRepository(ConnectionManager connection)
        {
            conexion = connection._conexion;
        }

        public void Guardar(Servicio servicio)
        {
            using (var command = conexion.CreateCommand())
            {
                command.CommandText = @"BEGIN 
                                        SERVS_DOMICILIARIOS.REGISTRAR_SERVICIO(:ID_CLIENTE ,:ID_DOMICILIARIO,
                                        :COSTO,:TELEFONO_EMERGENCIA,:DESTINO_INICIAL,:DESTINO_FINAL,:DESCRIPCION);
                                        END;";
                if(servicio.IdCliente.Equals("No aplica")) { servicio.IdCliente = string.Empty; }
                command.Parameters.Add("ID_CLIENTE", OracleDbType.Varchar2).Value = servicio.IdCliente;
                command.Parameters.Add("ID_DOMICILIARIO", OracleDbType.Varchar2).Value = servicio.IdDomiciliario;
                command.Parameters.Add("COSTO", OracleDbType.Int32).Value = (Int32)servicio.Costo;
                command.Parameters.Add("TELEFONO_EMERGENCIA", OracleDbType.Varchar2).Value = servicio.TelefonoEmergencia;
                command.Parameters.Add("DESTINO_INICIAL", OracleDbType.Varchar2).Value = servicio.DestinoInicial;
                command.Parameters.Add("DESTINO_FINAL", OracleDbType.Varchar2).Value = servicio.DestinoFinal;
                command.Parameters.Add("DESCRIPCION", OracleDbType.Varchar2).Value = servicio.Descripcion;

                command.ExecuteNonQuery();
            }
        }



        public List<Servicio> ConsultaTotal()
        {
            List<Servicio> resultado = new List<Servicio>();
            OracleDataReader dataReader;
            using (var command = conexion.CreateCommand())
            {
                command.CommandText = @"SELECT ID_SERVICIO,ID_CLIENTE,ID_DOMICILIARIO,
                                        FECHA,COSTO,TELEFONO_EMERGENCIA,
                                        DESTINO_INICIAL,DESTINO_FINAL,DESCRIPCION 
                                        FROM SERVICIOS";
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Servicio servicio = MapearServicio(dataReader);
                    resultado.Add(servicio);
                }
            }
            return resultado;
        }



        private Servicio MapearServicio(OracleDataReader dataReader)
        {
            Servicio servicio = new Servicio();
            servicio.IDServicio = int.Parse(dataReader["ID_SERVICIO"].ToString());
            servicio.IdCliente = dataReader["ID_CLIENTE"].ToString();
            servicio.IdDomiciliario = dataReader["ID_DOMICILIARIO"].ToString();
            servicio.Fecha = Convert.ToDateTime(dataReader["FECHA"].ToString());
            servicio.Costo = int.Parse(dataReader["COSTO"].ToString());
            servicio.DestinoInicial = dataReader["DESTINO_INICIAL"].ToString();
            servicio.DestinoFinal = dataReader["DESTINO_FINAL"].ToString();
            servicio.Descripcion = dataReader["DESCRIPCION"].ToString();
            return servicio;
        }


    }
}
