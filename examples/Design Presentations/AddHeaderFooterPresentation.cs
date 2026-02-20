using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        string dataDir = "Data";
        string inputPath = Path.Combine(dataDir, "template.pptx");
        string outputPath = Path.Combine(dataDir, "output.pptx");

        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);
        presentation.HeaderFooterManager.SetAllFootersText("My Footer");
        presentation.HeaderFooterManager.SetAllFootersVisibility(true);

        Aspose.Slides.IMasterNotesSlide masterNotes = presentation.MasterNotesSlideManager.MasterNotesSlide;
        if (masterNotes != null)
        {
            foreach (Aspose.Slides.IShape shape in masterNotes.Shapes)
            {
                if (shape.Placeholder != null && shape.Placeholder.Type == Aspose.Slides.PlaceholderType.Header)
                {
                    ((Aspose.Slides.IAutoShape)shape).TextFrame.Text = "My Header";
                }
            }
        }

        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}