using System;

namespace AsposeSlidesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define input and output file paths
            System.String inputPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "input.pptx");
            System.String outputPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "output.pptx");

            // Load the presentation
            Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

            // Get the main animation sequence of the first slide
            Aspose.Slides.Animation.ISequence sequence = pres.Slides[0].Timeline.MainSequence;

            // Iterate through all shapes on the first slide
            foreach (Aspose.Slides.IShape shape in pres.Slides[0].Shapes)
            {
                // Work only with AutoShape that contains a TextFrame
                Aspose.Slides.IAutoShape autoShape = shape as Aspose.Slides.IAutoShape;
                if (autoShape == null || autoShape.TextFrame == null)
                {
                    continue;
                }

                // Iterate through each paragraph in the TextFrame
                foreach (Aspose.Slides.IParagraph paragraph in autoShape.TextFrame.Paragraphs)
                {
                    // Retrieve animation effects associated with the paragraph
                    Aspose.Slides.Animation.IEffect[] effects = sequence.GetEffectsByParagraph(paragraph);
                    if (effects != null && effects.Length > 0)
                    {
                        // Output effect details to the console
                        foreach (Aspose.Slides.Animation.IEffect effect in effects)
                        {
                            System.Console.WriteLine("Paragraph Effect - Type: " + effect.Type.ToString() + ", Subtype: " + effect.Subtype.ToString());
                        }
                    }
                }
            }

            // Save the presentation after processing
            pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}