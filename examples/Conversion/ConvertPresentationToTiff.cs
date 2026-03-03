using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ConvertToTiff
{
    class Program
    {
        static void Main(string[] args)
        {
            // Convert PPT file to TIFF
            Aspose.Slides.Presentation pptPresentation = new Aspose.Slides.Presentation("sample.ppt");
            pptPresentation.Save("sample_converted.tiff", Aspose.Slides.Export.SaveFormat.Tiff);
            pptPresentation.Dispose();

            // Convert PPTX file to TIFF
            Aspose.Slides.Presentation pptxPresentation = new Aspose.Slides.Presentation("sample.pptx");
            pptxPresentation.Save("sample_converted.pptx.tiff", Aspose.Slides.Export.SaveFormat.Tiff);
            pptxPresentation.Dispose();
        }
    }
}