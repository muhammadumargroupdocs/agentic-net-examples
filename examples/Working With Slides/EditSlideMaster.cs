using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace SlideMasterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define paths
            string dataDir = Path.Combine(Environment.CurrentDirectory, "Data");
            string sourcePath = Path.Combine(dataDir, "source.pptx");
            string outputPath = Path.Combine(dataDir, "cloned_with_master.pptx");

            // Load source presentation
            Presentation srcPres = new Presentation(sourcePath);

            // Create destination presentation
            Presentation destPres = new Presentation();

            // Get first slide from source
            ISlide sourceSlide = srcPres.Slides[0];

            // Get the master slide of the source slide's layout
            IMasterSlide sourceMaster = sourceSlide.LayoutSlide.MasterSlide;

            // Clone the master slide into the destination presentation
            IMasterSlide destMaster = destPres.Masters.AddClone(sourceMaster);

            // Clone the source slide into the destination presentation using the cloned master
            destPres.Slides.AddClone(sourceSlide, destMaster, true);

            // Save the destination presentation
            destPres.Save(outputPath, SaveFormat.Pptx);
        }
    }
}