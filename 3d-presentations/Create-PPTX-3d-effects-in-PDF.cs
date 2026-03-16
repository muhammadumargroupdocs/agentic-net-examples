using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        try
        {
            var inputPath = "input.pptx";
            var outputPath = "output.pdf";

            using (var presentation = new Aspose.Slides.Presentation(inputPath))
            {
                var pdfOptions = new Aspose.Slides.Export.PdfOptions();
                presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pdf, pdfOptions);
            }
        }
        catch (Aspose.Slides.PptException ex)
        {
            Console.WriteLine("Presentation error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: " + ex.Message);
        }
    }
}