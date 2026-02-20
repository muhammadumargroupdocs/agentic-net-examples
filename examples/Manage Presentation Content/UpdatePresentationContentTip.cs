using System;

class Program
{
    static void Main()
    {
        string inputPath = "input.pptx";
        string outputPath = "output.ppt";

        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);
        presentation.HeaderFooterManager.SetAllFootersText("Confidential");
        presentation.HeaderFooterManager.SetAllFootersVisibility(true);

        Aspose.Slides.IMasterNotesSlide masterNotes = presentation.MasterNotesSlideManager.MasterNotesSlide;
        if (masterNotes != null)
        {
            foreach (Aspose.Slides.IShape shape in masterNotes.Shapes)
            {
                if (shape.Placeholder != null && shape.Placeholder.Type == Aspose.Slides.PlaceholderType.Header)
                {
                    ((Aspose.Slides.IAutoShape)shape).TextFrame.Text = "Header Text";
                }
            }
        }

        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Ppt);
        presentation.Dispose();
    }
}