using System;
using Aspose.Slides;
using Aspose.Slides.Export;
using Aspose.Slides.Util;

namespace PresentationOverview
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path to the input presentation file
            string inputPath = "input.pptx";

            // Load the presentation
            Presentation pres = new Presentation(inputPath);

            // Output basic information about the presentation
            int slideCount = pres.Slides.Count;
            Console.WriteLine("Number of slides: " + slideCount);

            // Iterate through each slide and extract text from all text boxes
            for (int i = 0; i < slideCount; i++)
            {
                ISlide slide = pres.Slides[i];
                System.Collections.Generic.IEnumerable<ITextFrame> textFrames = SlideUtil.GetAllTextBoxes(slide);
                foreach (ITextFrame textFrame in textFrames)
                {
                    Console.WriteLine("Slide " + (i + 1) + " text: " + textFrame.Text);
                }
            }

            // Save the presentation before exiting
            string outputPath = "output.pptx";
            pres.Save(outputPath, SaveFormat.Pptx);

            // Clean up resources
            pres.Dispose();
        }
    }
}