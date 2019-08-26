using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using GooLabDotNet.MorphologicalAnalysis.Models.Domain;

[assembly:InternalsVisibleTo("GooLabDotNet.Test")]
namespace GooLabDotNet.MorphologicalAnalysis.Logic
{
    internal interface IMorphologicalAnalysisService
    {
        Task<MorphologicalResult> GetResults(MorphologicalRequest request, string specifiedKey = null);
    }
}
