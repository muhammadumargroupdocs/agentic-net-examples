using System;

class Program
{
    static void Main()
    {
        // Input and output file paths
        System.String inputPath = "input.pptx";
        System.String outputPath = "output.pptx";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Iterate through shapes and change placeholder text
        foreach (Aspose.Slides.IShape shape in slide.Shapes)
        {
            if (shape.Placeholder != null && shape is Aspose.Slides.IAutoShape)
            {
                System.String newText = null;

                if (shape.Placeholder.Type == Aspose.Slides.PlaceholderType.CenteredTitle)
                {
                    newText = "New Title Text";
                }
                else if (shape.Placeholder.Type == Aspose.Slides.PlaceholderType.Subtitle)
                {
                    newText = "New Subtitle Text";
                }

                if (newText != null)
                {
                    ((Aspose.Slides.IAutoShape)shape).TextFrame.Text = newText;
                }
            }
        }

        // Save the updated presentation as PPTX
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Dispose the presentation
        presentation.Dispose();
    }
}