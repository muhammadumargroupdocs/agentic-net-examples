using System;

class Program
{
    static void Main()
    {
        // Paths for the presentation files
        string outputPath = "output.pptx";

        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Prompt texts to set
        string titleText = "Custom Title Prompt";
        string subtitleText = "Custom Subtitle Prompt";

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Iterate through shapes and set text for title and subtitle placeholders
        foreach (Aspose.Slides.IShape shape in slide.Shapes)
        {
            if (shape.Placeholder != null && shape is Aspose.Slides.IAutoShape)
            {
                string text = null;
                if (shape.Placeholder.Type == Aspose.Slides.PlaceholderType.CenteredTitle)
                {
                    text = titleText;
                }
                else if (shape.Placeholder.Type == Aspose.Slides.PlaceholderType.Subtitle)
                {
                    text = subtitleText;
                }

                if (text != null)
                {
                    ((Aspose.Slides.IAutoShape)shape).TextFrame.Text = text;
                }
            }
        }

        // Save the modified presentation as PPTX
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        presentation.Dispose();
    }
}