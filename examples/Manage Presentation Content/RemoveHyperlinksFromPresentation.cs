using System;

class Program
{
    static void Main(string[] args)
    {
        // Input PPT file path
        string __INPUT_PATH__ = "input.ppt";
        // Temporary output path for PPTX (required by the rule)
        string __OUTPUT_PATH_PPTX__ = "output.pptx";
        // Final output path for PPT format
        string __OUTPUT_PATH_PPT__ = "output.ppt";

        // Load presentation
        Aspose.Slides.Presentation __PRESENTATION__ = new Aspose.Slides.Presentation(__INPUT_PATH__);

        // Remove all hyperlinks from the presentation
        __PRESENTATION__.HyperlinkQueries.RemoveAllHyperlinks();

        // Save as PPTX (as defined by the rule)
        __PRESENTATION__.Save(__OUTPUT_PATH_PPTX__, Aspose.Slides.Export.SaveFormat.Pptx);

        // Save as PPT format after hyperlinks have been removed
        __PRESENTATION__.Save(__OUTPUT_PATH_PPT__, Aspose.Slides.Export.SaveFormat.Ppt);
    }
}