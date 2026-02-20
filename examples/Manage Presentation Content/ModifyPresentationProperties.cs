using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Define input and output file paths
        System.String inputPath = "input.pptx";
        System.String outputPath = "output.pptx";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Access built‑in document properties
        Aspose.Slides.IDocumentProperties documentProperties = presentation.DocumentProperties;

        // Modify built‑in properties
        documentProperties.Author = "John Doe";
        documentProperties.Title = "Sample Presentation";
        documentProperties.Subject = "Demo";
        documentProperties.Comments = "Created with Aspose.Slides";
        documentProperties.Manager = "Jane Smith";

        // Save the updated presentation in PPT format
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Clean up resources
        presentation.Dispose();
    }
}