using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Convert PPT to XPS
        string inputPptPath = "example.ppt";
        string outputPptXpsPath = "example_ppt.xps";

        Aspose.Slides.Presentation presPpt = new Aspose.Slides.Presentation(inputPptPath);
        // Save presentation as XPS without additional options
        presPpt.Save(outputPptXpsPath, Aspose.Slides.Export.SaveFormat.Xps);
        presPpt.Dispose();

        // Convert PPTX to XPS
        string inputPptxPath = "example.pptx";
        string outputPptxXpsPath = "example_pptx.xps";

        Aspose.Slides.Presentation presPptx = new Aspose.Slides.Presentation(inputPptxPath);
        // Save presentation as XPS without additional options
        presPptx.Save(outputPptxXpsPath, Aspose.Slides.Export.SaveFormat.Xps);
        presPptx.Dispose();
    }
}