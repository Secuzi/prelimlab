using Microsoft.Extensions.Logging;

namespace prelimlab
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                
                    fonts.AddFont("NotoSansThaana-Bold.ttf", "NotoBold");
                    fonts.AddFont("NotoSansThaana-Regular.ttf", "NotoRegular");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
