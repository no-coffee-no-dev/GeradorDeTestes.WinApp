using GeradorDeTestes.Dominio.ModuloTeste;
using GeradorDeTestes.Infra.Dados.Sql.ModuloTeste;
using iText.IO.Image;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.Configuration;
using System.Data;

namespace GeradorDeTestes.WinApp.ModuloTeste
{
    public static class GeradorDePDFdeTeste
    {
        public static string pathArquivo(string nome)
        {
            SaveFileDialog savePath = new()
            {
                Title = "Selecione o local e o nome para salvar seu relatório",
                Filter = "Arquivo|*.pdf",
                FileName = nome + "-" + Convert.ToString(DateTime.Now).Replace("/", "-").Replace(":", "-") + ".pdf"
            };
            if (savePath.ShowDialog() == DialogResult.OK)
            {
                return Convert.ToString(savePath.FileName);
            }
            else
            {
                return "Arquivo.pdf";
            }
        }

        public static void PdfTeste(string pathArquivo, int id)
        {
            try
            {
                PdfWriter pdfWriter = new(pathArquivo);
                PdfDocument pdfDocument = new(pdfWriter);
                Document document = new(pdfDocument, PageSize.A4.Rotate());
                document.Add(new Paragraph("Teste").SetTextAlignment(TextAlignment.CENTER).SetFontSize(20));
                document.Add(new Paragraph("Prova" + ((id == 0) ? "es" : ": " + id)).SetTextAlignment(TextAlignment.CENTER).SetFontSize(15));
                document.Add(new LineSeparator(new SolidLine()));
                Table table = new(6, false);
                table.SetWidth(UnitValue.CreatePercentValue(100));
                table.SetTextAlignment(TextAlignment.LEFT);
                table.AddCell(new Cell().Add(new Paragraph("ID")).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph("TITULO")).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph("DATADEGERACAO")).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph("QUANTQUESTOES")).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph("DISCIPLINA")).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph("MATERIA")).SetBorder(Border.NO_BORDER));

                RepositorioTesteEmSql repositorioTeste = new();
                Teste teste = repositorioTeste.Busca(id);           
                              
                table.AddCell(new Cell().Add(new Paragraph(teste.id.ToString())).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph(teste.titulo.ToString())).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph(teste.dataDeGeracao.ToString("d"))).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph(teste.quantQuestoes.ToString())).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph(teste.disciplina.nome.ToString())).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph(teste.materia.nome.ToString())).SetBorder(Border.NO_BORDER));

                document.Add(table);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}
