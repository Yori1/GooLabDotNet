using System.Collections.Generic;
using GooLabDotNet.MorphologicalAnalysis.Models.Enums;

namespace GooLabDotNet.MorphologicalAnalysis.Models.Domain {
    public class MorphologicalResult {
        public string RequestId { get; private set; }
        public List<Sentence> Sentences { get; private set; }


    }
}