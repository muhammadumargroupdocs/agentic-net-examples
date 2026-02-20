using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Load an existing presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation("input.pptx");

        // Save as HTML with default regular font Arial
        Aspose.Slides.Export.HtmlOptions htmlOpts = new Aspose.Slides.Export.HtmlOptions();
        htmlOpts.DefaultRegularFont = "Arial";
        pres.Save("output_arial.html", Aspose.Slides.Export.SaveFormat.Html, htmlOpts);

        // Save as HTML with default regular font Lucida Console
        htmlOpts.DefaultRegularFont = "Lucida Console";
        pres.Save("output_lucida.html", Aspose.Slides.Export.SaveFormat.Html, htmlOpts);

        // Save as PDF with default regular font Times New Roman
        Aspose.Slides.Export.PdfOptions pdfOpts = new Aspose.Slides.Export.PdfOptions();
        pdfOpts.DefaultRegularFont = "Times New Roman";
        pres.Save("output_tnr.pdf", Aspose.Slides.Export.SaveFormat.Pdf, pdfOpts);

        // Dispose the presentation
        pres.Dispose();
    }
}