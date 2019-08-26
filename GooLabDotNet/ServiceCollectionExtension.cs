using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using GooLabDotNet.MorphologicalAnalysis.Logic;
using GooLabDotNet.MorphologicalAnalysis.Logic.JsonConversion;
using Microsoft.Extensions.DependencyInjection;

namespace GooLabDotNet
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddGooLabDotNet(this IServiceCollection service)
        {
            service.AddScoped<MorphemeInformationService>();
            service.AddScoped<PartOfSpeechToJsonService>();
            service.AddScoped<SentenceService>();
            service.AddScoped<WordService>();
            service.AddScoped<MorphologicalAnalysisService>();
            service.AddHttpClient();
            service.AddScoped<ApiKeyService>();
            return service;
        }
    }
}
