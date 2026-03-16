using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Path to the input PPTX with macros
                string inputPath = "input_with_macros.pptm";
                // Path to the output PDF
                string outputPath = "output.pdf";

                // Load the presentation (macros are preserved in the VbaProject property)
                using (Presentation presentation = new Presentation(inputPath))
                {
                    // Configure PDF options (e.g., include hidden slides)
                    PdfOptions pdfOptions = new PdfOptions();
                    pdfOptions.ShowHiddenSlides = true;

                    // Save the presentation as PDF
                    presentation.Save(outputPath, SaveFormat.Pdf, pdfOptions);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}