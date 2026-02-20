using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a comment author
        Aspose.Slides.ICommentAuthor author = presentation.CommentAuthors.AddAuthor("John Doe", "JD");

        // Add a modern comment to the first slide
        Aspose.Slides.IModernComment modernComment = author.Comments.AddModernComment(
            "This is a modern comment",
            presentation.Slides[0],
            null,
            new System.Drawing.PointF(100f, 100f),
            System.DateTime.Now);

        // Save the presentation in PPT format
        presentation.Save("ModernComments.ppt", Aspose.Slides.Export.SaveFormat.Ppt);
    }
}