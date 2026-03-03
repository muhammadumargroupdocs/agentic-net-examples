using System;

namespace SlideToPdfConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path to the source PowerPoint file
            string sourcePath = "input.pptx";

            // Path to the output PDF file
            string outputPath = "selected_slides.pdf";

            // Array of slide numbers to convert (1‑based indexing)
            int[] selectedSlides = new int[] { 1, 3, 5 };

            // Load the presentation
            using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(sourcePath))
            {
                // Save only the selected slides as PDF
                presentation.Save(outputPath, selectedSlides, Aspose.Slides.Export.SaveFormat.Pdf);
            }
        }
    }
}