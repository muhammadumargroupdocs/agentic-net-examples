using System;
using Aspose.Slides;

class Program
{
    static void Main()
    {
        // Paths to the input and output PPTX files
        string dataDir = "Data/";
        string inputPath = dataDir + "input.pptx";
        string outputPath = dataDir + "output.pptx";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Iterate through each slide
        foreach (Aspose.Slides.ISlide slide in presentation.Slides)
        {
            // Iterate shapes in reverse order to safely remove items
            for (int i = slide.Shapes.Count - 1; i >= 0; i--)
            {
                Aspose.Slides.IShape shape = slide.Shapes[i];
                Aspose.Slides.ITable table = shape as Aspose.Slides.ITable;
                if (table != null)
                {
                    // Remove the table shape from the slide
                    slide.Shapes.RemoveAt(i);
                }
            }
        }

        // Save the modified presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}