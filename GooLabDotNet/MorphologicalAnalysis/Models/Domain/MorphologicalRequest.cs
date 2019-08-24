using System.Collections.Generic;
using GooLabDotNet.MorphologicalAnalysis.Models.Enums;

namespace GooLabDotNet.MorphologicalAnalysis.Models.Domain
{
    public class MorphologicalRequest
    {
        public string RequestId { get; private set; }

        public string Sentence { get; private set; }

        public MorphologicalRequest(string sentence, string requestId)
        {
            Sentence = sentence;
            RequestId = requestId;
        }

    }
}