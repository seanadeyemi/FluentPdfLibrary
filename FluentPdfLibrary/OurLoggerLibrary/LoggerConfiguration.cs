namespace FluentPdfLibrary.OurLoggerLibrary
{
    public class LoggerConfiguration
    {
        private readonly List<string> _enrichments = new List<string>();

        public LoggerConfiguration ReadFromConfiguration(object config)
        {
            // Placeholder for configuration reading logic
            return this;
        }

        public LoggerConfiguration Enrich
        {
            get { return this; }
        }

        public LoggerConfiguration WithThreadId()
        {
            _enrichments.Add("ThreadId");
            return this;
        }

        public LoggerConfiguration WithThreadName()
        {
            _enrichments.Add("ThreadName");
            return this;
        }

        public LoggerConfiguration WithProcessId()
        {
            _enrichments.Add("ProcessId");
            return this;
        }

        public Logger CreateLogger()
        {
            // Placeholder for logger creation logic
            var options = new LoggerOptions(_enrichments);
            return new Logger(options);
        }
    }
}
