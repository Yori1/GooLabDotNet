using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GooLabDotNet.MorphologicalAnalysis.Logic.JsonConversion.CharacterSetDetection;
using GooLabDotNet.MorphologicalAnalysis.Models.Domain;
using GooLabDotNet.MorphologicalAnalysis.Models.Enums;

[assembly : InternalsVisibleTo ("GooLabDotNet.Test")]
namespace GooLabDotNet.MorphologicalAnalysis.Logic.JsonConversion.MorphemeConversion {
    internal class MorphemeConversionService: IMorphemeConversionService {

        private FieldConversionService fieldConversionService;
        private KatakanaRecognitionService katakanaRecognitionService;
        private PartOfSpeechDetectionService partOfSpeechDetectionService;

        public MorphemeConversionService (FieldConversionService fieldConversionService, KatakanaRecognitionService katakanaRecognitionService, PartOfSpeechDetectionService partOfSpeechDetectionService) {
            this.fieldConversionService = fieldConversionService;
            this.katakanaRecognitionService = katakanaRecognitionService;
            this.partOfSpeechDetectionService = partOfSpeechDetectionService;
        }

        public Morpheme ConvertToMorpheme (List<string> morphemeJsonArray) {
            string kanji = "";
            string katakana = "";
            PartOfSpeech partOfSpeech = PartOfSpeech.NotRecognized;

            foreach (string str in morphemeJsonArray) {
                if (katakanaRecognitionService.IsSentenceWrittenInKatakana (str)) {
                    katakana = str;
                } else {
                    PartOfSpeech partOfSpeechDetected = partOfSpeechDetectionService.DetectPartOfSpeech (str);
                    if (partOfSpeechDetected != PartOfSpeech.NotRecognized) {
                        partOfSpeech = partOfSpeechDetected;
                    } else {
                        kanji = str;
                    }
                }
            }

            return new Morpheme (kanji, katakana, partOfSpeech);
        }
    }
}