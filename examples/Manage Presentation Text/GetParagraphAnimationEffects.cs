using System;
using Aspose.Slides;
using Aspose.Slides.Animation;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Load the presentation
        string inputPath = "input.pptx";
        Presentation presentation = new Presentation(inputPath);

        // Get the first slide and first shape
        ISlide slide = presentation.Slides[0];
        IShape shape = slide.Shapes[0];
        IAutoShape autoShape = shape as IAutoShape;

        if (autoShape != null && autoShape.TextFrame != null)
        {
            // Get the main animation sequence
            ISequence sequence = slide.Timeline.MainSequence;

            // Iterate through each paragraph in the text frame
            foreach (IParagraph paragraph in autoShape.TextFrame.Paragraphs)
            {
                IEffect[] effects = sequence.GetEffectsByParagraph(paragraph);
                if (effects != null && effects.Length > 0)
                {
                    Console.WriteLine("Paragraph has {0} effect(s).", effects.Length);
                    foreach (IEffect effect in effects)
                    {
                        Console.WriteLine("Effect Type: {0}, Subtype: {1}", effect.Type, effect.Subtype);
                    }
                }
                else
                {
                    Console.WriteLine("Paragraph has no effects.");
                }
            }
        }

        // Save the presentation
        string outputPath = "output.pptx";
        presentation.Save(outputPath, SaveFormat.Pptx);
    }
}