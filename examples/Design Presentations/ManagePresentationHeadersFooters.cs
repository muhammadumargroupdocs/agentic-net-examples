using System;
using System.IO;
using Aspose.Slides;

namespace HeaderFooterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define data directory and file paths
            string dataDir = "C:\\Data\\";
            string inputPath = Path.Combine(dataDir, "input.pptx");
            string outputPath = Path.Combine(dataDir, "output.pptx");

            // Load the presentation
            Presentation presentation = new Presentation(inputPath);

            // Manage master notes slide header/footer
            IMasterNotesSlide masterNotesSlide = presentation.MasterNotesSlideManager.MasterNotesSlide;
            if (masterNotesSlide != null)
            {
                IMasterNotesSlideHeaderFooterManager masterHeaderFooter = masterNotesSlide.HeaderFooterManager;
                masterHeaderFooter.SetHeaderAndChildHeadersVisibility(true);
                masterHeaderFooter.SetFooterAndChildFootersVisibility(true);
                masterHeaderFooter.SetSlideNumberAndChildSlideNumbersVisibility(true);
                masterHeaderFooter.SetDateTimeAndChildDateTimesVisibility(true);
                masterHeaderFooter.SetHeaderAndChildHeadersText("Master Header");
                masterHeaderFooter.SetFooterAndChildFootersText("Master Footer");
                masterHeaderFooter.SetDateTimeAndChildDateTimesText("01/01/2024");
            }

            // Manage notes slide header/footer for the first slide
            INotesSlide notesSlide = presentation.Slides[0].NotesSlideManager.NotesSlide;
            if (notesSlide != null)
            {
                INotesSlideHeaderFooterManager notesHeaderFooter = notesSlide.HeaderFooterManager;
                if (!notesHeaderFooter.IsHeaderVisible)
                {
                    notesHeaderFooter.SetHeaderVisibility(true);
                }
                if (!notesHeaderFooter.IsFooterVisible)
                {
                    notesHeaderFooter.SetFooterVisibility(true);
                }
                if (!notesHeaderFooter.IsSlideNumberVisible)
                {
                    notesHeaderFooter.SetSlideNumberVisibility(true);
                }
                if (!notesHeaderFooter.IsDateTimeVisible)
                {
                    notesHeaderFooter.SetDateTimeVisibility(true);
                }
                notesHeaderFooter.SetHeaderText("New Header");
                notesHeaderFooter.SetFooterText("New Footer");
                notesHeaderFooter.SetDateTimeText("02/02/2024");
            }

            // Save the updated presentation
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}