namespace FluentPdfLibrary.PdfLib
{
    public class HeaderRow
    {
        private List<Cell> cells = new List<Cell>();



        public List<Cell> Cells => cells;

        // Updated method to return a Cell instance
        public Cell Cell()
        {
            // Create and add a cell to the header row
            var cell = new Cell();
            cells.Add(cell);
            return cell;
        }

        public void AlignRight()
        {
            // Align the content of the last added cell to the right
            cells.Last().AlignRight();
        }
    }
}
