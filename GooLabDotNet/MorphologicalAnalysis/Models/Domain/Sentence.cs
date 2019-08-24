using System.Collections.Generic;

namespace GooLabDotNet.MorphologicalAnalysis.Models.Domain
{
    public class Sentence
    {
        public List<Morpheme> Morphemes { get; private set; }
        public Sentence(List<Morpheme> morphemes)
        {
            Morphemes = morphemes;
        }
    }
}