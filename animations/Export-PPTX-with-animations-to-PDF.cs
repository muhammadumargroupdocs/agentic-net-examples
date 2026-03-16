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

            // Load the presentation
            using (var presentation = new Presentation(inputPath))
            {
                // Process animations to ensure they are considered
                using (var animationsGenerator = new PresentationAnimationsGenerator(presentation))
                {
                    animationsGenerator.Run(presentation.Slides);
                }

                // Set PDF options (include hidden slides)
                var pdfOptions = new PdfOptions
                {
                    ShowHiddenSlides = true
                };

                // Export to PDF
                presentation.Save(outputPath, SaveFormat.Pdf, pdfOptions);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}