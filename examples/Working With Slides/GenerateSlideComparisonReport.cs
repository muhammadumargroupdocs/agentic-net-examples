using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace SlideComparisonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input presentation files
            string inputPath1 = "presentation1.pptx";
            string inputPath2 = "presentation2.pptx";

            // Load presentations
            Presentation pres1 = new Presentation(inputPath1);
            Presentation pres2 = new Presentation(inputPath2);

            // Compare each slide from pres1 with each slide from pres2
            for (int i = 0; i < pres1.Slides.Count; i++)
            {
                for (int j = 0; j < pres2.Slides.Count; j++)
                {
                    // Use Equals method to compare slide content
                    if (pres1.Slides[i].Equals(pres2.Slides[j]))
                    {
                        Console.WriteLine($"Slide {i + 1} in '{inputPath1}' is equal to Slide {j + 1} in '{inputPath2}'.");
                    }
                }
            }

            // Save the first presentation (as required to save before exit)
            string outputPath = "output.pptx";
            pres1.Save(outputPath, SaveFormat.Pptx);

            // Clean up
            pres1.Dispose();
            pres2.Dispose();
        }
    }
}