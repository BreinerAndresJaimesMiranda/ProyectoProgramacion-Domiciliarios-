using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Entity;

namespace Dal
{
    public class ClienteRegistradoRepository
    {
        private readonly OracleConnection _conneccion;

        public ClienteRegistradoRepository(ConnectionManager connection)
        {
            _conneccion = connection._conexion;
        }

        public void Guardar(ClienteRegistrado cliente)
        {
            using (var command = _conneccion.CreateCommand())
            {
                command.CommandText = @"BEGIN
                                        SERVS_DOMICILIARIOS.REGISTRAR_CLIENTE(:CEDULA,:NOMBRE,:APELLIDO,:DIRECCION,:TELEFONO);
                                        END;";
                command.Parameters.Add("CEDULA", OracleDbType.Varchar2).Value = cliente.Cedula;
                command.Parameters.Add("NOMBRE", OracleDbType.Varchar2).Value = cliente.Nombre;
                command.Parameters.Add("APELLIDO", OracleDbType.Varchar2).Value = cliente.Apellido;
                command.Parameters.Add("DIRECCION", OracleDbType.Varchar2).Value = cliente.Direccion;
                command.Parameters.Add("TELEFONO", OracleDbType.Varchar2).Value = cliente.Telefono;
                command.ExecuteNonQuery();   
            }
        }

        public List<ClienteRegistrado> ConsultaTotal()
        {
            List<ClienteRegistrado> resultado= new List<ClienteRegistrado>();
            OracleDataReader dataReader;
            using (var command = _conneccion.CreateCommand())
            {
                command.CommandText = "SELECT CEDULA,NOMBRE,APELLIDO,DIRECCION,TELEFONO FROM CLIENTES";
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ClienteRegistrado cliente = MapearClienteRegistrado(dataReader);
                    resultado.Add(cliente);
                }
            }
                return resultado;
        }

        public void ConsultaIndividual(String Cedula)
        {
            
            using (var command = _conneccion.CreateCommand())
            {
                command.CommandText = "SELECT CEDULA,NOMBRE,APELLIDO,DIRECCION,TELEFONO FROM CLIENTES WHERE CEDULA=:CEDULA";
                command.Parameters.Add("CEDULA",OracleDbType.Varchar2).Value=(string)Cedula;
                command.ExecuteReader();
            }
        }


        public void Actualizar(ClienteRegistrado cliente)
        {
            
            using (var command = _conneccion.CreateCommand())
            {
                command.CommandText = @"BEGIN
                                        SERVS_DOMICILIARIOS.ACTUALIZAR_CLIENTE(:CEDULAt,:NOMBREt, :APELLIDOt,:DIRECCIONt,:TELEFONOt);
                                        END;";
                command.Parameters.Add("CEDULAt", OracleDbType.Varchar2).Value = cliente.Cedula;
                command.Parameters.Add("NOMBREt", OracleDbType.Varchar2).Value = cliente.Nombre;
                command.Parameters.Add("APELLIDOt", OracleDbType.Varchar2).Value = cliente.Apellido;
                command.Parameters.Add("DIRECCIONt", OracleDbType.Varchar2).Value = cliente.Direccion;
                command.Parameters.Add("TELEFONOt", OracleDbType.Varchar2).Value = cliente.Telefono;
                command.ExecuteNonQuery();
            }
        }

        public void Eliminar(String Cedula)
        {
            using (var command=_conneccion.CreateCommand())
            {
                command.CommandText = "DELETE FROM CLIENTES WHERE CEDULA=:CEDULA";
                command.Parameters.Add("CEDULA", OracleDbType.Varchar2).Value = Cedula;
                command.ExecuteNonQuery();
            }
        }

        private ClienteRegistrado MapearClienteRegistrado(OracleDataReader dataReader)
        {
            ClienteRegistrado cliente = new ClienteRegistrado();
            cliente.Cedula = (string)dataReader["CEDULA"];
            cliente.Nombre = (string)dataReader["NOMBRE"];
            cliente.Apellido = (string)dataReader["APELLIDO"];
            cliente.Direccion = (string)dataReader["DIRECCION"];
            cliente.Telefono = (string)dataReader["TELEFONO"];
            return cliente;
        }

    }
}
