using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Load the presentation from a file
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx");

        // Iterate through slides and compare each slide with the next one
        for (int i = 0; i < presentation.Slides.Count - 1; i++)
        {
            Aspose.Slides.ISlide slideCurrent = presentation.Slides[i];
            Aspose.Slides.ISlide slideNext = presentation.Slides[i + 1];

            // Use Equals method to compare slides
            bool areEqual = slideCurrent.Equals(slideNext);

            // Output comparison result
            Console.WriteLine($"Slide {i + 1} and Slide {i + 2} are {(areEqual ? "equal" : "different")}.");
        }

        // Save the presentation before exiting
        presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        presentation.Dispose();
    }
}