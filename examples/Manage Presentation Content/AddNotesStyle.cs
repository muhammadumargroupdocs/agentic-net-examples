using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Set up data directory
        string __DATA_DIR__ = "Data";
        if (!Directory.Exists(__DATA_DIR__))
            Directory.CreateDirectory(__DATA_DIR__);

        // Define input and output file paths
        string __INPUT_PATH__ = Path.Combine(__DATA_DIR__, "input.pptx");
        string __OUTPUT_PATH__ = Path.Combine(__DATA_DIR__, "output.pptx");

        // Create a new presentation (or load an existing one)
        Aspose.Slides.Presentation __PRESENTATION__ = new Aspose.Slides.Presentation();

        // Access the master notes slide and modify its style
        Aspose.Slides.IMasterNotesSlide __NOTES_MASTER__ = __PRESENTATION__.MasterNotesSlideManager.MasterNotesSlide;
        if (__NOTES_MASTER__ != null)
        {
            Aspose.Slides.ITextStyle __NOTES_STYLE__ = __NOTES_MASTER__.NotesStyle;
            Aspose.Slides.IParagraphFormat __PARAGRAPH_FORMAT__ = __NOTES_STYLE__.GetLevel(0);
            __PARAGRAPH_FORMAT__.Bullet.Type = Aspose.Slides.BulletType.Symbol;
        }

        // Save the presentation in PPTX format
        __PRESENTATION__.Save(__OUTPUT_PATH__, Aspose.Slides.Export.SaveFormat.Pptx);

        // Clean up resources
        __PRESENTATION__.Dispose();
    }
}