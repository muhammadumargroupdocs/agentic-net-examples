using System;

class Program
{
    static void Main()
    {
        // Input and output file paths
        System.String inputPath = "input.pptx";
        System.String outputPath = "output.pptx";

        // Tag key to be removed
        System.String tagKey = "MyTag";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Access the custom tags collection
        Aspose.Slides.ITagCollection tags = presentation.CustomData.Tags;

        // Remove the tag if it exists
        if (tags.Contains(tagKey))
        {
            tags.Remove(tagKey);
        }

        // Save the modified presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Clean up resources
        presentation.Dispose();
    }
}