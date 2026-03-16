using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace Convert3DPptxToPdf
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Load the PPTX presentation containing 3D effects
                Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx");

                // Create PDF export options (default options retain visual effects)
                Aspose.Slides.Export.PdfOptions pdfOptions = new Aspose.Slides.Export.PdfOptions();

                // Save the presentation as PDF
                presentation.Save("output.pdf", Aspose.Slides.Export.SaveFormat.Pdf, pdfOptions);
            }
            catch (Aspose.Slides.PptException ex)
            {
                // Handle presentation-specific errors
                Console.WriteLine("Error processing presentation: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle other errors
                Console.WriteLine("Unexpected error: " + ex.Message);
            }
        }
    }
}