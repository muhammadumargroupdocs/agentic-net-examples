using System;
using System.Text;
using Aspose.Slides;
using Aspose.Slides.Animation;
using Aspose.Slides.Export;

namespace SlideComparisonReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input presentation file paths
            string inputPath1 = "presentation1.pptx";
            string inputPath2 = "presentation2.pptx";

            // Load the two presentations
            Aspose.Slides.Presentation pres1 = new Aspose.Slides.Presentation(inputPath1);
            Aspose.Slides.Presentation pres2 = new Aspose.Slides.Presentation(inputPath2);

            // -------------------------------------------------
            // Use the provided animation-rewind rule logic:
            // Get the main sequence of the first slide and enable rewind,
            // then save the presentation (as required by the rule).
            // -------------------------------------------------
            Aspose.Slides.Animation.ISequence seq = pres1.Slides[0].Timeline.MainSequence;
            Aspose.Slides.Animation.IEffect effect = seq[0];
            effect.Timing.Rewind = true;
            pres1.Save("temp_output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);

            // -------------------------------------------------
            // Compare slides from both presentations
            // -------------------------------------------------
            int slideCount1 = pres1.Slides.Count;
            int slideCount2 = pres2.Slides.Count;
            int minCount = Math.Min(slideCount1, slideCount2);

            StringBuilder reportBuilder = new StringBuilder();
            reportBuilder.AppendLine("Slide Comparison Report");
            reportBuilder.AppendLine("=======================");
            reportBuilder.AppendLine();

            for (int i = 0; i < minCount; i++)
            {
                Aspose.Slides.ISlide slide1 = pres1.Slides[i];
                Aspose.Slides.ISlide slide2 = pres2.Slides[i];

                // Use the Equals method defined on IBaseSlide to compare visual/content equality
                bool areEqual = slide1.Equals(slide2);
                if (areEqual)
                {
                    reportBuilder.AppendLine($"Slide {i + 1}: Identical");
                }
                else
                {
                    reportBuilder.AppendLine($"Slide {i + 1}: Different");
                }
            }

            // Report any extra slides in either presentation
            if (slideCount1 > minCount)
            {
                for (int i = minCount; i < slideCount1; i++)
                {
                    reportBuilder.AppendLine($"Slide {i + 1}: Present only in first presentation");
                }
            }
            else if (slideCount2 > minCount)
            {
                for (int i = minCount; i < slideCount2; i++)
                {
                    reportBuilder.AppendLine($"Slide {i + 1}: Present only in second presentation");
                }
            }

            // -------------------------------------------------
            // Create a new presentation to hold the PDF report
            // -------------------------------------------------
            Aspose.Slides.Presentation reportPresentation = new Aspose.Slides.Presentation();
            Aspose.Slides.ISlide reportSlide = reportPresentation.Slides[0];

            // Add a textbox shape with the report text
            Aspose.Slides.IShape textShape = reportSlide.Shapes.AddAutoShape(
                Aspose.Slides.ShapeType.Rectangle,
                50, 50, 600, 400);
            Aspose.Slides.AutoShape autoShape = (Aspose.Slides.AutoShape)textShape;
            autoShape.AddTextFrame(reportBuilder.ToString());

            // -------------------------------------------------
            // Save the report as PDF (required output)
            // -------------------------------------------------
            string pdfReportPath = "SlideComparisonReport.pdf";
            reportPresentation.Save(pdfReportPath, Aspose.Slides.Export.SaveFormat.Pdf);

            // Clean up resources
            pres1.Dispose();
            pres2.Dispose();
            reportPresentation.Dispose();
        }
    }
}