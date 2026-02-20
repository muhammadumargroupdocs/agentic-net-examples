using System;

class Program
{
    static void Main()
    {
        // Paths to the source, destination, and output PPTX files
        string sourcePath = "source.pptx";
        string destinationPath = "destination.pptx";
        string outputPath = "merged.pptx";

        // Load the source and destination presentations
        Aspose.Slides.Presentation srcPres = new Aspose.Slides.Presentation(sourcePath);
        Aspose.Slides.Presentation destPres = new Aspose.Slides.Presentation(destinationPath);

        // Clone the first slide from the source presentation to the destination presentation
        Aspose.Slides.ISlide sourceSlide = srcPres.Slides[0];
        Aspose.Slides.IMasterSlide sourceMaster = sourceSlide.LayoutSlide.MasterSlide;
        Aspose.Slides.IMasterSlide destMaster = destPres.Masters.AddClone(sourceMaster);
        destPres.Slides.AddClone(sourceSlide, destMaster, true);

        // Save the updated destination presentation
        destPres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Clean up resources
        srcPres.Dispose();
        destPres.Dispose();
    }
}