using System.Diagnostics;

namespace CSharpMvc.Extensions
{
    public static class OpenTelemetryBootstrap
    {
        public static void Initialize()
        {
            var source = new TraceSource("CSharpMvc");
            source.TraceEvent(TraceEventType.Information, 0, "ASP.NET MVC 5 startup (net45)");
        }
    }
}
