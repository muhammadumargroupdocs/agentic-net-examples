using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Input presentation path
        string inputPath = "input.pptx";
        // Output directory for extracted videos
        string outputDir = "ExtractedVideos";

        // Create output directory if it does not exist
        Directory.CreateDirectory(outputDir);

        // Load presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);
        try
        {
            int videoIndex = 0;
            // Iterate through slides
            foreach (Aspose.Slides.ISlide slide in presentation.Slides)
            {
                // Iterate through shapes on the slide
                foreach (Aspose.Slides.IShape shape in slide.Shapes)
                {
                    // Check if the shape is a video frame
                    if (shape is Aspose.Slides.VideoFrame)
                    {
                        Aspose.Slides.IVideoFrame vf = (Aspose.Slides.IVideoFrame)shape;
                        // Get content type to determine file extension
                        string contentType = vf.EmbeddedVideo.ContentType;
                        int slashPos = contentType.LastIndexOf('/');
                        string extension = contentType.Substring(slashPos + 1);
                        // Get video binary data
                        byte[] data = vf.EmbeddedVideo.BinaryData;
                        // Build output file path
                        string outPath = Path.Combine(outputDir, $"video_{videoIndex}.{extension}");
                        // Write video data to file
                        FileStream fs = new FileStream(outPath, FileMode.Create, FileAccess.Write, FileShare.Read);
                        try
                        {
                            fs.Write(data, 0, data.Length);
                        }
                        finally
                        {
                            fs.Dispose();
                        }
                        videoIndex++;
                    }
                }
            }
        }
        finally
        {
            // Save presentation before exiting (optional, can save to a new file)
            presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
            presentation.Dispose();
        }
    }
}