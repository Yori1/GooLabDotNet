using System.Threading.Tasks;
using GooLabDotNet.MorphologicalAnalysis.Logic;
using GooLabDotNet.MorphologicalAnalysis.Models.Domain;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GooLabDotNet.EndToEndTests
{
    [TestClass]
    public class MorphologicalAnalysisRequestTest
    {
        private MorphologicalAnalysisService morphologicalAnalysisService;
        private string apiKey;

        [TestInitialize]
        public void TestInitialize()
        {
            var builder = new ConfigurationBuilder();
            builder
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            builder.AddUserSecrets<MorphologicalAnalysisRequestTest>();

            var configuration = builder.Build();

            var serviceProvider = new ServiceCollection()
                .Configure<MySecrets>(configuration.GetSection(nameof(MySecrets)))
                .AddOptions()
                .AddLogging()
                .AddSingleton<MySecretsService>()
                .AddGooLabDotNet()
                .BuildServiceProvider();

            apiKey = serviceProvider.GetService<MySecretsService>().getSecrets().ApiKey;

            morphologicalAnalysisService = serviceProvider.GetService<MorphologicalAnalysisService>();

        }

        [TestMethod]
        public async Task SendingRequest()
        {
            MorphologicalRequest request = new MorphologicalRequest("これは日本語の文章であります。", "1");
            Task<MorphologicalResult> resultTask = morphologicalAnalysisService.GetResults(request, apiKey);
            MorphologicalResult result = await resultTask;
            Assert.Equals(result.RequestId, "1");
            Assert.Equals(result.Sentences.Count, 1);

        }
    }
}
