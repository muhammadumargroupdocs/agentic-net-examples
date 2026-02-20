using System;

namespace AsposeSlidesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define input and output file paths
            System.String inputPath = "input.pptx";
            System.String outputPath = "output.pdf";

            // Load the presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Set a custom slide size (width: 800 points, height: 600 points) and ensure existing content fits
            presentation.SlideSize.SetSize(800f, 600f, Aspose.Slides.SlideSizeScaleType.EnsureFit);

            // Save the presentation as PDF
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pdf);
        }
    }
}