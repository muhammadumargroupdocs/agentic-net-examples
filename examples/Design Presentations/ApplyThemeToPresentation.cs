using System;
using Aspose.Slides;

namespace ThemeApplicationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define file paths
            string dataDir = @"C:\Data\";
            string inputPath = dataDir + "input.pptx";
            string themePath = dataDir + "theme.thmx";
            string outputPath = dataDir + "output.pptx";

            // Load the presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Apply external theme to the first master slide
            Aspose.Slides.IMasterSlide masterSlide = presentation.Masters[0];
            masterSlide.ApplyExternalThemeToDependingSlides(themePath);

            // Save the modified presentation
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

            // Clean up
            presentation.Dispose();
        }
    }
}