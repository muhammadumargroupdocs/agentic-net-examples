using System;

class Program
{
    static void Main()
    {
        // Input and output PPT file paths
        var inputPath = "input.ppt";
        var outputPath = "output.ppt";

        // Load the presentation from the input file
        var presentation = new Aspose.Slides.Presentation(inputPath);

        // Access the built‑in document properties
        var properties = presentation.DocumentProperties;

        // Set some built‑in properties
        properties.Author = "John Doe";
        properties.Title = "Sample Presentation";
        properties.Subject = "Demo";
        properties.Keywords = "Aspose, Slides, Example";

        // Save the modified presentation in PPT format
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Ppt);
    }
}