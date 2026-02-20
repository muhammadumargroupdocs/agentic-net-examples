using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Define output directory
        string outputDir = Path.Combine(Environment.CurrentDirectory, "Output");
        if (!Directory.Exists(outputDir))
            Directory.CreateDirectory(outputDir);

        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Get slide collection
        Aspose.Slides.ISlideCollection slideColl = pres.Slides;

        // Add an empty slide using each layout slide (adds at least one new slide)
        for (Int32 i = 0; i < pres.LayoutSlides.Count; i++)
        {
            slideColl.AddEmptySlide(pres.LayoutSlides[i]);
        }

        // Save the presentation
        string outPath = Path.Combine(outputDir, "result.pptx");
        pres.Save(outPath, Aspose.Slides.Export.SaveFormat.Pptx);
        pres.Dispose();
    }
}