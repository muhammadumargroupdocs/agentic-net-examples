using System;

class Program
{
    static void Main(string[] args)
    {
        // Input presentation file path
        System.String inputPath = "input.pptx";
        // Output HTML file path
        System.String outputPath = "output.html";

        // Load the presentation
        using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
        {
            // Save the presentation as HTML
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Html);
        }
    }
}