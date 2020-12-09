using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Entity;

namespace BLL
{
    public class PlanillaService
    {


        private readonly ConnectionManager conexion;
        private readonly PlanillaRepository planillaRepository;

        public PlanillaService(String connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            planillaRepository = new PlanillaRepository(conexion);
        }


        public PlanillaResponse ConsultaFiltro(string IdDomiciliario, DateTime Fecha)
        {
            try
            {


                List<Planilla> planillas = this.ConsultarTodos();

                if (IdDomiciliario.Equals("Todos") == false)
                {
                    planillas = planillas.Where(S => S.IdDomiciliario.Equals(IdDomiciliario)).ToList();
                }

                planillas = planillas.Where(P => P.Fecha.ToString("dd/MM/yyyy").Equals(Fecha.ToString("dd/MM/yyyy"))).ToList();
                return new PlanillaResponse(planillas);
            }catch(Exception e)
            {
                  return new PlanillaResponse(e.Message);
            }

        }


        public List<Planilla> ConsultarTodos()
        {
            List<Planilla> planillas;
                this.conexion.Open();
            planillas=this.planillaRepository.ConsultaTotal();
            this.conexion.Close();
            return planillas;
        }
    }

    public class PlanillaResponse
    {
        public bool Error { get; }
        public String Mensaje { get; }
        public List<Planilla> Planillas { get; }
        public PlanillaResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }



        public PlanillaResponse(List<Planilla> planillas)
        {
            Error = false;
            Planillas = planillas;
        }

        public PlanillaResponse()
        {
            Error = false;
        }

    }

}
