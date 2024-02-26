using System.Diagnostics;
namespace Logging_lec1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string logPath = Path.Combine(Environment.GetFolderPath(
                            Environment.SpecialFolder.DesktopDirectory), "log.txt");
            Console.WriteLine($"Writing to: {logPath}");
            TextWriterTraceListener logFile = new(File.CreateText(logPath));
            Trace.Listeners.Add(logFile);
            // text writer is buffered, so this option calls
            // Flush() on all listeners after writing
            Trace.AutoFlush = true;

            Debug.WriteLine("Debug says, I am watching!");
            Trace.WriteLine("Trace says, I am watching!");
        }
    }
}
