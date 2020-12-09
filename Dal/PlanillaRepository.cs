using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Entity;

namespace Dal
{
    public class PlanillaRepository
    {
        private readonly OracleConnection conexion;

        public PlanillaRepository(ConnectionManager connection)
        {
            conexion = connection._conexion;
        }

        public List<Planilla> ConsultaTotal()
        {
            List<Planilla> resultado = new List<Planilla>();
            OracleDataReader dataReader;
            using (var command = conexion.CreateCommand())
            {
                command.CommandText = @"SELECT ID_DOMICILIARIO,FECHA,VALOR
                                        FROM HISTORIAL_PLANILLA";
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Planilla planilla = MapearPlanilla(dataReader);
                    resultado.Add(planilla);
                }
            }
            return resultado;
        }


        private Planilla MapearPlanilla(OracleDataReader dataReader)
        {
            Planilla Planilla = new Planilla();
            Planilla.IdDomiciliario = dataReader["ID_DOMICILIARIO"].ToString();
            Planilla.Fecha = Convert.ToDateTime(dataReader["FECHA"].ToString());
            Planilla.Valor = int.Parse(dataReader["VALOR"].ToString());
            return Planilla;
        }

    }
}
