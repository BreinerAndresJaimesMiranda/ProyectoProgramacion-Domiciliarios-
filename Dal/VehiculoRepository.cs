using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Oracle.ManagedDataAccess.Client;


namespace Dal
{
    public class VehiculoRepository
    {


        private readonly OracleConnection conexion;

        public VehiculoRepository(ConnectionManager connection)
        {
            conexion = connection._conexion;
        }

        public void Guardar(Vehiculo vehiculo)
        {
            using (var command = conexion.CreateCommand())
            {
                command.CommandText = @"BEGIN
                                        SERVS_DOMICILIARIOS.REGISTRAR_VEHICULO(:PLACA ,:ID_DOMICILIARIO,:CODIGO_COLOR,:CODIGO_MARCA,:MODELO);
                                        END;";
                command.Parameters.Add("PLACA", OracleDbType.Varchar2).Value = vehiculo.Placa;
                command.Parameters.Add("ID_DOMICILIARIO", OracleDbType.Varchar2).Value = vehiculo.ID_Domiciliario;
                command.Parameters.Add("CODIGO_COLOR", OracleDbType.Int32).Value = (Int32)vehiculo.Codigo_Color;
                command.Parameters.Add("CODIGO_MARCA", OracleDbType.Int32).Value = (Int32)vehiculo.Codigo_Marca;
                command.Parameters.Add("MODELO", OracleDbType.Varchar2).Value = vehiculo.Modelo;
                command.ExecuteNonQuery();
            }
        }

        public int ConsultaIndividual(string placa, string id_domiciliario)
        {

            using (var command = conexion.CreateCommand())
            {
                command.CommandText = "SELECT COUNT(*) FROM VEHICULOS WHERE ID_DOMICILIARIO = :ID_TRABAJADORT AND PLACA =:PLACAT";
                command.Parameters.Add("ID_DOMICILIARIO", OracleDbType.Varchar2).Value = (string)id_domiciliario;
                command.Parameters.Add("PLACAT", OracleDbType.Varchar2).Value = (string)placa;
                var dataReader = command.ExecuteReader();
                dataReader.Read();
                return dataReader.GetInt32(0);
            }

        }

        public List<Vehiculo> ConsultaTotal()
        {
            List<Vehiculo> resultado = new List<Vehiculo>();
            OracleDataReader dataReader;
            using (var command = conexion.CreateCommand())
            {
                command.CommandText = "SELECT V.PLACA,V.ID_DOMICILIARIO,C.NOMBRE,M.NOMBRE,V.MODELO FROM (VEHICULOS V JOIN COLORES C ON C.CODIGO=V.CODIGO_COLOR) JOIN MARCAS M ON M.CODIGO = V.CODIGO_MARCA";
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Vehiculo vehiculo = MapearVehiculo(dataReader);
                    resultado.Add(vehiculo);
                }
            }
            return resultado;
        }


        public List<VehiculoHistorial> ConsultaHistorial()
        {
            List<VehiculoHistorial> resultado = new List<VehiculoHistorial>();
            OracleDataReader dataReader;
            using (var command = conexion.CreateCommand())
            {
                command.CommandText = @"SELECT H.PLACA,H.ID_DOMICILIARIO,C.NOMBRE,M.NOMBRE,
                                        H.CODIGO_COLOR,H.CODIGO_MARCA,
                                        H.MODELO,
                                        H.FECHA_INICIO_USO,H.FECHA_FIN_USO FROM 
                                        (HISTORIAL_VEHICULOS H JOIN COLORES C ON C.CODIGO=H.CODIGO_COLOR)
                                        JOIN MARCAS M ON M.CODIGO = H.CODIGO_MARCA";
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    VehiculoHistorial vehiculo = MapearVehiculoHistorial(dataReader);
                    resultado.Add(vehiculo);
                }
            }
            return resultado;
        }

        public string ConsultaColores()
        {
            string resultado="";
            OracleDataReader dataReader;
            using (var command = conexion.CreateCommand())
            {
                command.CommandText = @"SELECT NOMBRE FROM COLORES ORDER BY CODIGO";
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    resultado = resultado +dataReader.GetString(0)+";";
                }
            }
            return resultado;
        }

        public string ConsultaMarcas()
        {
            string resultado = "";
            OracleDataReader dataReader;
            using (var command = conexion.CreateCommand())
            {
                command.CommandText = @"SELECT NOMBRE FROM MARCAS ORDER BY CODIGO";
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    resultado = resultado + dataReader.GetString(0) + ";";
                }
            }
            return resultado;
        }

        private Vehiculo MapearVehiculo(OracleDataReader dataReader)
        {
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.Placa = (string)dataReader["PLACA"];
            vehiculo.ID_Domiciliario = (string)dataReader["ID_DOMICILIARIO"]; ;
            vehiculo.Color = dataReader.GetString(2);
            vehiculo.Marca = dataReader.GetString(3);
            vehiculo.Modelo = (string)dataReader["MODELO"];
            return vehiculo;
        }
        

        private VehiculoHistorial MapearVehiculoHistorial(OracleDataReader dataReader)
        {
            VehiculoHistorial vehiculoHistorial = new VehiculoHistorial();
            vehiculoHistorial.Placa = (string)dataReader["PLACA"];
            vehiculoHistorial.ID_Domiciliario = (string)dataReader["ID_DOMICILIARIO"];
            vehiculoHistorial.Color = dataReader.GetString(2);
            vehiculoHistorial.Marca = dataReader.GetString(3);
            vehiculoHistorial.Codigo_Color = int.Parse(dataReader["CODIGO_COLOR"].ToString());
            vehiculoHistorial.Codigo_Marca = int.Parse(dataReader["CODIGO_MARCA"].ToString());
            vehiculoHistorial.Modelo = (string)dataReader["MODELO"];
            vehiculoHistorial.FechaInicioUso = dataReader["FECHA_INICIO_USO"].ToString();
            vehiculoHistorial.FechaFinUso= dataReader["FECHA_FIN_USO"].ToString();
            return vehiculoHistorial;
        }

    }
}
