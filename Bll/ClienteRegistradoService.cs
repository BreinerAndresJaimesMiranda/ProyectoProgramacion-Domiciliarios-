using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Entity;

namespace BLL
{
    public class ClienteRegistradoService
    {
        private readonly ConnectionManager conexion;
        private readonly ClienteRegistradoRepository clienteRegistradoRepository;

        public ClienteRegistradoService(String connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            clienteRegistradoRepository = new ClienteRegistradoRepository(conexion);
        }

        public String Guardar(ClienteRegistrado cliente)
        {
            try
            {
                this.conexion.Open();
                this.clienteRegistradoRepository.Guardar(cliente);
                return "Cliente registrado exitiosamente";
            }
            catch (Exception)
            {
                return "No se ha podido registrar el cliente en cuestion";
            }
            finally
            {
                this.conexion.Close();
            }
        }

        public String Eliminar(String Cedula)
        {
            try
            {
                this.conexion.Open();
                this.clienteRegistradoRepository.Eliminar(Cedula);
                return "Cliente eliminado Exitosamente";
            }
            catch (Exception)
            {
                return "No se ha podido elimar el cliente en cuestion";
            }
            finally
            {
                this.conexion.Close();
            }
        }


        public ClienteRegistradoResponse ConsultarTodos()
        {
            try 
            {
                this.conexion.Open();
                return new ClienteRegistradoResponse(this.clienteRegistradoRepository.ConsultaTotal());
            }
            catch (Exception)
            {
                return new ClienteRegistradoResponse("No se ha podido realizar la consulta");
            }
            finally
            {
                this.conexion.Close();
            }
        }

        public bool ConsultaIndividual(String Cedula)
        {
            try
            {
                this.conexion.Open();
                if (this.clienteRegistradoRepository.ConsultaIndividual(Cedula) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;

            }
            finally
            {
                this.conexion.Close();
            }
        }


        public string ConsultaCedulas()
        {
            ClienteRegistradoResponse clienteRegistradoResponse = this.ConsultarTodos();
            if (clienteRegistradoResponse.Error)
            {
                return clienteRegistradoResponse.Mensaje;
            }
            else
            {
                string resultado="";
                foreach (var item in clienteRegistradoResponse.ClientesRegistrados)
                {
                    resultado = resultado + item.Cedula + ";";
                }
                return resultado;
            }
        }

        public bool Actualizar(ClienteRegistrado cliente)
        {
            try
            {
                this.conexion.Open();
                    clienteRegistradoRepository.Actualizar(cliente);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                
                this.conexion.Close(); 
            }
        }

    }

    public class ClienteRegistradoResponse
    {
        public bool Error{get;}
        public String Mensaje { get; }
        public List<ClienteRegistrado> ClientesRegistrados { get; }
        public ClienteRegistradoResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }

        public ClienteRegistradoResponse(List<ClienteRegistrado> clientesRegistrados)
        {
            Error = false;
            ClientesRegistrados = clientesRegistrados;
        }
    }
}
