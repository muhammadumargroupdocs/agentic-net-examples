using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;
using Aspose.Slides.DOM.Ole;

namespace ManageOleObjectLock
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define input and output paths
            string dataDir = "Data";
            if (!Directory.Exists(dataDir))
                Directory.CreateDirectory(dataDir);
            string inputFile = Path.Combine(dataDir, "sample.xlsx");
            string outputFile = Path.Combine(dataDir, "LockedOleObject.pptx");

            // Read the OLE object (Excel) data
            byte[] excelData = File.ReadAllBytes(inputFile);

            // Create a new presentation
            Presentation pres = new Presentation();

            // Get the first slide
            ISlide slide = pres.Slides[0];

            // Prepare embedded data info for the OLE object
            IOleEmbeddedDataInfo dataInfo = new OleEmbeddedDataInfo(excelData, "xlsx");

            // Add the OLE object frame covering the whole slide
            IOleObjectFrame oleFrame = slide.Shapes.AddOleObjectFrame(
                0, 0,
                pres.SlideSize.Size.Width,
                pres.SlideSize.Size.Height,
                dataInfo);

            // Lock the OLE object frame to prevent resizing and repositioning
            oleFrame.GraphicalObjectLock.SizeLocked = true;
            oleFrame.GraphicalObjectLock.PositionLocked = true;

            // Save the presentation
            pres.Save(outputFile, SaveFormat.Pptx);

            // Clean up
            pres.Dispose();
        }
    }
}