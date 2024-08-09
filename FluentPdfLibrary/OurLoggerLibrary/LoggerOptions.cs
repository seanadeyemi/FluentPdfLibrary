namespace FluentPdfLibrary.OurLoggerLibrary
{
    public class LoggerOptions
    {
        // Placeholder for configuration options
        private readonly List<string> _enrichments;

        public LoggerOptions(List<string> enrichments)
        {
            _enrichments = enrichments;
        }

        public List<string> GetEnrichments()
        {
            return _enrichments;
        }
    }
}
