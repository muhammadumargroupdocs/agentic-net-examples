using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Define file paths
        System.String pdfPath = "input.pdf";
        System.String pdfOutputPath = "output_from_pdf.pptx";
        System.String htmlPath = "input.html";
        System.String htmlOutputPath = "output_from_html.pptx";

        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Import slides from PDF
        pres.Slides.AddFromPdf(pdfPath);
        pres.Save(pdfOutputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Prepare HTML stream
        System.IO.FileStream htmlStream = new System.IO.FileStream(htmlPath, System.IO.FileMode.Open, System.IO.FileAccess.Read);

        // Insert slides from HTML at the beginning
        pres.Slides.InsertFromHtml(0, htmlStream, true);
        pres.Save(htmlOutputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Clean up
        htmlStream.Close();
        pres.Dispose();
    }
}