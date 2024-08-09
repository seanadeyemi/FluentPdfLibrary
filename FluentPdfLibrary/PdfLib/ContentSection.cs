namespace FluentPdfLibrary.PdfLib
{
    public class ContentSection
    {
        // Placeholder method for adding a table to the content section
        public void Table(Action<Table> tableConfigurator)
        {
            // Configure and add a new table to the content section
            var table = new Table();
            tableConfigurator(table);
            // Add the configured table to the content section
        }
    }
}
