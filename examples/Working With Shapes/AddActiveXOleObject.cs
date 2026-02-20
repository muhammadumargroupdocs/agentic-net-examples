using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;
using Aspose.Slides.DOM.Ole;

namespace AsposeSlidesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define input and output paths
            string dataDirectory = Path.GetFullPath("Data");
            string outputPath = Path.Combine(dataDirectory, "ActiveX_OLE.pptx");

            // Ensure the output directory exists
            string outputDir = Path.GetDirectoryName(outputPath);
            if (!Directory.Exists(outputDir))
            {
                Directory.CreateDirectory(outputDir);
            }

            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Get the first slide
            Aspose.Slides.ISlide slide = presentation.Slides[0];

            // Load the OLE object data (e.g., an Excel file)
            string excelFilePath = Path.Combine(dataDirectory, "sample.xlsx");
            byte[] excelData = File.ReadAllBytes(excelFilePath);
            Aspose.Slides.IOleEmbeddedDataInfo oleDataInfo = new OleEmbeddedDataInfo(excelData, "xlsx");

            // Add an OLE object frame to the slide
            Aspose.Slides.IOleObjectFrame oleObjectFrame = slide.Shapes.AddOleObjectFrame(50, 50, 400, 300, oleDataInfo);

            // Optionally configure the OLE object (e.g., display as icon)
            oleObjectFrame.IsObjectIcon = true;
            oleObjectFrame.SubstitutePictureTitle = "Excel Data";

            // Save the presentation
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

            // Dispose the presentation
            presentation.Dispose();
        }
    }
}