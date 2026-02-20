using System;
using Aspose.Slides;

class Program
{
    static void Main()
    {
        // Input and output file paths
        System.String inputPath = "input.pptx";
        System.String outputPath = "output.pptx";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Remove the first slide (index 0)
        presentation.Slides.RemoveAt(0);

        // Save the modified presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Clean up resources
        presentation.Dispose();
    }
}