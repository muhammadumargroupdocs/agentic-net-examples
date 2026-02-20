using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace AsposeSlidesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Get the default first slide to act as Table of Contents (TOC)
            Aspose.Slides.ISlide tocSlide = presentation.Slides[0];

            // Add a second slide (Section 1)
            Aspose.Slides.ISlide section1 = presentation.Slides.AddEmptySlide(presentation.Slides[0].LayoutSlide);
            Aspose.Slides.IAutoShape title1 = section1.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50, 50, 600, 50);
            title1.TextFrame.Text = "Section 1 Content";

            // Add a third slide (Section 2)
            Aspose.Slides.ISlide section2 = presentation.Slides.AddEmptySlide(presentation.Slides[0].LayoutSlide);
            Aspose.Slides.IAutoShape title2 = section2.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50, 50, 600, 50);
            title2.TextFrame.Text = "Section 2 Content";

            // Add TOC entry for Section 1
            Aspose.Slides.IAutoShape tocEntry1 = tocSlide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50, 150, 400, 30);
            tocEntry1.TextFrame.Text = "Go to Section 1";
            // Set internal hyperlink to Section 1 slide
            tocEntry1.HyperlinkManager.SetInternalHyperlinkClick(section1);

            // Add TOC entry for Section 2
            Aspose.Slides.IAutoShape tocEntry2 = tocSlide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50, 200, 400, 30);
            tocEntry2.TextFrame.Text = "Go to Section 2";
            // Set internal hyperlink to Section 2 slide
            tocEntry2.HyperlinkManager.SetInternalHyperlinkClick(section2);

            // Save the presentation in PPTX format
            presentation.Save("TableOfContentsDemo.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}