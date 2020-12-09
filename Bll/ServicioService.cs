using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Entity;


namespace BLL
{
    public class ServicioService
    {
        private readonly ConnectionManager conexion;
        private readonly ServicioRepository servicioRepository;

        public ServicioService(String connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            servicioRepository = new ServicioRepository(conexion);
        }

        public String Guardar(Servicio servicio)
        {
            try
            {
                this.conexion.Open();
                this.servicioRepository.Guardar(servicio);
                return "Servicio registrado exitiosamente";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                this.conexion.Close();
            }
        }

        public List<Servicio> ConsultaFiltro(string IdDomiciliario,string IdCliente_,DateTime Fecha)
        {
            List<Servicio> servicio= this.ConsultarTodos().Servicios;

            if (IdDomiciliario.Equals("Todos")==false) 
            {
                servicio = servicio.Where(S => S.IdDomiciliario.Equals(IdDomiciliario)).ToList();
            }
            if (IdCliente_.Equals("Todos") == false)
            {
                servicio = servicio.Where(S => S.IdCliente.Equals(IdCliente_)).ToList();
            }
            servicio = servicio.Where(S => S.Fecha.ToString("dd/MM/yyyy").Equals(Fecha.ToString("dd/MM/yyyy"))).ToList();
            return servicio;
        }

        public ServicioResponse ConsultarTodos()
        {
            try
            {
                this.conexion.Open();
                return new ServicioResponse(this.servicioRepository.ConsultaTotal());
            }
            catch (Exception e)
            {
                return new ServicioResponse(e.Message);
            }
            finally
            {
                this.conexion.Close();
            }
        }


    }


    public class ServicioResponse
    {
        public bool Error { get; }
        public String Mensaje { get; }
        public List<Servicio> Servicios { get; }
        public ServicioResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }



        public ServicioResponse(List<Servicio> servicios_)
        {
            Error = false;
            Servicios = servicios_;
        }

        public ServicioResponse()
        {
            Error = false;
        }

    }




}
