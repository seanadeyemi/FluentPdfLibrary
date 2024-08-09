using FluentPdfLibrary.PdfLib.Helpers;

namespace FluentPdfLibrary.PdfLib
{
    public class Page
    {
        // Placeholder methods for configuring page properties
        public void Margin(int margin)
        {
            // Set the page margin
        }

        public void Margin(int val, Unit unit)
        {
            // Set the page margin
        }

        public void Size(PageSizes size)
        {
            // Set the page size
        }

        public void PageColor(Colors color)
        {
            // Set the page color
        }

        public void DefaultTextStyle(Action<TextStyle> textStyleConfigurator)
        {
            // Configure and set the default text style for the page
        }

        public HeaderSection Header()
        {
            // Create and return a new HeaderSection for the page
            return new HeaderSection();
        }

        public ContentSection Content()
        {
            // Create and return a new ContentSection for the page
            return new ContentSection();
        }
    }

}
