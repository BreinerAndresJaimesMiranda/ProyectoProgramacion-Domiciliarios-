using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Entity;

namespace BLL
{
    public class PdfClienteRegistradoService
    {
        public PdfClienteRegistradoRepository pdfClienteRegistradoRepository;

        public PdfClienteRegistradoService()
        {
            pdfClienteRegistradoRepository = new PdfClienteRegistradoRepository();
        }

        public string Guardar(List<ClienteRegistrado> clientes,string direccion)
        {
            try
            {
                pdfClienteRegistradoRepository.Guardar(clientes, direccion);
                return "Pdf creado y guardado correctamente";
            }
            catch (Exception)
            {
                return "No se ha podido guardar en el pdf";
            }
        }


    }
}
