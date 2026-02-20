using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input and output file paths
        string inputPath = "source.pptx";
        string outputPath = "result.pptx";

        // Load source presentation
        Aspose.Slides.Presentation srcPres = new Aspose.Slides.Presentation(inputPath);

        // Create destination presentation (starts with one empty slide)
        Aspose.Slides.Presentation destPres = new Aspose.Slides.Presentation();

        // Insert a clone of the first slide from source into position 1 of destination
        destPres.Slides.InsertClone(1, srcPres.Slides[0]);

        // Save the modified presentation
        destPres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Clean up resources
        srcPres.Dispose();
        destPres.Dispose();
    }
}