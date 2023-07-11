using GeradorDeTestes.Dominio.ModuloQuestao;
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
                using (PdfWriter writer = new PdfWriter(pathArquivo))
                {
                    using (PdfDocument pdf = new PdfDocument(writer))
                    {
                        Document document = new Document(pdf);
                        document.Add(new Paragraph("Teste").SetTextAlignment(TextAlignment.CENTER).SetFontSize(20));
                        document.Add(new Paragraph("Prova" + ((id == 0) ? "es" : ": " + id)).SetTextAlignment(TextAlignment.CENTER).SetFontSize(15));
                        document.Add(new LineSeparator(new SolidLine()));
                        Table table = new(5, false);
                        table.SetWidth(UnitValue.CreatePercentValue(100));
                        table.SetTextAlignment(TextAlignment.LEFT);
                        table.AddCell(new Cell().Add(new Paragraph("TÍTULO")).SetBorder(Border.NO_BORDER));
                        table.AddCell(new Cell().Add(new Paragraph("DATA DE GERAÇÃO")).SetBorder(Border.NO_BORDER));
                        table.AddCell(new Cell().Add(new Paragraph("QUANTIDADE DE QUESTÕES")).SetBorder(Border.NO_BORDER));
                        table.AddCell(new Cell().Add(new Paragraph("DISCIPLINA")).SetBorder(Border.NO_BORDER));
                        table.AddCell(new Cell().Add(new Paragraph("MATÉRIA")).SetBorder(Border.NO_BORDER));

                        RepositorioTesteEmSql repositorioTeste = new();
                        Teste teste = repositorioTeste.Busca(id);

                        table.AddCell(new Cell().Add(new Paragraph(teste.titulo.ToString())).SetBorder(Border.NO_BORDER));
                        table.AddCell(new Cell().Add(new Paragraph(teste.dataDeGeracao.ToString("d"))).SetBorder(Border.NO_BORDER));
                        table.AddCell(new Cell().Add(new Paragraph(teste.quantQuestoes.ToString())).SetBorder(Border.NO_BORDER));
                        table.AddCell(new Cell().Add(new Paragraph(teste.disciplina.nome.ToString())).SetBorder(Border.NO_BORDER));
                        table.AddCell(new Cell().Add(new Paragraph(teste.materia.nome.ToString())).SetBorder(Border.NO_BORDER));

                        Table table2 = new(1, false);
                        table2.AddCell(new Cell().Add(new Paragraph("Questões")).SetBorder(Border.NO_BORDER));
                        Cell celulaQuestoes = new Cell();
                       
                        foreach (Questao questao in teste.listaQuestoes)
                        {
                            celulaQuestoes.Add(new Paragraph(questao.titulo.ToString()).SetBorder(Border.NO_BORDER));
                        }

                        table2.AddCell(celulaQuestoes);

                        document.Add(table); 
                        document.Add(table2);

                        document.Close();
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}
