using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Entity;

namespace BLL
{
    public class DomiciliarioService
    {

        private readonly ConnectionManager conexion;
        private readonly DomiciliarioRepository domiciliarioRepository;

        public DomiciliarioService(String connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            domiciliarioRepository = new DomiciliarioRepository(conexion);
        }

        public String Guardar(Domiciliario domiciliario)
        {
            try
            {
                this.conexion.Open();
                this.domiciliarioRepository.Guardar(domiciliario);
                return "Domiciliario registrado exitiosamente";
            }
            catch (Exception)
            {
                return "No se ha podido registrar el domiciliario en cuestion";
            }
            finally
            {
                this.conexion.Close();
            }
        }


        public string ConsultarIdTrabajadores()
        {
            DomiciliarioResponse domiciliarioResponse = this.ConsultarTodos();
            if (domiciliarioResponse.Error)
            {
                return domiciliarioResponse.Mensaje;
            }
            else
            {
                string resultado = "";
                foreach (var item in domiciliarioResponse.domiciliarios)
                {
                    resultado = resultado + item.ID_Trabajador + ";";
                }
                return resultado;
            }
        }

        public DomiciliarioResponse ConsultaIndividual(String ID_trabajador)
        {
            try
            {
                this.conexion.Open();
                if (this.domiciliarioRepository.ConsultaIndividual(ID_trabajador) == 1)
                {
                    return new DomiciliarioResponse();
                }
                else
                {
                    return new DomiciliarioResponse("El dato buscano no se encuentra registrado");
                }
            }
            catch (Exception e)
            {
                return new DomiciliarioResponse(e.Message);
            }
            finally
            {
                this.conexion.Close();
            }
        }


        public DomiciliarioResponse ConsultarTodos()
        {
            try
            {
                this.conexion.Open();
                return new DomiciliarioResponse(this.domiciliarioRepository.ConsultaTotal());
            }
            catch (Exception e)
            {
                return new DomiciliarioResponse(e.Message);
            }
            finally
            {
                this.conexion.Close();
            }
        }


        public DomiciliarioResponse Actualizar(Domiciliario domiciliario)
        {
            try
            {
                this.conexion.Open();
                domiciliarioRepository.Actualizar(domiciliario);
                return new DomiciliarioResponse(); ;
            }
            catch (Exception e)
            {
                return new DomiciliarioResponse(e.ToString()); 
            }
            finally
            {

                this.conexion.Close();
            }
        }






    }

    public class DomiciliarioResponse
    {
        public bool Error { get; }
        public String Mensaje { get; }

        public Domiciliario domiciliario { get; set; }
        public List<Domiciliario> domiciliarios { get; }
        public DomiciliarioResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }

        public DomiciliarioResponse(List<Domiciliario> domiciliario)
        {
            Error = false;
            domiciliarios = domiciliario;
        }

        public DomiciliarioResponse(Domiciliario domiciliario_)
        {
            Error = false;
            domiciliario = domiciliario_;
        }

        public DomiciliarioResponse()
        {
            Error = false;
        }
    }
}
