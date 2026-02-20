using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ExtractOleEmbeddedFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input PPT file path
            string inputPath = "input.ppt";
            // Directory to save extracted embedded files
            string outputDir = "ExtractedFiles";
            // Output PPT file path (saved after extraction)
            string outputPath = "output.ppt";

            // Ensure the output directory exists
            if (!Directory.Exists(outputDir))
                Directory.CreateDirectory(outputDir);

            // Load the presentation
            Presentation presentation = new Presentation(inputPath);

            // Index for naming extracted files
            int fileIndex = 0;

            // Iterate through slides and shapes to find OLE object frames
            foreach (ISlide slide in presentation.Slides)
            {
                foreach (IShape shape in slide.Shapes)
                {
                    if (shape is OleObjectFrame)
                    {
                        OleObjectFrame oleFrame = shape as OleObjectFrame;
                        byte[] fileData = oleFrame.EmbeddedData.EmbeddedFileData;
                        string fileExtension = oleFrame.EmbeddedData.EmbeddedFileExtension;
                        string outFilePath = Path.Combine(outputDir, "embedded_" + fileIndex + fileExtension);

                        // Write the embedded file data to disk
                        using (FileStream fs = new FileStream(outFilePath, FileMode.Create, FileAccess.Write, FileShare.Read))
                        {
                            fs.Write(fileData, 0, fileData.Length);
                        }

                        fileIndex++;
                    }
                }
            }

            // Save the presentation before exiting
            presentation.Save(outputPath, SaveFormat.Ppt);
            presentation.Dispose();
        }
    }
}