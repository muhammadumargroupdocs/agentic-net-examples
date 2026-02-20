using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace AsposeSlidesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define data directory
            string dataDir = "Data";
            if (!Directory.Exists(dataDir))
                Directory.CreateDirectory(dataDir);

            // Path to the image file
            string imagePath = Path.Combine(dataDir, "image.jpg");

            // Create a new presentation
            Presentation pres = new Presentation();

            // Get the first slide
            ISlide slide = pres.Slides[0];

            // Load image and add to presentation's image collection
            IImage img = Images.FromFile(imagePath);
            IPPImage imgx = pres.Images.AddImage(img);

            // Set slide background to the image
            slide.Background.Type = BackgroundType.OwnBackground;
            slide.Background.FillFormat.FillType = FillType.Picture;
            slide.Background.FillFormat.PictureFillFormat.Picture.Image = imgx;

            // Save the presentation
            string outPath = Path.Combine(dataDir, "output.pptx");
            pres.Save(outPath, SaveFormat.Pptx);

            // Dispose the presentation
            pres.Dispose();
        }
    }
}