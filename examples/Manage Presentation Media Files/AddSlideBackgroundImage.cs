using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace SlideBackgroundExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input image file path
            string inputImagePath = "image.jpg";
            // Output presentation file path
            string outputPath = "output.pptx";

            // Read image data into a byte array
            byte[] imageData = File.ReadAllBytes(inputImagePath);

            // Create a new presentation
            Presentation pres = new Presentation();

            // Add the image to the presentation's image collection
            IPPImage img = pres.Images.AddImage(imageData);

            // Get the first slide (presentation is created with one empty slide)
            ISlide slide = pres.Slides[0];

            // Set the slide background to use the added image
            slide.Background.Type = BackgroundType.OwnBackground;
            slide.Background.FillFormat.FillType = FillType.Picture;
            slide.Background.FillFormat.PictureFillFormat.Picture.Image = img;

            // Save the presentation
            pres.Save(outputPath, SaveFormat.Pptx);

            // Clean up
            pres.Dispose();
        }
    }
}