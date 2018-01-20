#if DEBUG

using System.Diagnostics;

namespace OpenDBDiff.WPFUI
{
    public class DebugTraceListener : TraceListener
    {
        public override void Write(string message)
        {
        }

        public override void WriteLine(string message)
        {
            if (Debugger.IsAttached)
                Debugger.Break();
        }
    }
}

#endif
