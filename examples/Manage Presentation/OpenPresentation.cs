using System;

class Program
{
    static void Main()
    {
        // Define source and destination file paths
        System.String srcFile = "input.pptx";
        System.String destFile = "output.pptx";

        // Open the presentation from the source file
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(srcFile);

        // Save the presentation to the destination file in PPTX format
        presentation.Save(destFile, Aspose.Slides.Export.SaveFormat.Pptx);

        // Dispose the presentation object
        presentation.Dispose();
    }
}