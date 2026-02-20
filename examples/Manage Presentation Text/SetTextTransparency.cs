using System;
using Aspose.Slides;
using Aspose.Slides.Export;
using System.Drawing;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input and output file paths
            string inputPath = "input.pptx";
            string outputPath = "output.pptx";

            // Load presentation
            Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

            // Get first shape (assumed to be an AutoShape with text)
            Aspose.Slides.IAutoShape shape = (Aspose.Slides.IAutoShape)pres.Slides[0].Shapes[0];

            // Access effect format of the first portion
            Aspose.Slides.IEffectFormat effectFormat = shape.TextFrame.Paragraphs[0].Portions[0].PortionFormat.EffectFormat;

            // Get outer shadow effect
            Aspose.Slides.Effects.IOuterShadow outerShadow = effectFormat.OuterShadowEffect;

            // Change shadow color transparency (alpha)
            System.Drawing.Color shadowColor = outerShadow.ShadowColor.Color;
            outerShadow.ShadowColor.Color = System.Drawing.Color.FromArgb(128, shadowColor);

            // Save modified presentation
            pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}