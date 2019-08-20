using System.Text;
using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using GooLabDotNet.MorphologicalAnalysis.Models.Enums;
using GooLabDotNet.MorphologicalAnalysis.Models.Domain;
using GooLabDotNet.MorphologicalAnalysis.Models.JsonModels;
using Newtonsoft.Json;

namespace GooLabDotNet.MorphologicalAnalysis.Logic
{
    public class MorphologicalAnalysisService
    {
        private ApiKeyService apiKeyService;
        private MorphemeInformationService morphemeInformationService;
        private PartOfSpeechConversionService partOfSpeechConversionService;
        private IHttpClientFactory IHttpClientFactory;
        public MorphologicalAnalysisService(ApiKeyService apiKeyService, MorphemeInformationService morphemeInformationService, PartOfSpeechConversionService partOfSpeechConversionService, IHttpClientFactory iHttpClientFactory)
        {
            this.apiKeyService = apiKeyService;
            this.morphemeInformationService = morphemeInformationService;
            this.partOfSpeechConversionService = partOfSpeechConversionService;
            IHttpClientFactory = iHttpClientFactory;
        }

        public async Task<MorphologicalResult> GetResults(MorphologicalRequest request)
        {

            string key = apiKeyService.ApiKey;
            string infoFilter = morphemeInformationService.GetJsonRepresentationOfMorphemeInformationEnumerable(request.InfoToInclude);
            string filters = partOfSpeechConversionService.convertToJsonReadyPartOfSpeech(request.PartsToFilterOn);
            var jsonRequestModel = new MorphologicalAnalysisRequestJson(apiKeyService.ApiKey, request.RequestId, request.Sentence, infoFilter, filters);

            string jsonText = JsonConvert.SerializeObject(jsonRequestModel);
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, "https://labs.goo.ne.jp/api/morph");
            httpRequestMessage.Content = new StringContent(jsonText, Encoding.UTF8, "application/json");

            var client = IHttpClientFactory.CreateClient();
            var response = await client.SendAsync(httpRequestMessage);

            MorphologicalResult result = null;

            if (response.IsSuccessStatusCode)
            {
                var jsonResultModel = await response.Content.ReadAsAsync<MorphologicalAnalysisRequestJson>();

            }

            return result;
        }
    }
}