using System;
using System.IO;

namespace ExtractPictureFrameImages
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input PPTX file path
            string inputFilePath = "input.pptx";

            // Output directory for extracted images and saved presentation
            string outputDir = "ExtractedImages";

            // Ensure the output directory exists
            if (!System.IO.Directory.Exists(outputDir))
            {
                System.IO.Directory.CreateDirectory(outputDir);
            }

            // Load the presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputFilePath);

            // Iterate through all slides
            for (int slideIndex = 0; slideIndex < presentation.Slides.Count; slideIndex++)
            {
                Aspose.Slides.ISlide slide = presentation.Slides[slideIndex];

                // Iterate through all shapes on the slide
                for (int shapeIndex = 0; shapeIndex < slide.Shapes.Count; shapeIndex++)
                {
                    Aspose.Slides.IShape shape = slide.Shapes[shapeIndex];

                    // Check if the shape is a picture frame
                    if (shape is Aspose.Slides.IPictureFrame)
                    {
                        Aspose.Slides.IPictureFrame pictureFrame = (Aspose.Slides.IPictureFrame)shape;

                        // Get the embedded image (IPPImage)
                        Aspose.Slides.IPPImage ippImage = pictureFrame.PictureFormat.Picture.Image;

                        // Retrieve the binary data of the image
                        byte[] imageData = ippImage.BinaryData;

                        // Determine a file extension based on the content type (default to .png)
                        string fileExtension = ".png";
                        string contentType = ippImage.ContentType;
                        if (!string.IsNullOrEmpty(contentType))
                        {
                            if (contentType.Contains("jpeg"))
                                fileExtension = ".jpg";
                            else if (contentType.Contains("gif"))
                                fileExtension = ".gif";
                            else if (contentType.Contains("bmp"))
                                fileExtension = ".bmp";
                            else if (contentType.Contains("tiff"))
                                fileExtension = ".tiff";
                        }

                        // Build a unique file name for each extracted image
                        string imageFileName = $"slide_{slideIndex + 1}_shape_{shapeIndex + 1}{fileExtension}";
                        string imageFilePath = System.IO.Path.Combine(outputDir, imageFileName);

                        // Save the image data to the file system
                        System.IO.File.WriteAllBytes(imageFilePath, imageData);
                    }
                }
            }

            // Save the (potentially unchanged) presentation before exiting
            string savedPresentationPath = System.IO.Path.Combine(outputDir, "output.pptx");
            presentation.Save(savedPresentationPath, Aspose.Slides.Export.SaveFormat.Pptx);

            // Dispose the presentation object
            presentation.Dispose();
        }
    }
}