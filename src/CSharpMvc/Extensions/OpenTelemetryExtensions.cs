using OpenTelemetry;
using OpenTelemetry.Trace;

namespace CSharpMvc.Extensions
{
    public static class OpenTelemetryBootstrap
    {
        private static TracerProvider _provider;

        public static void Initialize()
        {
            _provider = Sdk.CreateTracerProviderBuilder()
                .AddSource("CSharpMvc")
                .AddConsoleExporter()
                .Build();
        }
    }
}
