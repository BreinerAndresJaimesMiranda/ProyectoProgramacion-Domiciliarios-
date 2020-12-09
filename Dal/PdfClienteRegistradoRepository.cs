using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace Dal
{
    public class PdfClienteRegistradoRepository
    {

        public void Guardar(List<ClienteRegistrado> clientes, string direccion)
        {
            FileStream stream = new FileStream(direccion,FileMode.Create);
            Document document = new Document(iTextSharp.text.PageSize.LETTER,40,40,40,40);
            PdfWriter writer = PdfWriter.GetInstance(document,stream);
            document.AddAuthor("Aplicacion Pulsacion");
            document.Open();
            document.Add(new Paragraph("INFORME CLIENTES REGISTRADOS"));
            document.Add(new Paragraph("\n"));
            document.Add(LlenarTabla(clientes));
            document.Close();
        }

        private PdfPTable LlenarTabla(List<ClienteRegistrado> clientes)
        {
            PdfPTable TablaResultado = new PdfPTable(5);
            TablaResultado.AddCell(new Paragraph("Cedula"));
            TablaResultado.AddCell(new Paragraph("Nombre"));
            TablaResultado.AddCell(new Paragraph("Apellido"));
            TablaResultado.AddCell(new Paragraph("Direccion"));
            TablaResultado.AddCell(new Paragraph("Telefono"));

            foreach (var item in clientes)
            {
                TablaResultado.AddCell(new Paragraph(item.Cedula));
                TablaResultado.AddCell(new Paragraph(item.Nombre));
                TablaResultado.AddCell(new Paragraph(item.Apellido));
                TablaResultado.AddCell(new Paragraph(item.Direccion));
                TablaResultado.AddCell(new Paragraph(item.Telefono));
            }
            return TablaResultado;
        }



    }
}
