using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Input PPT file path
        string inputPptPath = "sample.ppt";
        // Input PPTX file path
        string inputPptxPath = "sample.pptx";

        // Output HTML file paths
        string outputHtmlFromPpt = "sample_from_ppt.html";
        string outputHtmlFromPptx = "sample_from_pptx.html";

        // Load PPT presentation and save as HTML
        Aspose.Slides.Presentation presentationFromPpt = new Aspose.Slides.Presentation(inputPptPath);
        presentationFromPpt.Save(outputHtmlFromPpt, Aspose.Slides.Export.SaveFormat.Html);
        presentationFromPpt.Dispose();

        // Load PPTX presentation and save as HTML
        Aspose.Slides.Presentation presentationFromPptx = new Aspose.Slides.Presentation(inputPptxPath);
        presentationFromPptx.Save(outputHtmlFromPptx, Aspose.Slides.Export.SaveFormat.Html);
        presentationFromPptx.Dispose();
    }
}