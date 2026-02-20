using System;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Define input and output file paths
        string inputPath = "input.pptx";
        string outputPath = "output.pptx";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Set a custom slide size (width: 960 points, height: 540 points) and ensure content fits
        presentation.SlideSize.SetSize(960f, 540f, Aspose.Slides.SlideSizeScaleType.EnsureFit);

        // Set a predefined slide size (A4 paper) and maximize content scaling
        presentation.SlideSize.SetSize(Aspose.Slides.SlideSizeType.A4Paper, Aspose.Slides.SlideSizeScaleType.Maximize);

        // Save the modified presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}