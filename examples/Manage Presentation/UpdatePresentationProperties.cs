using System;

class Program
{
    static void Main()
    {
        // Define the input and output file paths
        string inputPath = "input.pptx";
        string outputPath = "output.pptx";

        // Load the presentation from the input file
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Access the document properties of the presentation
        Aspose.Slides.IDocumentProperties properties = presentation.DocumentProperties;

        // Update various built‑in properties
        properties.Author = "John Doe";
        properties.Title = "Sample Presentation";
        properties.Subject = "Demo";
        properties.Comments = "Updated using Aspose.Slides";
        properties.Manager = "Jane Smith";

        // Save the modified presentation to the output file
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}