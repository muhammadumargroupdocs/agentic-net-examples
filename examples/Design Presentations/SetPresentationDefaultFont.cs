using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Set default regular font for HTML export
        Aspose.Slides.Export.HtmlOptions htmlOpts = new Aspose.Slides.Export.HtmlOptions();
        htmlOpts.DefaultRegularFont = "Arial";

        // Save as HTML with Arial default font
        pres.Save("output_arial.html", Aspose.Slides.Export.SaveFormat.Html, htmlOpts);

        // Change default regular font to Lucida Sans
        htmlOpts.DefaultRegularFont = "Lucida Sans";

        // Save as HTML with Lucida default font
        pres.Save("output_lucida.html", Aspose.Slides.Export.SaveFormat.Html, htmlOpts);

        // Set default regular font for PDF export
        Aspose.Slides.Export.PdfOptions pdfOpts = new Aspose.Slides.Export.PdfOptions();
        pdfOpts.DefaultRegularFont = "Arial";

        // Save as PDF with Arial default font
        pres.Save("output_arial.pdf", Aspose.Slides.Export.SaveFormat.Pdf, pdfOpts);

        // Dispose the presentation
        pres.Dispose();
    }
}