using System;

namespace SlideCloneExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path to the source presentation
            string sourcePath = "source.pptx";
            // Path to the destination presentation
            string outputPath = "result.pptx";
            // Index of the slide to clone from source (0‑based)
            int sourceSlideIndex = 0;
            // Position in the destination where the slide will be inserted (0‑based)
            int insertPosition = 0;

            // Load the source presentation
            Aspose.Slides.Presentation srcPres = new Aspose.Slides.Presentation(sourcePath);
            // Create a new empty destination presentation
            Aspose.Slides.Presentation destPres = new Aspose.Slides.Presentation();

            // Insert a clone of the specified slide into the destination presentation
            destPres.Slides.InsertClone(insertPosition, srcPres.Slides[sourceSlideIndex]);

            // Save the resulting presentation
            destPres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

            // Clean up resources
            srcPres.Dispose();
            destPres.Dispose();
        }
    }
}