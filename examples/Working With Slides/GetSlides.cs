using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace SlideAccessExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path to the input presentation
            string inputPath = "input.pptx";

            // Load the presentation
            Presentation presentation = new Presentation(inputPath);

            // Access the first slide by index
            ISlide firstSlide = presentation.Slides[0];

            // Output some information about the slide
            Console.WriteLine("First slide name: " + firstSlide.Name);

            // Save the presentation before exiting
            presentation.Save("output.pptx", SaveFormat.Pptx);

            // Dispose the presentation object
            presentation.Dispose();
        }
    }
}