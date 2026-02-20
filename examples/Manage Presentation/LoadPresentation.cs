using System;

class Program
{
    static void Main()
    {
        // Input and output file paths
        string inputPath = "input.pptx";
        string outputPath = "output_no_embedded.pptx";

        // Load options with embedded binary objects deletion enabled
        Aspose.Slides.LoadOptions loadOptions = new Aspose.Slides.LoadOptions();
        loadOptions.DeleteEmbeddedBinaryObjects = true;

        // Load presentation using the specified load options
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath, loadOptions);

        // Count OLE object frames before saving
        int oleFramesCount;
        int emptyOleFrames;
        oleFramesCount = GetOleObjectFrameCount(pres.Slides, out emptyOleFrames);
        Console.WriteLine("OLE frames before save: " + oleFramesCount + ", empty: " + emptyOleFrames);

        // Save the presentation (embedded objects are removed)
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Load the saved presentation to verify removal
        Aspose.Slides.Presentation outPres = new Aspose.Slides.Presentation(outputPath);
        oleFramesCount = GetOleObjectFrameCount(outPres.Slides, out emptyOleFrames);
        Console.WriteLine("OLE frames after save: " + oleFramesCount + ", empty: " + emptyOleFrames);

        // Clean up resources
        pres.Dispose();
        outPres.Dispose();
    }

    // Helper method to count OLE object frames and those without embedded data
    static int GetOleObjectFrameCount(Aspose.Slides.ISlideCollection slides, out int emptyOleFrames)
    {
        int oleFramesCount = 0;
        emptyOleFrames = 0;
        foreach (Aspose.Slides.ISlide slide in slides)
        {
            foreach (Aspose.Slides.IShape shape in slide.Shapes)
            {
                Aspose.Slides.OleObjectFrame oleFrame = shape as Aspose.Slides.OleObjectFrame;
                if (oleFrame == null)
                    continue;
                oleFramesCount++;
                byte[] embeddedData = oleFrame.EmbeddedData.EmbeddedFileData;
                if (embeddedData == null || embeddedData.Length == 0)
                {
                    emptyOleFrames++;
                }
            }
        }
        return oleFramesCount;
    }
}