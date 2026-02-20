using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Access the tag collection and add a custom tag
        Aspose.Slides.ITagCollection tags = presentation.CustomData.Tags;
        tags["MyTag"] = "My Tag Value";

        // Define output file path
        string outputPath = System.IO.Path.Combine(System.Environment.CurrentDirectory, "TaggedPresentation.pptx");

        // Save the presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Clean up resources
        presentation.Dispose();
    }
}