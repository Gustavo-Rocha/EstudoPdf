using MigraDocCore.DocumentObjectModel;
using MigraDocCore.DocumentObjectModel.Tables;
using MigraDocCore.Rendering;
using PdfSharp.Drawing;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace EstudoPdf
{
    [System.CLSCompliant(false)]
    [System.Runtime.Versioning.SupportedOSPlatform("windows")]
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var listaElementos = new List<PerfilPDF>()
            {
                new PerfilPDF
                {
                    NomePessoa = "Gustavo Oliveira ROcha",
                    Perfil = "Desenvolvedor Backend Senior",
                    ValorHoraNegociado = "R$150,00",
                    TotalHoras = "1000",
                    ValorTotal = "R$ 15.00,00"
                },
                new PerfilPDF
                {
                    NomePessoa = "Gustavo Oliveira ROcha",
                    Perfil = "Desenvolvedor Backend Senior",
                    ValorHoraNegociado = "R$150,00",
                    TotalHoras = "1000",
                    ValorTotal = "R$ 15.00,00"
                },
                new PerfilPDF
                {
                    NomePessoa = "Gustavo Oliveira ROcha",
                    Perfil = "Desenvolvedor Backend Senior",
                    ValorHoraNegociado = "R$150,00",
                    TotalHoras = "1000",
                    ValorTotal = "R$ 15.00,00"
                },
                new PerfilPDF
                {
                    NomePessoa = "Gustavo Oliveira ROcha",
                    Perfil = "Desenvolvedor Backend Senior",
                    ValorHoraNegociado = "R$150,00",
                    TotalHoras = "1000",
                    ValorTotal = "R$ 15.00,00"
                }
            };

            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var page = doc.AddPage();
                var graphics = PdfSharp.Drawing.XGraphics.FromPdfPage(page);
                var textFormatter = new PdfSharp.Drawing.Layout.XTextFormatter(graphics);
                var font = new PdfSharp.Drawing.XFont("Arial", 10, PdfSharp.Drawing.XFontStyleEx.Bold);

                graphics.DrawRoundedRectangle(PdfSharp.Drawing.XPens.Aqua, PdfSharp.Drawing.XBrushes.DodgerBlue, 35, 20, 100, 30, 30, 30);

                graphics.DrawImage(PdfSharp.Drawing.XImage.FromFile(@"document_3530.png"), 45, 24);
                textFormatter.DrawString("PC-00001", font, PdfSharp.Drawing.XBrushes.White, new PdfSharp.Drawing.XRect(80, 30, page.Width, page.Height));
                textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Right;

                textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;
                textFormatter.DrawString("Solicitação de Proposta Comercial", new PdfSharp.Drawing.XFont("Arial", 16, PdfSharp.Drawing.XFontStyleEx.Bold), PdfSharp.Drawing.XBrushes.DodgerBlue, new PdfSharp.Drawing.XRect(35, 70, page.Width, page.Height));
                textFormatter.DrawString("Para: Gabriel.Santana@opah.com.br", new PdfSharp.Drawing.XFont("Arial", 11), PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(35, 100, page.Width, page.Height));

                textFormatter.DrawString("Gestor Banco:", new PdfSharp.Drawing.XFont("Arial", 14), PdfSharp.Drawing.XBrushes.DodgerBlue, new PdfSharp.Drawing.XRect(35, 150, page.Width, page.Height));
                textFormatter.DrawString("Daniela:", new PdfSharp.Drawing.XFont("Arial", 11), PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(35, 170, page.Width, page.Height));



                //textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Right;
                textFormatter.DrawString("Consultoria:", new PdfSharp.Drawing.XFont("Arial", 14), PdfSharp.Drawing.XBrushes.DodgerBlue, new PdfSharp.Drawing.XRect(310, 150, page.Width, page.Height));
                textFormatter.DrawString("Opah Digital:", new PdfSharp.Drawing.XFont("Arial", 11), PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(310, 170, page.Width, page.Height));


                textFormatter.DrawString("Tribo/Squad:", new PdfSharp.Drawing.XFont("Arial", 14), PdfSharp.Drawing.XBrushes.DodgerBlue, new PdfSharp.Drawing.XRect(35, 200, page.Width, page.Height));
                textFormatter.DrawString("TRIBO DE RETENCAO / Squad Parcele", new PdfSharp.Drawing.XFont("Arial", 11), PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(35, 220, page.Width, page.Height));

                var descricaoALocacao = "Alocacao de Profissionais para evolucao dos processo relacionados aos produto de Retenção: Parcele e acordo de divida" +
                    " Alocacao de Profissionais para evolucao dos processo relacionados aos produto de Retenção: Parcele e acordo de divida" +
                    "Alocacao de Profissionais para evolucao dos processo relacionados aos produto de Retenção: Parcele e acordo de divida" +
                    "Alocacao de Profissionais para evolucao dos processo relacionados aos produto de Retenção: Parcele e acordo de divida";
                textFormatter.DrawString("Escopo da Proposta:", new PdfSharp.Drawing.XFont("Arial", 14), PdfSharp.Drawing.XBrushes.DodgerBlue, new PdfSharp.Drawing.XRect(35, 280, page.Width, page.Height));


                //textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Justify;
                //textFormatter.DrawString(descricaoALocacao.ToUpper(), new PdfSharp.Drawing.XFont("Arial", 11), PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(35, 260, page.Width, page.Height));

                XRect rect = new XRect(35, 300, 520, 320);
                graphics.DrawRectangle(XBrushes.White, rect);
                //tf.Alignment = ParagraphAlignment.Left;
                textFormatter.DrawString(descricaoALocacao, new XFont("Arial", 11), XBrushes.Black, rect, XStringFormats.TopLeft);

                // regiao de listas de perfils
                textFormatter.DrawString("Opah Digital", new XFont("Arial", 16,XFontStyleEx.Bold), PdfSharp.Drawing.XBrushes.DodgerBlue, new PdfSharp.Drawing.XRect(35, 390, page.Width, page.Height));

                XRect retaListaElementoPerfil = new XRect(35, 420, 150, 13);
                XRect retaListaElementoVlAcordado = new XRect(185, 420, 100, 13);
                XRect retaListaElementoTotalHoras = new XRect(330, 420, 100, 13);
                XRect retaListaElementoVlTotoal = new XRect(470, 420, 100, 13);

                graphics.DrawRectangle(XBrushes.White, retaListaElementoPerfil);
                textFormatter.DrawString("Perfil", new XFont("Arial", 11), XBrushes.Black, retaListaElementoPerfil, XStringFormats.TopLeft);

                textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Right;
                graphics.DrawRectangle(XBrushes.White, retaListaElementoVlAcordado);
                textFormatter.DrawString("Valor Acordado", new XFont("Arial", 11), XBrushes.Black, retaListaElementoVlAcordado, XStringFormats.TopLeft);
                
                graphics.DrawRectangle(XBrushes.White, retaListaElementoTotalHoras);
                textFormatter.DrawString("Total de Horas", new XFont("Arial", 11), XBrushes.Black, retaListaElementoTotalHoras, XStringFormats.TopLeft);
               
                graphics.DrawRectangle(XBrushes.White, retaListaElementoVlTotoal);
                textFormatter.DrawString("Valor Total", new XFont("Arial", 11), XBrushes.Black, retaListaElementoVlTotoal, XStringFormats.TopLeft);

                //Implementa listagem de informações

                foreach (var perfil in listaElementos)
                {

                }

                // graphics.DrawLine(PdfSharp.Drawing.XPens.Blue, 150, 150, 250, 200);


                doc.Save("arquivo.pdf");
                //System.Diagnostics.Process.Start("arquivo.pdf");
            }

























            //Document document = new();

            //var section = document.AddSection();

            //section.PageSetup.PageFormat = PageFormat.A4;
            //section.PageSetup.PageHeight = 842;
            //section.PageSetup.PageWidth = 595;
            //section.PageSetup.TopMargin = 0;
            //section.PageSetup.BottomMargin = 24;
            //section.PageSetup.LeftMargin = 35;
            //section.PageSetup.RightMargin = 30;

            //AddHeader(section);





            //PdfDocumentRenderer pdfDocumentRenderer = new PdfDocumentRenderer()
            //{
            //    Document = document
            //};
            //pdfDocumentRenderer.RenderDocument();

            //using MemoryStream ms = new();
            //pdfDocumentRenderer.PdfDocument.Save("Pdfteste.pdf");

            ////Process.Start(new ProcessStartInfo { FileName = "Pdfteste.pdf" });
            ////System.Diagnostics.Process.Start("Pdfteste.pdf");
            //pdfDocumentRenderer.PdfDocument.Close();

            //ms.Position = 0;
        }

        //private static void AddHeader(Section section)
        //{
        //    Table table = new();
        //    table.Borders.Visible = false;

        //    table.Rows.HeightRule = RowHeightRule.Auto;

        //    table.AddColumn(100);

        //    var row = table.AddRow();
        //    row.HeightRule = RowHeightRule.Exactly;
        //    row.Height = 5;
        //    row.Shading.Color = MigraDocCore.DocumentObjectModel.Colors.Black;

        //    row.Table.AddRow();
        //    row.TopPadding = 5;
        //    row.BottomPadding = 5;
        //    var paragraph = row.Cells[0].AddParagraph();
        //    paragraph.Format.Alignment = ParagraphAlignment.Left ;

        //    ////var image = paragraph.AddImage("codigoLimpo.jpg");
        //    //ImageHelper.Height = 26;

        //    row =  table.AddRow();
        //    row.Shading.Color = MigraDocCore.DocumentObjectModel.Colors.Azure;
        //    row.TopPadding = 10;
        //    row.BottomPadding = 10;
        //    row.Borders.Bottom = new()
        //    {
        //        Width = 1.3,
        //        Color = MigraDocCore.DocumentObjectModel.Colors.BlueViolet,
        //    };
        //    row.Cells[0].VerticalAlignment = VerticalAlignment.Center;
        //         row.Cells[0].RoundedCorner = RoundedCorner.TopLeft;


        //    paragraph = row.Cells[0].AddParagraph("ID-0001");
        //    paragraph.Format.Alignment = ParagraphAlignment.Right;
        //    section.Add(table);



        //}
    }
}
