using System;
using System.Drawing;
using Aspose.Slides.Export;
using Aspose.Slides.Animation;

namespace Example
{
    class Program
    {
        static void Main()
        {
            // Paths for input and output presentations
            string inputPath = "input.pptx";
            string outputPath = "output.pptx";

            // Load the existing presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Add a new empty slide based on the layout of the first slide
            Aspose.Slides.ISlide slide = presentation.Slides.AddEmptySlide(presentation.Slides[0].LayoutSlide);

            // Add a rectangle shape to the new slide
            Aspose.Slides.IAutoShape shape = (Aspose.Slides.IAutoShape)slide.Shapes.AddAutoShape(
                Aspose.Slides.ShapeType.Rectangle, 100, 100, 150, 80);
            shape.AddTextFrame("Motion Path");

            // Add a custom motion path effect to the shape
            Aspose.Slides.Animation.IEffect effect = slide.Timeline.MainSequence.AddEffect(
                shape,
                EffectType.PathUser,
                EffectSubtype.None,
                EffectTriggerType.OnClick);

            // Retrieve the motion effect behavior
            Aspose.Slides.Animation.IMotionEffect motionEffect = (Aspose.Slides.Animation.IMotionEffect)effect.Behaviors[0];

            // Define points for the motion path
            PointF[] points = new PointF[1];

            // First segment: move right
            points[0] = new PointF(200, 0);
            motionEffect.Path.Add(
                MotionCommandPathType.LineTo,
                points,
                MotionPathPointsType.Auto,
                true);

            // Second segment: move down
            points[0] = new PointF(0, 200);
            motionEffect.Path.Add(
                MotionCommandPathType.LineTo,
                points,
                MotionPathPointsType.Auto,
                true);

            // End of the motion path
            motionEffect.Path.Add(
                MotionCommandPathType.End,
                null,
                MotionPathPointsType.Auto,
                true);

            // Save the modified presentation
            presentation.Save(outputPath, SaveFormat.Pptx);
        }
    }
}