using FluentPdfLibrary.PdfLib.Helpers;

namespace FluentPdfLibrary.PdfLib
{
    public class HeaderSection
    {
        // Placeholder methods for configuring header properties
        public HeaderSection AlignCenter()
        {
            // Align the header content to the center
            return this;
        }

        public HeaderSection Text(string text)
        {
            // Add text to the header
            return this;
        }

        public HeaderSection SemiBold()
        {
            // Set the text in the header to semi-bold
            return this;
        }

        public HeaderSection FontSize(int fontSize)
        {
            // Set the font size for the text in the header
            return this;
        }

        public HeaderSection FontColor(Colors color)
        {
            // Set the font color for the text in the header
            return this;
        }
    }
}
