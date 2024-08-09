namespace FluentPdfLibrary.PdfLib
{
    public class ColumnsDefinition
    {
        public void Definition(Action<Columns> columnsConfigurator)
        {
            // Configure and define table columns
            var columns = new Columns();
            columnsConfigurator(columns);
            // Add the configured columns to the table
        }
    }
}
