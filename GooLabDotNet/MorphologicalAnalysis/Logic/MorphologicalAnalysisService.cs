using System.Text;
using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using System.Net.Http;
using System.Threading.Tasks;
using GooLabDotNet.MorphologicalAnalysis.Logic.JsonConversion;
using GooLabDotNet.MorphologicalAnalysis.Models.Enums;
using GooLabDotNet.MorphologicalAnalysis.Models.Domain;
using GooLabDotNet.MorphologicalAnalysis.Models.JsonModels;
using Microsoft.AspNetCore.Server.IIS;
using Newtonsoft.Json;

namespace GooLabDotNet.MorphologicalAnalysis.Logic
{
    public class MorphologicalAnalysisService: IMorphologicalAnalysisService
    {
        private ApiKeyService apiKeyService;
        private SentenceService sentenceService;
        private IHttpClientFactory IHttpClientFactory;
        private MorphemeFieldService morphemeFieldService;

        internal MorphologicalAnalysisService(ApiKeyService apiKeyService, SentenceService sentenceService, IHttpClientFactory httpClientFactory, MorphemeFieldService morphemeFieldService)
        {
            this.apiKeyService = apiKeyService;
            this.sentenceService = sentenceService;
            IHttpClientFactory = httpClientFactory;
            this.morphemeFieldService = morphemeFieldService;
        }


        public async Task<MorphologicalResult> GetResults(MorphologicalRequest request, string specifiedKey = null)
        {
            if (specifiedKey != null)
            {
                apiKeyService.ApiKey = specifiedKey;
            }

            var infoToShow = new List<MorphemeField>() { MorphemeField.Katakana, MorphemeField.OriginalInput };
            string infoFilter = morphemeFieldService.GetJsonRepresentationOfMorphemeInformationEnumerable(infoToShow);
            string filters = "名詞";
            var jsonRequestModel = new MorphologicalAnalysisRequestJson(apiKeyService.ApiKey, request.RequestId, request.Sentence, infoFilter, filters);

            string jsonText = JsonConvert.SerializeObject(jsonRequestModel);
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, "https://labs.goo.ne.jp/api/morph")
            {
                Content = new StringContent(jsonText, Encoding.UTF8, "application/json")
            };

            var client = IHttpClientFactory.CreateClient();
            var response = await client.SendAsync(httpRequestMessage);

            if (response.IsSuccessStatusCode)
            {/*
                MorphologicalRequestResultJson parsingResult = await response.Content.ReadAsAsync<MorphologicalRequestResultJson>();
                MorphologicalResult morphologicalResult = new MorphologicalResult();*/
                return null;
            }

            else
            {
                return null;
            }
            
        }

    }
}