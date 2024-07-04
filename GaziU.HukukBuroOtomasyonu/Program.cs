using GaziU.HukukBuroOtomasyonu.BL.Services.Abstract;
using GaziU.HukukBuroOtomasyonu.BL.Services.Concrete;
using GaziU.HukukBuroOtomasyonu.DAL;
using GaziU.HukukBuroOtomasyonu.DAL.Models;
using GaziU.HukukBuroOtomasyonu.DAL.Repsitory.Abstract;
using GaziU.HukukBuroOtomasyonu.DAL.Repsitory.Concrete;
using Microsoft.Extensions.DependencyInjection;
using Ninject;
using System.Text.RegularExpressions;

namespace GaziU.HukukBuroOtomasyonu
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            services.AddDbContext<AppDbContext>();//burada hata veriyor
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));
            services.AddScoped<IAvukatRepository, AvukatRepository>();
            services.AddScoped<IAvukatService, AvukatService>();

            var serviceProvider = services.BuildServiceProvider();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Giris(serviceProvider.GetRequiredService<IAvukatRepository>()));
        }
    }
}