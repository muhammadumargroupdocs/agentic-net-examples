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
            string outputPath = "output_motion_path.pptx";

            // Load the existing presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Get the first slide
            Aspose.Slides.ISlide slide = presentation.Slides[0];

            // Add a rectangle shape to the slide
            Aspose.Slides.IAutoShape rect = (Aspose.Slides.IAutoShape)slide.Shapes.AddAutoShape(
                Aspose.Slides.ShapeType.Rectangle, 100, 100, 100, 50);
            rect.AddTextFrame("Motion Path");

            // Add a custom motion path effect to the rectangle
            Aspose.Slides.Animation.IEffect motionEffect = slide.Timeline.MainSequence.AddEffect(
                rect,
                Aspose.Slides.Animation.EffectType.PathUser,
                Aspose.Slides.Animation.EffectSubtype.None,
                Aspose.Slides.Animation.EffectTriggerType.OnClick);

            // Get the motion behavior from the effect
            Aspose.Slides.Animation.IMotionEffect motionBhv = (Aspose.Slides.Animation.IMotionEffect)motionEffect.Behaviors[0];

            // Define points for the motion path
            PointF[] pts = new PointF[1];
            pts[0] = new PointF(200, 0);
            motionBhv.Path.Add(
                Aspose.Slides.Animation.MotionCommandPathType.LineTo,
                pts,
                Aspose.Slides.Animation.MotionPathPointsType.Auto,
                true);

            pts[0] = new PointF(0, 200);
            motionBhv.Path.Add(
                Aspose.Slides.Animation.MotionCommandPathType.LineTo,
                pts,
                Aspose.Slides.Animation.MotionPathPointsType.Auto,
                true);

            // End the motion path
            motionBhv.Path.Add(
                Aspose.Slides.Animation.MotionCommandPathType.End,
                null,
                Aspose.Slides.Animation.MotionPathPointsType.Auto,
                true);

            // Save the presentation
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
            presentation.Dispose();
        }
    }
}