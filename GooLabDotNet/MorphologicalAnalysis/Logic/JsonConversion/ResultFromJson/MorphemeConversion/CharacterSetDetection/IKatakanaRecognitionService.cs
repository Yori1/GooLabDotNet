using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

[assembly:InternalsVisibleTo("GooLabDotNet.Test")]
namespace GooLabDotNet.MorphologicalAnalysis.Logic.JsonConversion.MorphemeConversion.CharacterSetDetection
{
    internal interface IKatakanaRecognitionService
    {
         bool IsSentenceWrittenInKatakana(string text);
    }
}
