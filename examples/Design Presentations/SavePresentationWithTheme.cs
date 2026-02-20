using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Define output file path
        string outputPath = "DesignPresentationWithTheme.pptx";

        // Save the presentation as PPTX
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}