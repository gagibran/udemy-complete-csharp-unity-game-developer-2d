using System.IO;

namespace Interfaces
{
    public class FileLogger : ILogger
    {

        private readonly string _path;

        // Dependency injection here as well:
        public FileLogger(string path)
        {
            _path = path;
        }
        public void LogError(string message)
        {
            Log(message, "ERROR");
        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }

        public void Log(string message, string messageType)
        {
            // Class System.IO.StreamWriter to write files. We give in the path and if values written to it should be appended or not.
            // Since StreamWritter uses a file resource, which is not managed by CLR, we need to dispose of it when we done using it.
            // That can be achieved by using the "using ()" block. This is similar to Python's "with open()".
            // This is the same as just using "streamWriter.Dispose()":
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine($"{messageType}: {message}");
            }
        }
    }
}
