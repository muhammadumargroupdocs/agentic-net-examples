using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace AsposeSlidesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input and output file paths
            string inputPath = "input.pptx";
            string outputPath = "output.ppt";

            // Load options with DeleteEmbeddedBinaryObjects enabled
            Aspose.Slides.LoadOptions loadOptions = new Aspose.Slides.LoadOptions();
            loadOptions.DeleteEmbeddedBinaryObjects = true;

            // Load presentation with the specified options
            Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath, loadOptions);

            // Count OLE object frames before saving
            int oleFramesCount;
            int emptyOleFrames;
            oleFramesCount = GetOleObjectFrameCount(pres.Slides, out emptyOleFrames);
            Console.WriteLine($"OLE frames before save: {oleFramesCount}, empty frames: {emptyOleFrames}");

            // Save presentation in PPT format
            pres.Save(outputPath, SaveFormat.Ppt);

            // Load the saved presentation to verify counts after deletion
            Aspose.Slides.Presentation outPres = new Aspose.Slides.Presentation(outputPath);
            oleFramesCount = GetOleObjectFrameCount(outPres.Slides, out emptyOleFrames);
            Console.WriteLine($"OLE frames after save: {oleFramesCount}, empty frames: {emptyOleFrames}");

            // Dispose presentations
            pres.Dispose();
            outPres.Dispose();
        }

        // Helper method to count OLE object frames and empty frames
        private static int GetOleObjectFrameCount(ISlideCollection slides, out int emptyOleFrames)
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
                        emptyOleFrames++;
                }
            }

            return oleFramesCount;
        }
    }
}