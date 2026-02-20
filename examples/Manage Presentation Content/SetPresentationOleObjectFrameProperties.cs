using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Define input and output file paths
        string dataDir = Path.GetFullPath("Data");
        string inputPath = Path.Combine(dataDir, "input.pptx");
        string outputPath = Path.Combine(dataDir, "output.pptx");

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Access the first slide and its first shape
        Aspose.Slides.ISlide slide = presentation.Slides[0];
        Aspose.Slides.IShape shape = slide.Shapes[0];
        Aspose.Slides.OleObjectFrame oleFrame = shape as Aspose.Slides.OleObjectFrame;

        if (oleFrame != null)
        {
            // Modify writable OLE object properties
            oleFrame.IsObjectIcon = true;                         // Show as icon
            oleFrame.LinkPathLong = @"C:\LinkedFiles\NewFile.docx"; // Update linked file path
            oleFrame.ObjectName = "UpdatedOLEObject";             // Change object name
            oleFrame.UpdateAutomatic = false;                     // Disable automatic update
        }

        // Save the modified presentation in PPTX format
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        presentation.Dispose();
    }
}