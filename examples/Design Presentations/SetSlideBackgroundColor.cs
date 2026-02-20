using System;
using Aspose.Slides;
using System.Drawing;

class Program
{
    static void Main()
    {
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        for (int i = 0; i < presentation.Slides.Count; i++)
        {
            presentation.Slides[i].Background.Type = Aspose.Slides.BackgroundType.OwnBackground;
            presentation.Slides[i].Background.FillFormat.FillType = Aspose.Slides.FillType.Solid;
            presentation.Slides[i].Background.FillFormat.SolidFillColor.Color = System.Drawing.Color.Blue;
        }

        string outputPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "output.pptx");
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        presentation.Dispose();
    }
}