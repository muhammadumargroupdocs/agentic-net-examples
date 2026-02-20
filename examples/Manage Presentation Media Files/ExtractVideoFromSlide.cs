using System;
using System.IO;
using Aspose.Slides;

class Program
{
    static void Main()
    {
        // Input presentation path
        string inputPath = "input.pptx";
        // Output directory for extracted videos
        string outputDir = "output_videos";
        // Ensure output directory exists
        Directory.CreateDirectory(outputDir);
        // Load presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);
        try
        {
            int videoIndex = 0;
            // Iterate through slides and shapes to find video frames
            foreach (Aspose.Slides.ISlide slide in presentation.Slides)
            {
                foreach (Aspose.Slides.IShape shape in slide.Shapes)
                {
                    if (shape is Aspose.Slides.VideoFrame)
                    {
                        Aspose.Slides.IVideoFrame vf = (Aspose.Slides.IVideoFrame)shape;
                        // Determine video file extension from content type
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
            // Save presentation before exiting (optional, as no changes are made)
            presentation.Save(inputPath, Aspose.Slides.Export.SaveFormat.Pptx);
            presentation.Dispose();
        }
    }
}