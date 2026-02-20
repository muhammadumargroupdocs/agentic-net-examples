using System;
using Aspose.Slides;

class Program
{
    static void Main()
    {
        // Input and output file paths
        string inputPath = "input.pptx";
        string outputPath = "output.pptx";

        // Load the presentation from the input file
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Iterate through slides and compare each slide with its predecessor
        for (int i = 1; i < presentation.Slides.Count; i++)
        {
            Aspose.Slides.ISlide previousSlide = presentation.Slides[i - 1];
            Aspose.Slides.ISlide currentSlide = presentation.Slides[i];

            // Use the Equals method to determine if slides are identical
            bool slidesAreEqual = previousSlide.Equals(currentSlide);
            if (!slidesAreEqual)
            {
                Console.WriteLine("Slide {0} differs from slide {1}.", i + 1, i);
            }
        }

        // Save the (potentially unchanged) presentation before exiting
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}