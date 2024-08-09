namespace FluentPdfLibrary.PdfLib
{
    public class Table
    {
        private List<List<Cell>> cells = new List<List<Cell>>();

        public ColumnsDefinition Columns { get; } = new ColumnsDefinition();

        public void Header(Action<HeaderRow> headerConfigurator)
        {
            // Configure and add a new header row to the table
            var header = new HeaderRow();
            headerConfigurator(header);
            cells.Add(header.Cells);
        }

        // Updated method to return a Cell instance
        public Cell Cell()
        {
            // Create and add a cell to the last added row
            var cell = new Cell();
            cells.Last().Add(cell);
            return cell;
        }
    }

}
