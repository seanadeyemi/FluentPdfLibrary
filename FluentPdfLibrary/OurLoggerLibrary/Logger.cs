namespace FluentPdfLibrary.OurLoggerLibrary
{
    public class Logger
    {
        private readonly LoggerOptions _options;

        public Logger(LoggerOptions options)
        {
            _options = options;
        }

        public void Log(string message)
        {
            // Placeholder for actual logging logic
            Console.WriteLine($"Logging message: {message}");

            // Placeholder for accessing enrichments from options
            Console.WriteLine($"Enrichments: {string.Join(", ", _options.GetEnrichments())}");
        }
    }
}
