using System.Reflection;

namespace Injector
{
    // Very simple logging class.
    internal class Logger
    {
        public static bool LoggingEnabled { get; set; } = true;
        private static string? AssemblyFilename => $"{Assembly.GetExecutingAssembly().GetName().Name}";
        private static string Filename => AssemblyFilename == null ? "injector_log.txt" : $"{AssemblyFilename}_log.txt";

        public static void Log(string text)
        {
            if (LoggingEnabled)
            {
                var line = $"[{DateTime.Now}] {text}";
                File.AppendAllText(Filename, line);
            }
        }

        public static void LogLine(string text)
        {
            if (LoggingEnabled)
            {
                var line = $"[{DateTime.Now}] {text}\n";
                File.AppendAllText(Filename, line);
            }
        }
    }
}
