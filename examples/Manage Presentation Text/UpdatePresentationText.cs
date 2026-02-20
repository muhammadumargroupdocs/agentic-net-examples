using System;

class Program
{
    // Entry point of the console application
    static void Main()
    {
        // Path to the source PPTX file
        string inputPath = "input.pptx";
        // Path where the updated PPTX will be saved
        string outputPath = "output.pptx";

        // Load the presentation from the input file
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Get the first slide in the presentation
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Iterate through all shapes on the slide
        foreach (Aspose.Slides.IShape shape in slide.Shapes)
        {
            // Check if the shape has a placeholder and is an AutoShape (contains a TextFrame)
            if (shape.Placeholder != null && shape is Aspose.Slides.IAutoShape)
            {
                // Cast to IAutoShape and update its text
                ((Aspose.Slides.IAutoShape)shape).TextFrame.Text = "Updated text";
            }
        }

        // Save the modified presentation as PPTX
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Release resources
        presentation.Dispose();
    }
}