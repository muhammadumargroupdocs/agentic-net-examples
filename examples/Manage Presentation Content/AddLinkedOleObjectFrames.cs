using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;
using Aspose.Slides.DOM.Ole;

class Program
{
    static void Main()
    {
        // Output directory
        string outDir = "Output";
        if (!Directory.Exists(outDir))
            Directory.CreateDirectory(outDir);

        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Path to the external file to link (adjust as needed)
        string linkedFilePath = Path.GetFullPath("sample.xlsx");
        // ProgId for the linked OLE object (Excel in this case)
        string progId = "Excel.Sheet.12";

        // Add a linked OLE object frame to the slide
        Aspose.Slides.IOleObjectFrame oleObject = slide.Shapes.AddOleObjectFrame(50, 50, 400, 300, linkedFilePath, progId);

        // Optionally display the OLE object as an icon
        oleObject.IsObjectIcon = true;

        // Save the presentation in PPT format
        presentation.Save(Path.Combine(outDir, "LinkedOleObject.ppt"), SaveFormat.Ppt);

        // Dispose the presentation
        presentation.Dispose();
    }
}