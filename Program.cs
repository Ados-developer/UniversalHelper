using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using UniverzalHelper.Forms;
using UniverzalHelper.UserControls;

namespace UniverzalHelper
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


            IHost? host = Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    //Forms
                    services.AddTransient<MainForm>();
                    //UserControls
                    services.AddTransient<Base64DecoderCtrl>();
                    services.AddTransient<Base64GzipDecoderCtrl>();
                    services.AddTransient<HashGeneratorCtrl>();
                    services.AddTransient<JwtTokenDecoderCtrl>();
                    services.AddTransient<ColorCtrl>();
                    services.AddTransient<Base16DecoderCtrl>();
                })
            .Build();


            Application.Run(host.Services.GetRequiredService<MainForm>());
        }
    }
}