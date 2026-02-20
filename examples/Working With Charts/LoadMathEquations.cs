using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.MathText;

class Program
{
    static void Main()
    {
        // Define input and output file paths
        System.String dataDir = "Data";
        System.String inputFile = System.IO.Path.Combine(dataDir, "input.pptx");
        System.String outputFile = System.IO.Path.Combine(dataDir, "output.pptx");

        // Load the presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputFile);

        // Iterate through slides and shapes to find math portions
        foreach (Aspose.Slides.ISlide slide in pres.Slides)
        {
            foreach (Aspose.Slides.IShape shape in slide.Shapes)
            {
                Aspose.Slides.IAutoShape autoShape = shape as Aspose.Slides.IAutoShape;
                if (autoShape != null && autoShape.TextFrame != null)
                {
                    foreach (Aspose.Slides.IParagraph paragraph in autoShape.TextFrame.Paragraphs)
                    {
                        foreach (Aspose.Slides.IPortion portion in paragraph.Portions)
                        {
                            Aspose.Slides.MathText.MathPortion mathPortion = portion as Aspose.Slides.MathText.MathPortion;
                            if (mathPortion != null)
                            {
                                // Example modification of the math equation
                                mathPortion.Text = "E=mc^2";
                            }
                        }
                    }
                }
            }
        }

        // Save the modified presentation
        pres.Save(outputFile, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}