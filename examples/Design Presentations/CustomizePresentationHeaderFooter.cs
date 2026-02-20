using System;
using Aspose.Slides;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Set footer text and make it visible for all slides
        presentation.HeaderFooterManager.SetAllFootersText("Custom Footer");
        presentation.HeaderFooterManager.SetAllFootersVisibility(true);

        // Access the master notes slide to set header text
        Aspose.Slides.IMasterNotesSlide masterNotes = presentation.MasterNotesSlideManager.MasterNotesSlide;
        if (masterNotes != null)
        {
            foreach (Aspose.Slides.IShape shape in masterNotes.Shapes)
            {
                if (shape.Placeholder != null && shape.Placeholder.Type == Aspose.Slides.PlaceholderType.Header)
                {
                    ((Aspose.Slides.IAutoShape)shape).TextFrame.Text = "Custom Header";
                }
            }
        }

        // Save the presentation
        presentation.Save("CustomHeaderFooter.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}