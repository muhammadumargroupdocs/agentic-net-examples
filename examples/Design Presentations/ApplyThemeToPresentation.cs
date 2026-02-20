using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ThemeApplicationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define paths
            System.String dataDir = "C:\\Data\\";
            System.String inputPath = dataDir + "input.pptx";
            System.String outputPath = dataDir + "output.pptx";

            // Load existing presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Apply a built‑in theme by setting the master theme name
            // (e.g., "Office" is a built‑in theme name)
            presentation.MasterTheme.Name = "Office";

            // Save the modified presentation
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

            // Dispose the presentation object
            presentation.Dispose();
        }
    }
}