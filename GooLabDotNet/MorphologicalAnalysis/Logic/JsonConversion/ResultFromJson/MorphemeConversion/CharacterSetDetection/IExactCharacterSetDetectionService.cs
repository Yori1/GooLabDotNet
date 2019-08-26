using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

[assembly: InternalsVisibleTo("GooLabDotNet.Test")]
namespace GooLabDotNet.MorphologicalAnalysis.Logic.JsonConversion.MorphemeConversion.CharacterSetDetection
{
    internal interface IExactCharacterSetDetectionService
    {
        bool IsExactlyKanji(char symbol);
         bool IsExactlyHiragana(char symbol);
         bool IsExactlyKatakana(char symbol);
    }
}
