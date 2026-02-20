using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace TableFontExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Get the first slide
            Aspose.Slides.ISlide slide = presentation.Slides[0];

            // Assume the first shape on the slide is a table
            Aspose.Slides.ITable table = slide.Shapes[0] as Aspose.Slides.ITable;
            if (table == null)
            {
                // No table found; exit
                return;
            }

            // Set font height for all text in the table
            Aspose.Slides.PortionFormat portionFormat = new Aspose.Slides.PortionFormat();
            portionFormat.FontHeight = 20f;
            table.SetTextFormat(portionFormat);

            // Set paragraph alignment and right margin for all text in the table
            Aspose.Slides.ParagraphFormat paragraphFormat = new Aspose.Slides.ParagraphFormat();
            paragraphFormat.Alignment = Aspose.Slides.TextAlignment.Right;
            paragraphFormat.MarginRight = 5f;
            table.SetTextFormat(paragraphFormat);

            // Set vertical text orientation for the second row of the table
            Aspose.Slides.TextFrameFormat textFrameFormat = new Aspose.Slides.TextFrameFormat();
            textFrameFormat.TextVerticalType = Aspose.Slides.TextVerticalType.Vertical;
            table.Rows[1].SetTextFormat(textFrameFormat);

            // Save the presentation
            presentation.Save("TableFontExample.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}