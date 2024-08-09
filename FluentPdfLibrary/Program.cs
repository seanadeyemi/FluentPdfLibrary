// See https://aka.ms/new-console-template for more information





// Example usage
using FluentPdfLibrary.OurLoggerLibrary;
using FluentPdfLibrary.PdfLib;
using FluentPdfLibrary.PdfLib.Helpers;

var container = new Container();
var lineItems = new List<LineItem> { /* Populate line items as needed */ };

var pdf = Document.Create(container);

container.Page(page =>
{
    // Configure the page as needed
    page.Margin(50);
    page.Size(PageSizes.A4);
    page.PageColor(Colors.White);
    page.DefaultTextStyle(x => x.FontSize(16));

    page.Header()
        .AlignCenter()
        .Text("Invoice #: 2023-77")
        .SemiBold()
        .FontSize(24)
        .FontColor(Colors.DarkBlue);

    page.Content()
        .Table(table =>
        {
            table.Columns.Definition(columns =>
            {
                columns.ConstantColumn(20);
                columns.RelativeColumn();
                columns.RelativeColumn();
            });

            table.Header(header =>
            {
                header.Cell().Text("#");
                header.Cell().Text("Product");
                header.Cell().AlignRight().Text("Price");
            });

            foreach (var lineItem in lineItems)
            {
                table.Cell().Text(lineItem.Index.ToString());
                table.Cell().Text(lineItem.Name);
                table.Cell().Text($"${lineItem.Price}");
            }
        });
});

pdf.Save("invoice.pdf");




var pdf2 = Document.Create(container =>
{
    container.Page(page =>
    {
        // Configuration for the page
        page.Margin(3, Unit.Centimetre);
    });
});


Log.Logger = new LoggerConfiguration()
    .ReadFromConfiguration("")
    .Enrich.WithThreadId()
    .Enrich.WithThreadName()
    .Enrich.WithProcessId()
    .CreateLogger();

Log.Logger.Log("Hello, logger!");

Console.ReadKey();
