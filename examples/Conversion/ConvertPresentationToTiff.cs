using System;

class Program
{
    static void Main()
    {
        // Path to the source presentation
        System.String inputPath = "input.pptx";
        // Path for the output TIFF file
        System.String outputPath = "output.tiff";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Save the presentation as a multi-page TIFF image
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Tiff);

        // Release resources
        presentation.Dispose();
    }
}