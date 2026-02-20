using System;
using System.IO;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Create output directory
        System.String outDir = "Output";
        if (!System.IO.Directory.Exists(outDir))
            System.IO.Directory.CreateDirectory(outDir);

        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a rectangle auto shape
        Aspose.Slides.IAutoShape shape = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50, 150, 300, 150);

        // Get the text frame of the shape
        Aspose.Slides.ITextFrame tf = shape.TextFrame;

        // First paragraph (default)
        Aspose.Slides.IParagraph para0 = tf.Paragraphs[0];
        Aspose.Slides.IPortion port01 = new Aspose.Slides.Portion();
        Aspose.Slides.IPortion port02 = new Aspose.Slides.Portion();
        para0.Portions.Add(port01);
        para0.Portions.Add(port02);

        // Add second paragraph
        Aspose.Slides.IParagraph para1 = new Aspose.Slides.Paragraph();
        tf.Paragraphs.Add(para1);
        Aspose.Slides.IPortion port10 = new Aspose.Slides.Portion();
        Aspose.Slides.IPortion port11 = new Aspose.Slides.Portion();
        Aspose.Slides.IPortion port12 = new Aspose.Slides.Portion();
        para1.Portions.Add(port10);
        para1.Portions.Add(port11);
        para1.Portions.Add(port12);

        // Add third paragraph
        Aspose.Slides.IParagraph para2 = new Aspose.Slides.Paragraph();
        tf.Paragraphs.Add(para2);
        Aspose.Slides.IPortion port20 = new Aspose.Slides.Portion();
        Aspose.Slides.IPortion port21 = new Aspose.Slides.Portion();
        Aspose.Slides.IPortion port22 = new Aspose.Slides.Portion();
        para2.Portions.Add(port20);
        para2.Portions.Add(port21);
        para2.Portions.Add(port22);

        // Set text and formatting for each portion
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Aspose.Slides.IPortion portion = tf.Paragraphs[i].Portions[j];
                portion.Text = "Portion " + i + "_" + j;
                if (j == 0)
                {
                    portion.PortionFormat.FillFormat.FillType = Aspose.Slides.FillType.Solid;
                    portion.PortionFormat.FillFormat.SolidFillColor.Color = Color.Red;
                    portion.PortionFormat.FontBold = Aspose.Slides.NullableBool.True;
                    portion.PortionFormat.FontHeight = 15;
                }
                else if (j == 1)
                {
                    portion.PortionFormat.FillFormat.FillType = Aspose.Slides.FillType.Solid;
                    portion.PortionFormat.FillFormat.SolidFillColor.Color = Color.Blue;
                    portion.PortionFormat.FontItalic = Aspose.Slides.NullableBool.True;
                    portion.PortionFormat.FontHeight = 18;
                }
                else // j == 2
                {
                    portion.PortionFormat.FillFormat.FillType = Aspose.Slides.FillType.Solid;
                    portion.PortionFormat.FillFormat.SolidFillColor.Color = Color.Green;
                    portion.PortionFormat.FontHeight = 20;
                }
            }
        }

        // Save the presentation as PPTX
        System.String outputPath = System.IO.Path.Combine(outDir, "ManagedParagraphs.pptx");
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        presentation.Dispose();
    }
}