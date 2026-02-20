using System;

class Program
{
    static void Main(string[] args)
    {
        // Path to the source PPTX file
        string sourcePath = "input.pptx";
        // Path for the output XPS file
        string destPath = "output.xps";

        // Open the existing presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(sourcePath);

        // Save the presentation in XPS format
        presentation.Save(destPath, Aspose.Slides.Export.SaveFormat.Xps);

        // Release resources
        presentation.Dispose();
    }
}