using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics; // Trace
using System.Runtime.CompilerServices; // [Caller...] attributes

namespace Logging_lec1
{
    internal partial class Program
    {

        static void LogSourceDetails( bool condition, 
            [CallerMemberName] string member = "",
            [CallerFilePath] string filepath = "",
            [CallerLineNumber] int line = 0,
            [CallerArgumentExpression(nameof(condition))] string expression = "")
        {
            Trace.WriteLine(string.Format(
            "[{0}]\n {1} on line {2}. Expression: {3}",
            filepath, member, line, expression));
        }
    }
}

