using System.Runtime.InteropServices.ComTypes;
using System.Runtime.CompilerServices;
using GooLabDotNet.MorphologicalAnalysis.Models.Enums;

[assembly:InternalsVisibleTo("GooLabDotNet.Test")]
namespace GooLabDotNet.MorphologicalAnalysis.Logic.MorphemeFieldConversion
{
    internal class PartOfSpeechDetectionService
    {
        public PartOfSpeech DetectPartOfSpeech(string jsonPartOfSpeech) {
            PartOfSpeech result = PartOfSpeech.NotRecognized;
            switch(jsonPartOfSpeech) {
                case "格助詞":
                 result = PartOfSpeech.CaseMarkingParticle;
                 break;

                case "終動詞":
                 result = PartOfSpeech.SentenceEndingParticle;
                 break;

                case "動詞接尾辞":
                 result = PartOfSpeech.VerbSuffix;
                 break;
            }

            return result;
        }
    }
}