namespace FluentPdfLibrary.OurLoggerLibrary
{
    public static class Log
    {
        private static Logger _loggerConfiguration;

        //static Log()
        //{
        //    _loggerConfiguration = new Logger();
        //}

        public static Logger Logger
        {
            get { return _loggerConfiguration; }
            set { _loggerConfiguration = value; }
        }
    }
}
