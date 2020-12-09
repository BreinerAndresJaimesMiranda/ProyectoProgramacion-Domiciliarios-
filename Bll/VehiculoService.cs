using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Dal;

namespace BLL
{
    public class VehiculoService
    {

       private readonly ConnectionManager conexion;
        private readonly VehiculoRepository vehiculoRepository;

        public VehiculoService(String connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            vehiculoRepository = new VehiculoRepository(conexion);
        }
 

        public VehiculoResponse ConsultaIndividual(String ID_trabajador,string placa)
        {
            try
            {
                this.conexion.Open();
                if (this.vehiculoRepository.ConsultaIndividual(ID_trabajador,placa) == 1)
                {
                    return new VehiculoResponse();
                }
                else
                {
                    return new VehiculoResponse("El dato buscano no se encuentra registrado");
                }
            }
            catch (Exception e)
            {
                return new VehiculoResponse(e.Message);
            }
            finally
            {
                this.conexion.Close();
            }
        }

        public String Guardar(Vehiculo vehiculo)
        {
            try
            {
                this.conexion.Open();
                this.vehiculoRepository.Guardar(vehiculo);
                return "Vehiculo registrado exitiosamente";
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



        public VehiculoResponse ConsultarTodos()
        {
            try
            {
                this.conexion.Open();
                return new VehiculoResponse(this.vehiculoRepository.ConsultaTotal());
            }
            catch (Exception e)
            {
                return new VehiculoResponse(e.Message);
            }
            finally
            {
                this.conexion.Close();
            }
        }

        public string ConsultarColores()
        {
            try
            {
                this.conexion.Open();
                return vehiculoRepository.ConsultaColores();
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

        public string ConsultarMarcas()
        {
            try
            {
                this.conexion.Open();
                return vehiculoRepository.ConsultaMarcas();
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

        public VehiculoResponse ConsultarHistorial()
        {
            try
            {
                this.conexion.Open();
                return new VehiculoResponse(this.vehiculoRepository.ConsultaHistorial());
            }
            catch (Exception e)
            {
                return new VehiculoResponse(e.Message);
            }
            finally
            {
                this.conexion.Close();
            }

        }

    }

    public class VehiculoResponse
    {
        public bool Error { get; }
        public String Mensaje { get; }
        public List<Vehiculo> vehiculos { get; }
        public List<VehiculoHistorial> vehiculosHistorial { get; }
        public VehiculoResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }

        public VehiculoResponse(List<Vehiculo> vehiculos_)
        {
            Error = false;
            vehiculos = vehiculos_;
        }

        public VehiculoResponse(List<VehiculoHistorial> vehiculos_)
        {
            Error = false;
            vehiculosHistorial = vehiculos_;
        }

        public VehiculoResponse()
        {
            Error = false;
        }

    }

}
