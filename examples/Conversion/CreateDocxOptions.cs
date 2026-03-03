using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Define input and output file paths
        string inputPath = "sample.pptx";
        string outputPath = "output.pptx";

        // Load the PPTX presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Create PPTX save options using the factory
        Aspose.Slides.Export.SaveOptionsFactory optionsFactory = new Aspose.Slides.Export.SaveOptionsFactory();
        Aspose.Slides.Export.IPptxOptions pptxOptions = optionsFactory.CreatePptxOptions();

        // Example: set the ZIP64 mode to always
        pptxOptions.Zip64Mode = Aspose.Slides.Export.Zip64Mode.Always;

        // Save the presentation with the specified options
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx, pptxOptions);

        // Release resources
        presentation.Dispose();
    }
}