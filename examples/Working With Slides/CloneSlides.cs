using System;

class Program
{
    static void Main()
    {
        // Paths to source and destination presentations
        string sourcePath = "source.pptx";
        string destinationPath = "target.pptx";

        // Load source presentation
        Aspose.Slides.Presentation srcPres = new Aspose.Slides.Presentation(sourcePath);
        // Create empty destination presentation
        Aspose.Slides.Presentation destPres = new Aspose.Slides.Presentation();

        // Get first slide from source
        Aspose.Slides.ISlide sourceSlide = srcPres.Slides[0];
        // Get master slide associated with the source slide
        Aspose.Slides.IMasterSlide sourceMaster = sourceSlide.LayoutSlide.MasterSlide;
        // Clone the master slide into destination presentation
        Aspose.Slides.IMasterSlide destMaster = destPres.Masters.AddClone(sourceMaster);
        // Clone the source slide into destination using the cloned master
        destPres.Slides.AddClone(sourceSlide, destMaster, true);

        // Save the destination presentation
        destPres.Save(destinationPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Clean up
        srcPres.Dispose();
        destPres.Dispose();
    }
}