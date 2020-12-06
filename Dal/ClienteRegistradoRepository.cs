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
                command.CommandText = "INSERT INTO CLIENTES(CEDULA,NOMBRE,APELLIDO,DIRECCION,TELEFONO) VALUES(:CEDULA,:NOMBRE,:APELLIDO,:DIRECCION,:TELEFONO)";
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

        public ClienteRegistrado ConsultaIndividual(ClienteRegistrado clienteParaBuscar)
        {
            OracleDataReader dataReader;
            using (var command = _conneccion.CreateCommand())
            {
                command.CommandText = "SELECT CEDULA,NOMBRE,APELLIDO,DIRECCION,TELEFONO FROM CLIENTES WHERE CEDULA=:CEDULA";
                command.Parameters.Add("CEDULA",OracleDbType.Varchar2).Value=clienteParaBuscar.Cedula;
                dataReader = command.ExecuteReader();
                    ClienteRegistrado clienteEncontrado = MapearClienteRegistrado(dataReader);
                    return clienteEncontrado;
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
