using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        try
        {
            // Paths for input PPTX and output PDF
            string inputPath = "input.pptx";
            string outputPath = "output.pdf";

            // Load the presentation containing 3D effects
            using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
            {
                // Create PDF export options (default retains visual effects)
                Aspose.Slides.Export.PdfOptions pdfOptions = new Aspose.Slides.Export.PdfOptions();

                // Save the presentation as PDF
                presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pdf, pdfOptions);
            }
        }
        catch (Aspose.Slides.PptException ex)
        {
            // Handle presentation-specific errors
            Console.WriteLine("Presentation error: " + ex.Message);
        }
        catch (Exception ex)
        {
            // Handle any other unexpected errors
            Console.WriteLine("Unexpected error: " + ex.Message);
        }
    }
}