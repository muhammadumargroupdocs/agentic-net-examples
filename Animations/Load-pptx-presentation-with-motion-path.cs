using System;
using Aspose.Slides;
using Aspose.Slides.Animation;
using Aspose.Slides.Export;
using System.Drawing;

namespace MotionPathExample
{
    class Program
    {
        static void Main()
        {
            // Input and output file paths
            string inputPath = "input.pptx";
            string outputPath = "output.pptx";

            // Load existing presentation
            using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
            {
                // Add a new empty slide based on the layout of the first slide
                Aspose.Slides.ISlide slide = presentation.Slides.AddEmptySlide(presentation.Slides[0].LayoutSlide);

                // Add a rectangle shape that will receive the motion path animation
                Aspose.Slides.IShape shape = slide.Shapes.AddAutoShape(
                    Aspose.Slides.ShapeType.Rectangle, 100, 100, 200, 100);

                // Add a custom motion path effect (PathUser) triggered on click
                Aspose.Slides.Animation.IEffect effect = slide.Timeline.MainSequence.AddEffect(
                    shape,
                    Aspose.Slides.Animation.EffectType.PathUser,
                    Aspose.Slides.Animation.EffectSubtype.None,
                    Aspose.Slides.Animation.EffectTriggerType.OnClick);

                // Retrieve the motion effect behavior from the effect
                Aspose.Slides.Animation.IMotionEffect motionEffect = (Aspose.Slides.Animation.IMotionEffect)effect.Behaviors[0];

                // Define a line segment for the motion path
                System.Drawing.PointF[] linePoints = new System.Drawing.PointF[1];
                linePoints[0] = new System.Drawing.PointF(300, 0); // Move 300 points to the right

                // Add the line segment to the motion path (relative coordinates)
                motionEffect.Path.Add(
                    Aspose.Slides.Animation.MotionCommandPathType.LineTo,
                    linePoints,
                    Aspose.Slides.Animation.MotionPathPointsType.Auto,
                    true);

                // End the motion path
                motionEffect.Path.Add(
                    Aspose.Slides.Animation.MotionCommandPathType.End,
                    null,
                    Aspose.Slides.Animation.MotionPathPointsType.Auto,
                    true);

                // Save the modified presentation
                presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
            }
        }
    }
}