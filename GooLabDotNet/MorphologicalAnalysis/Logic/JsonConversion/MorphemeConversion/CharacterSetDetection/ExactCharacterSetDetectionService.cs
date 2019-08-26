using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("GooLabDotNet.Test")]
namespace GooLabDotNet.MorphologicalAnalysis.Logic.JsonConversion.CharacterSetDetection
{
    internal class ExactCharacterSetDetectionService
    {
        private const int kanjiRangeMin = 0x4e00;
        private const int kanjiRangeMax = 0x9faf;
        private const int hiraganaMin = 0x3040;
        private const int hiraganaMax = 0x309F;
        private const int katakanaRangeMin = 0x30A0;
        private const int katakanaRangeMax = 0x30FF;

        public bool IsExactlyKanji(char symbol)
        {
            return (symbol >= kanjiRangeMin && symbol <= kanjiRangeMax);
        }

        public bool IsExactlyHiragana(char symbol)
        {
            return (symbol >= hiraganaMin && symbol <= hiraganaMax);
        }

        public bool IsExactlyKatakana(char symbol) 
        {
           return (symbol >= katakanaRangeMin && symbol <= katakanaRangeMax);
 
        }
    }
}