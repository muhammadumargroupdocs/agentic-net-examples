using System;
using System.IO;
using System.Drawing.Imaging;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ConvertPresentationToPng
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input PowerPoint file
            System.String inputPath = "input.pptx";
            // Folder to store PNG images
            System.String outputFolder = "output_images";
            // Ensure the output directory exists
            Directory.CreateDirectory(outputFolder);

            // Load the presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Desired image dimensions
            System.Int32 desiredX = 1200;
            System.Int32 desiredY = 800;

            // Calculate scaling factors based on slide size
            System.Single scaleX = (System.Single)(1.0 / presentation.SlideSize.Size.Width) * desiredX;
            System.Single scaleY = (System.Single)(1.0 / presentation.SlideSize.Size.Height) * desiredY;

            // Iterate through each slide and save as PNG with custom size
            for (System.Int32 i = 0; i < presentation.Slides.Count; i++)
            {
                Aspose.Slides.ISlide slide = presentation.Slides[i];
                Aspose.Slides.IImage image = slide.GetImage(scaleX, scaleY);
                System.String imagePath = Path.Combine(outputFolder, System.String.Format("Slide_{0}.png", slide.SlideNumber));
                image.Save(imagePath, ImageFormat.Png);
                image.Dispose();
            }

            // Save the presentation (required by authoring rules)
            presentation.Save("output.pptx", SaveFormat.Pptx);
            presentation.Dispose();
        }
    }
}