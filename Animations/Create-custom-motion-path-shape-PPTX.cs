using System;
using Aspose.Slides;
using Aspose.Slides.Animation;
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

            // Load the existing presentation
            Presentation pres = new Presentation(inputPath);

            // Get the first slide
            ISlide slide = pres.Slides[0];

            // Add a rectangle shape and a text frame
            IAutoShape rect = (IAutoShape)slide.Shapes.AddAutoShape(ShapeType.Rectangle, 100, 100, 200, 100);
            rect.AddTextFrame("Custom Motion Path");

            // Add a custom motion path effect (PathUser) triggered on click
            IEffect motionEffect = slide.Timeline.MainSequence.AddEffect(
                rect,
                EffectType.PathUser,
                EffectSubtype.None,
                EffectTriggerType.OnClick);

            // Get the motion behavior from the effect
            IMotionEffect motionBhv = (IMotionEffect)motionEffect.Behaviors[0];

            // Define points for the motion path
            PointF[] pts = new PointF[1];

            // Move to the starting point (relative coordinates)
            pts[0] = new PointF(0, 0);
            motionBhv.Path.Add(
                MotionCommandPathType.MoveTo,
                pts,
                MotionPathPointsType.Auto,
                true);

            // Line to the right
            pts[0] = new PointF(200, 0);
            motionBhv.Path.Add(
                MotionCommandPathType.LineTo,
                pts,
                MotionPathPointsType.Auto,
                true);

            // Line downwards
            pts[0] = new PointF(200, 200);
            motionBhv.Path.Add(
                MotionCommandPathType.LineTo,
                pts,
                MotionPathPointsType.Auto,
                true);

            // End the path
            motionBhv.Path.Add(
                MotionCommandPathType.End,
                null,
                MotionPathPointsType.Auto,
                true);

            // Save the modified presentation
            pres.Save(outputPath, SaveFormat.Pptx);
        }
    }
}