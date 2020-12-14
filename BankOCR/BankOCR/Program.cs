using BankOCR.Services.services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace BankOCR
{
    class Program
    {
        private static IServiceProvider _serviceProvider;
        static void Main(string[] args)
        {
            ConfigureServices();
            var parserService = _serviceProvider.GetService<IParserService>();
            var transformService = _serviceProvider.GetService<ITransformService>();

            Console.WriteLine("Provide path to the file");
            var path = Console.ReadLine();
          
            var data = parserService.ParseToLine(path);
            var parsedData = parserService.ParseLinesToNumbers(data);           
            var result = transformService.GetNumbers(parsedData);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Press any button to exit");
            Console.ReadLine();
            DisposeService();
        }


        private static void ConfigureServices()
        {
            _serviceProvider = new ServiceCollection()
                .AddScoped<IParserService, ParserService>()
                .AddScoped<ITransformService, TransformService>()
                .BuildServiceProvider();
        }

        private static void DisposeService()
        {
            if (_serviceProvider == null)
            {
                return;
            }
            if (_serviceProvider is IDisposable)
            {
                ((IDisposable)_serviceProvider).Dispose();
            }
        }
    }
}
