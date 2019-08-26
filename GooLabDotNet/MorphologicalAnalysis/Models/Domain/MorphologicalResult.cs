using System.Collections.Generic;
using System.Net;
using GooLabDotNet.MorphologicalAnalysis.Models.Enums;

namespace GooLabDotNet.MorphologicalAnalysis.Models.Domain {
    public class MorphologicalResult {
        public string RequestId { get; private set; }
        public List<Sentence> Sentences { get; private set; }

        public HttpStatusCode HttpStatusCode { get; private set; }


        public MorphologicalResult(string requestId, List<Sentence> sentences, HttpStatusCode httpStatusCode)
        {
            RequestId = requestId;
            Sentences = sentences;
            HttpStatusCode = httpStatusCode;
        }
    }
}