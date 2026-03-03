using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Input PPTX file path
        string inputPath = "input.pptx";
        // Output PPT file path
        string outputPath = "output.ppt";

        // Load the PPTX presentation
        using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
        {
            // Save the presentation in PPT format
            presentation.Save(outputPath, SaveFormat.Ppt);
        }
    }
}