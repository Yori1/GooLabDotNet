using System.Runtime.CompilerServices;
using GooLabDotNet.MorphologicalAnalysis.Logic.JsonConversion.MorphemeConversion.CharacterSetDetection;

[assembly: InternalsVisibleTo("GooLabDotNet.Test")]
namespace GooLabDotNet.MorphologicalAnalysis.Logic.JsonConversion.CharacterSetDetection
{
    internal class KatakanaRecognitionService : IKatakanaRecognitionService
    {
        private const int katakanaRangeMin = 0x30A0;
        private const int katakanaRangeMax = 0x30FF;

        private ExactCharacterSetDetectionService exactCharacterSetDetectionService;

        public KatakanaRecognitionService(ExactCharacterSetDetectionService exactCharacterSetDetectionService)
        {
            this.exactCharacterSetDetectionService = exactCharacterSetDetectionService;
        }

        public bool IsSentenceWrittenInKatakana(string text)
        {
            char[] chars = text.ToCharArray();
            bool isKatakana = true;

            for (int x = 0; x < chars.Length && isKatakana; x++)
            {
                char symbol = chars[x];
                isKatakana = IsCharacterThatCanBeInAKatakanaSentence(symbol);
            }
            return isKatakana;
        }

        private bool IsCharacterThatCanBeInAKatakanaSentence(char character)
        {
            bool canBeInSentence = true;

            if (!exactCharacterSetDetectionService.IsExactlyKatakana(character))
            {
                bool hiragana = exactCharacterSetDetectionService.IsExactlyHiragana(character);
                bool kanji = exactCharacterSetDetectionService.IsExactlyKanji(character);
                canBeInSentence = !hiragana && !kanji;
            }

            return canBeInSentence;
        }
    }
}