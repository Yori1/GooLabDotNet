using GooLabDotNet.MorphologicalAnalysis.Models.Enums;

namespace GooLabDotNet.MorphologicalAnalysis.Models.Domain
{
    public class Morpheme
    {
        public string Kanji { get; private set; }
        public string KatakanaReading { get; private set; }
        public PartOfSpeech PartOfSpeech { get; private set; }
        public Morpheme(string kanji, string katakanaReading, PartOfSpeech partOfSpeech)
        {
            Kanji = kanji;
            KatakanaReading = katakanaReading;
            PartOfSpeech = partOfSpeech;
        }
    }
}