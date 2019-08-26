using System.Threading.Tasks;
using GooLabDotNet.MorphologicalAnalysis.Logic;
using GooLabDotNet.MorphologicalAnalysis.Models.Domain;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace GooLabDotNet.Test.EndToEnd
{
    [TestClass]
    public class MorphologicalAnalysisRequestTest
    {
        private MorphologicalAnalysisService morphologicalAnalysisService;

        [TestInitialize]
        public void TestInitialize()
        {
            var serviceProvider = new ServiceCollection()
                .AddGooLabDotNet()
                .BuildServiceProvider();

            var keyService = serviceProvider.GetService<ApiKeyService>();
        }

        [TestMethod]
        public  void SendingRequest()
        { 
            MorphologicalRequest request = new MorphologicalRequest("これは日本語の文章であります。", "1");
            Task<MorphologicalResult> resultTask = morphologicalAnalysisService.GetResults(request);
            MorphologicalResult result = null;
            Assert.Equals(result.RequestId, "1");
            Assert.Equals(result.Sentences.Count, 1);

        }
    }
}