using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;
using Aspose.Slides.Effects;

class Program
{
    static void Main()
    {
        // Input and output file paths
        string inputPath = "input.pptx";
        string outputPath = "output.pptx";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Find the first picture shape on the slide
        Aspose.Slides.IPictureFrame pictureFrame = null;
        for (int i = 0; i < slide.Shapes.Count; i++)
        {
            pictureFrame = slide.Shapes[i] as Aspose.Slides.IPictureFrame;
            if (pictureFrame != null)
            {
                break;
            }
        }

        if (pictureFrame != null)
        {
            // Access the image transform operations collection
            Aspose.Slides.Effects.IImageTransformOperationCollection transformCollection = pictureFrame.PictureFormat.Picture.ImageTransform;

            // Output the number of transform operations (transparency effects are among them)
            Console.WriteLine("Number of image transform operations: " + transformCollection.Count);

            // Example: check for AlphaModulateFixed effect and display its amount (transparency percentage)
            for (int j = 0; j < transformCollection.Count; j++)
            {
                Aspose.Slides.Effects.IImageTransformOperation operation = transformCollection[j];
                Aspose.Slides.Effects.AlphaModulateFixed alphaModulate = operation as Aspose.Slides.Effects.AlphaModulateFixed;
                if (alphaModulate != null)
                {
                    Console.WriteLine("AlphaModulateFixed amount (transparency): " + alphaModulate.Amount);
                }
            }
        }
        else
        {
            Console.WriteLine("No picture shape found on the first slide.");
        }

        // Save the presentation before exiting
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        presentation.Dispose();
    }
}