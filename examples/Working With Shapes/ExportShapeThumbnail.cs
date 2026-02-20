using System;

class Program
{
    static void Main()
    {
        // Scale factors for thumbnail generation
        int scaleX = 2;
        int scaleY = scaleX;

        // Path to the source presentation
        System.String inputPath = "input.pptx";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Export each slide as a JPEG thumbnail
        foreach (Aspose.Slides.ISlide slide in presentation.Slides)
        {
            // Get thumbnail image with custom scaling
            using (Aspose.Slides.IImage thumbnail = slide.GetImage(scaleX, scaleY))
            {
                // Build output file name using slide number
                System.String imageFileName = System.String.Format("slide_{0}.jpg", slide.SlideNumber);
                // Save thumbnail as JPEG
                thumbnail.Save(imageFileName, Aspose.Slides.ImageFormat.Jpeg);
            }
        }

        // Save the (unchanged) presentation before exiting
        presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        presentation.Dispose();
    }
}