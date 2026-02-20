using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace AsposeSlidesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define output directory
            string outputDir = Path.Combine(Environment.CurrentDirectory, "Output");
            if (!Directory.Exists(outputDir))
                Directory.CreateDirectory(outputDir);

            // Paths for source and destination presentations
            string sourcePath = Path.Combine(outputDir, "source.pptx");
            string outputPath = Path.Combine(outputDir, "result.pptx");

            // Load the source presentation
            Presentation srcPres = new Presentation(sourcePath);

            // Create a new destination presentation
            Presentation destPres = new Presentation();

            // Get the first slide from the source presentation
            ISlide sourceSlide = srcPres.Slides[0];

            // Get the master slide of the source slide's layout
            IMasterSlide sourceMaster = sourceSlide.LayoutSlide.MasterSlide;

            // Clone the master slide into the destination presentation
            IMasterSlide destMaster = destPres.Masters.AddClone(sourceMaster);

            // Clone the source slide into the destination presentation using the cloned master
            destPres.Slides.AddClone(sourceSlide, destMaster, true);

            // Save the destination presentation
            destPres.Save(outputPath, SaveFormat.Pptx);

            // Clean up resources
            srcPres.Dispose();
            destPres.Dispose();
        }
    }
}