using System;
using Aspose.Slides;
using Aspose.Slides.DOM.Ole;
using Aspose.Slides.Export;

namespace OLEObjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path to the source Excel file to embed
            string inputPath = "sample.xlsx";
            // Path where the resulting PPTX will be saved
            string outputPath = "output.pptx";

            // Create a new presentation
            Presentation pres = new Presentation();

            // Get the first slide
            ISlide slide = pres.Slides[0];

            // Read the Excel file bytes
            byte[] excelData = System.IO.File.ReadAllBytes(inputPath);

            // Create OLE embedded data info (file data and extension)
            IOleEmbeddedDataInfo dataInfo = new OleEmbeddedDataInfo(excelData, "xlsx");

            // Add OLE object frame covering the whole slide
            IOleObjectFrame oleFrame = slide.Shapes.AddOleObjectFrame(
                0, 0,
                pres.SlideSize.Size.Width,
                pres.SlideSize.Size.Height,
                dataInfo);

            // Save the presentation in PPTX format
            pres.Save(outputPath, SaveFormat.Pptx);
        }
    }
}