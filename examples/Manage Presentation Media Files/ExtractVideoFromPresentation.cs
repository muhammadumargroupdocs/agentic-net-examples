using System;
using System.IO;
using Aspose.Slides;

class Program
{
    static void Main()
    {
        // Input presentation file path
        string inputPath = "input.pptx";
        // Directory to save extracted videos
        string outputDir = "ExtractedVideos";

        // Create output directory if it does not exist
        System.IO.Directory.CreateDirectory(outputDir);

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);
        try
        {
            int videoIndex = 0;
            // Iterate through all slides
            foreach (Aspose.Slides.ISlide slide in presentation.Slides)
            {
                // Iterate through all shapes on the slide
                foreach (Aspose.Slides.IShape shape in slide.Shapes)
                {
                    // Check if the shape is a video frame
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
                        string outPath = System.IO.Path.Combine(outputDir, $"video_{videoIndex}.{extension}");
                        // Write video data to file
                        System.IO.FileStream fs = new System.IO.FileStream(outPath, System.IO.FileMode.Create, System.IO.FileAccess.Write, System.IO.FileShare.Read);
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
            // Save the presentation before exiting (optional)
            presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
            // Dispose the presentation to release resources
            presentation.Dispose();
        }
    }
}