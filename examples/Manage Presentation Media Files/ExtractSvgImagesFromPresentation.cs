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
            // Define directories
            string dataDir = "Data";
            if (!Directory.Exists(dataDir))
                Directory.CreateDirectory(dataDir);

            string outputDir = Path.Combine(dataDir, "Output");
            if (!Directory.Exists(outputDir))
                Directory.CreateDirectory(outputDir);

            // Input presentation path
            string inputPath = Path.Combine(dataDir, "input.pptx");

            // Load presentation
            Presentation presentation = new Presentation(inputPath);

            // Iterate through slides and shapes
            int slideNumber = 0;
            foreach (ISlide slide in presentation.Slides)
            {
                int shapeIndex = 0;
                foreach (IShape shape in slide.Shapes)
                {
                    if (shape is IPictureFrame)
                    {
                        IPictureFrame pictureFrame = (IPictureFrame)shape;
                        // Get the embedded image
                        IPPImage ppImage = pictureFrame.PictureFormat.Picture.Image;
                        // Check if the image has an associated SVG representation
                        ISvgImage svgImage = ppImage.SvgImage;
                        if (svgImage != null)
                        {
                            // Retrieve SVG data
                            byte[] svgData = svgImage.SvgData;
                            // Build output file name
                            string svgFileName = $"slide{slideNumber}_shape{shapeIndex}.svg";
                            string svgFilePath = Path.Combine(outputDir, svgFileName);
                            // Write SVG file
                            File.WriteAllBytes(svgFilePath, svgData);
                        }
                    }
                    shapeIndex++;
                }
                slideNumber++;
            }

            // Save presentation (unchanged) before exit
            string outputPresentationPath = Path.Combine(outputDir, "output.pptx");
            presentation.Save(outputPresentationPath, SaveFormat.Pptx);
            presentation.Dispose();
        }
    }
}