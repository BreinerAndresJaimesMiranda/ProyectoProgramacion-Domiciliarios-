using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Entity;


namespace Dal
{
    public class DomiciliarioRepository
    {
        private readonly OracleConnection _conneccion;

        public DomiciliarioRepository(ConnectionManager connection)
        {
            _conneccion = connection._conexion;
        }

        public void Guardar(Domiciliario domiciliario)
        {
            using (var command = _conneccion.CreateCommand())
            {
                command.CommandText = @"BEGIN
                                        SERVS_DOMICILIARIOS.REGISTRAR_DOMICILIARIO(:ID_TRABAJADOR ,:NOMBRE,:APELLIDO,:BASE,:ESTADO);
                                        END;";
                command.Parameters.Add("ID_TRABAJADOR", OracleDbType.Varchar2).Value = domiciliario.ID_Trabajador;
                command.Parameters.Add("NOMBRE", OracleDbType.Varchar2).Value = domiciliario.Nombre;
                command.Parameters.Add("APELLIDO", OracleDbType.Varchar2).Value = domiciliario.Apellido;
                command.Parameters.Add("BASE", OracleDbType.Varchar2).Value = domiciliario.Base;
                command.Parameters.Add("ESTADO", OracleDbType.Varchar2).Value = domiciliario.Estado;
                command.ExecuteNonQuery();
            }
        }

        public List<Domiciliario> ConsultaTotal()
        {
            List<Domiciliario> resultado = new List<Domiciliario>();
            OracleDataReader dataReader;
            using (var command = _conneccion.CreateCommand())
            {
                command.CommandText = "SELECT ID_TRABAJADOR,NOMBRE,APELLIDO,BASE,FECHA_CONTRATO,ESTADO FROM DOMICILIARIOS";
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Domiciliario domiciliario = MapearDomiciliario(dataReader);
                    resultado.Add(domiciliario);
                }
            }
            return resultado;
        }


        public int ConsultaIndividual(String ID_trabajador)
        {
            using (var command = _conneccion.CreateCommand())
            {
                command.CommandText = "SELECT COUNT(*) FROM DOMICILIARIOS WHERE ID_TRABAJADOR = :ID_TRABAJADORT";
                command.Parameters.Add("ID_TRABAJADORT", OracleDbType.Varchar2).Value = (string)ID_trabajador;
                var dataReader = command.ExecuteReader();
                dataReader.Read();
                return dataReader.GetInt32(0);
            }
        }


        public void Actualizar(Domiciliario domiciliario)
        {

            using (var command = _conneccion.CreateCommand())
            {
                command.CommandText = @"BEGIN
                                        SERVS_DOMICILIARIOS.ACTUALIZAR_DOMICILIARIO(:NOMBRET, :APELLIDOT ,:BASET ,:ESTADOT ,:ID_TRABAJADORT );
                                        END;";
                command.Parameters.Add("NOMBRET", OracleDbType.Varchar2).Value = domiciliario.Nombre;
                command.Parameters.Add("APELLIDOT", OracleDbType.Varchar2).Value = domiciliario.Apellido;
                command.Parameters.Add("BASET", OracleDbType.Int32).Value = (Int32)domiciliario.Base;
                command.Parameters.Add("ESTADOT", OracleDbType.Varchar2).Value = domiciliario.Estado;
                command.Parameters.Add("ID_TRABAJADORT", OracleDbType.Varchar2).Value = domiciliario.ID_Trabajador;
                command.ExecuteNonQuery();
            }
        }

        private Domiciliario MapearDomiciliario(OracleDataReader dataReader)
        {
            Domiciliario domiciliario = new Domiciliario();
            domiciliario.ID_Trabajador = (string)dataReader["ID_TRABAJADOR"];
            domiciliario.Nombre = (string)dataReader["NOMBRE"];
            domiciliario.Apellido = (string)dataReader["APELLIDO"];
            domiciliario.Base =int.Parse( dataReader["BASE"].ToString());
            domiciliario.Estado = (string)dataReader["ESTADO"];
            domiciliario.FechaContrato= dataReader["FECHA_CONTRATO"].ToString();
            return domiciliario;
        }

    }
}
