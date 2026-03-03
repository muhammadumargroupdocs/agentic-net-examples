using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Path to the source PPTX file
        string inputFile = "input.pptx";
        // Path for the resulting PPT file
        string outputFile = "output.ppt";

        // Load the PPTX presentation
        using (Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputFile))
        {
            // Create PPT save options (default settings)
            Aspose.Slides.Export.PptOptions pptOptions = new Aspose.Slides.Export.PptOptions();

            // Save the presentation in PPT format (handout mode is inherent to PPT)
            pres.Save(outputFile, Aspose.Slides.Export.SaveFormat.Ppt, pptOptions);
        }
    }
}