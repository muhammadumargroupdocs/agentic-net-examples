using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Define input PPTX file and output PPT file paths
        string inputPath = "input.pptx";
        string outputPath = "output.ppt";

        // Load the source presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Handout layout (multiple slides per page) is not supported for PPT format.
        // Therefore we use default PPT save options without setting SlidesLayoutOptions.
        Aspose.Slides.Export.PptOptions pptOptions = new Aspose.Slides.Export.PptOptions();

        // Save the presentation as PPT
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Ppt, pptOptions);

        // Release resources
        presentation.Dispose();
    }
}