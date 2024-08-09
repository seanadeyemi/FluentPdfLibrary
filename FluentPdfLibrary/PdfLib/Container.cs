namespace FluentPdfLibrary.PdfLib
{
    public class Container
    {
        // Placeholder methods for adding page and other document elements
        public void Page(Action<Page> pageConfigurator)
        {
            // Configure and add a new page to the container
            var page = new Page();
            pageConfigurator(page);
            // Add the configured page to the container
        }
    }
}
