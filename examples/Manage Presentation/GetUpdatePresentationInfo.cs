using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input and output file paths
        string inputPath = "input.pptx";
        string outputPath = "output.pptx";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Retrieve document properties
        Aspose.Slides.IDocumentProperties properties = presentation.DocumentProperties;

        // Display current properties
        Console.WriteLine("Current Author: " + properties.Author);
        Console.WriteLine("Current Title: " + properties.Title);

        // Update properties
        properties.Author = "New Author";
        properties.Title = "New Title";

        // Save the updated presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}