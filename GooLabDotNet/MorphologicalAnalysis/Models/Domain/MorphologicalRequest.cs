using System.Collections.Generic;
using GooLabDotNet.MorphologicalAnalysis.Models.Enums;

namespace GooLabDotNet.MorphologicalAnalysis.Models.Domain
{
    public class MorphologicalRequest
    {
        public string RequestId { get; private set; }

        public string Sentence { get; private set; }
        public IEnumerable<MorphemeField> InfoToInclude { get; private set; }
        public IEnumerable<PartOfSpeech> PartsToFilterOn { get; private set; }

        public MorphologicalRequest(string sentence, IEnumerable<MorphemeField> infoToInclude, IEnumerable<PartOfSpeech> partsToFilterOn, string requestId)
        {
            Sentence = sentence;
            InfoToInclude = infoToInclude;
            PartsToFilterOn = partsToFilterOn;
            RequestId = requestId;
        }

    }
}