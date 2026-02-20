using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace OleObjectExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input and output file paths
            string inputPath = "input.ppt";
            string outputPath = "output.ppt";

            // Load the presentation
            Presentation pres = new Presentation(inputPath);

            // Access the first slide and first shape
            ISlide slide = pres.Slides[0];
            IShape shape = slide.Shapes[0];

            // Cast the shape to OleObjectFrame
            OleObjectFrame oleFrame = shape as OleObjectFrame;
            if (oleFrame != null)
            {
                // Extract embedded OLE object data
                byte[] data = oleFrame.EmbeddedData.EmbeddedFileData;
                string ext = oleFrame.EmbeddedData.EmbeddedFileExtension;
                string outFile = Path.Combine(Directory.GetCurrentDirectory(), "extracted" + ext);

                // Write the extracted data to a file
                using (FileStream fs = new FileStream(outFile, FileMode.Create, FileAccess.Write, FileShare.Read))
                {
                    fs.Write(data, 0, data.Length);
                }
            }

            // Save the presentation in PPT format
            pres.Save(outputPath, SaveFormat.Ppt);

            // Dispose the presentation
            pres.Dispose();
        }
    }
}