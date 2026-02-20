using System;
using Aspose.Slides;

class Program
{
    static void Main()
    {
        // Input and output file paths
        string inputPath = "input.pptx";
        string outputPath = "output.pptx";

        // Load the presentation
        using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
        {
            // Access the first slide
            Aspose.Slides.ISlide slide = presentation.Slides[0];

            // Read slide properties
            string slideName = slide.Name;
            bool isHidden = slide.Hidden;
            int slideNumber = slide.SlideNumber;

            // Modify writable slide properties
            slide.Name = "First Slide Modified";
            slide.Hidden = false;
            slide.SlideNumber = 1;

            // Save the presentation
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}