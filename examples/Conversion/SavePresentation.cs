using System;

class Program
{
    static void Main(string[] args)
    {
        // Path to the source PPTX file
        string sourcePath = "input.pptx";
        // Path to the destination PPT file
        string outputPath = "output.ppt";

        // Load the PPTX presentation
        using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(sourcePath))
        {
            // Create PPT save options
            Aspose.Slides.Export.PptOptions pptOptions = new Aspose.Slides.Export.PptOptions();

            // Save the presentation in PPT format
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Ppt, pptOptions);
        }
    }
}