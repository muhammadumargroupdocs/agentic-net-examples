using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ExtractSvgFromPictureFrames
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input PPTX file path
            string inputFilePath = "input.pptx";
            // Output directory for extracted SVG files
            string outputDirectory = "ExtractedSvgs";

            // Ensure output directory exists
            if (!Directory.Exists(outputDirectory))
            {
                Directory.CreateDirectory(outputDirectory);
            }

            // Load presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputFilePath);

            // Counter for naming extracted SVG files
            int svgIndex = 0;

            // Iterate through all slides
            foreach (Aspose.Slides.ISlide slide in presentation.Slides)
            {
                // Iterate through all shapes on the slide
                foreach (Aspose.Slides.IShape shape in slide.Shapes)
                {
                    // Check if the shape is a picture frame
                    if (shape is Aspose.Slides.IPictureFrame)
                    {
                        Aspose.Slides.IPictureFrame pictureFrame = (Aspose.Slides.IPictureFrame)shape;
                        // Get the embedded image
                        Aspose.Slides.IPPImage embeddedImage = pictureFrame.PictureFormat.Picture.Image;

                        // Check if the image has an associated SVG representation
                        if (embeddedImage.SvgImage != null)
                        {
                            Aspose.Slides.ISvgImage svgImage = embeddedImage.SvgImage;
                            byte[] svgData = svgImage.SvgData;

                            // Save SVG data to file
                            string svgFilePath = Path.Combine(outputDirectory, $"image_{svgIndex}.svg");
                            File.WriteAllBytes(svgFilePath, svgData);
                            svgIndex++;
                        }
                    }
                }
            }

            // Save the presentation (optional, as per requirement)
            string outputPresentationPath = "output.pptx";
            presentation.Save(outputPresentationPath, Aspose.Slides.Export.SaveFormat.Pptx);

            // Dispose presentation
            presentation.Dispose();
        }
    }
}