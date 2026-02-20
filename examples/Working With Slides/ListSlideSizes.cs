using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // List all supported slide size types
        Console.WriteLine("Supported slide sizes:");
        foreach (Aspose.Slides.SlideSizeType sizeType in Enum.GetValues(typeof(Aspose.Slides.SlideSizeType)))
        {
            Console.WriteLine("- " + sizeType);
        }

        // Save the presentation before exiting
        presentation.Save("SupportedSlideSizes.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}