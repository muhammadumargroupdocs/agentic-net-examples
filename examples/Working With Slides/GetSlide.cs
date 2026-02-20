using System;

class Program
{
    static void Main()
    {
        // Input and output file paths
        System.String inputPath = "input.pptx";
        System.String outputPath = "output.pptx";

        // Load the presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Access a slide by its index (e.g., first slide)
        Aspose.Slides.ISlide slide = pres.Slides[0];

        // Example usage: display the slide number
        System.Console.WriteLine("Slide number: " + slide.SlideNumber);

        // Save the presentation before exiting
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}