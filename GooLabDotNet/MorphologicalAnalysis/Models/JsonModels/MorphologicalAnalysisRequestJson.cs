using Newtonsoft.Json;

namespace GooLabDotNet.MorphologicalAnalysis.Models.JsonModels {
    public class MorphologicalAnalysisRequestJson {

        [JsonProperty("app_id")]
        public string app_id { get; private set; }

        [JsonProperty("request_id")]
        public string request_id { get; private set; }

        [JsonProperty("sentence")]
        public string sentence { get; private set; }

        [JsonProperty("info_filter")]
        public string info_filter { get; private set; }

        [JsonProperty("pos_filter")]
        public string pos_filter { get; private set; } 
        public MorphologicalAnalysisRequestJson (string app_id, string request_id, string sentence, string info_filter, string pos_filter) {
            this.app_id = app_id;
            this.request_id = request_id;
            this.sentence = sentence;
            this.info_filter = info_filter;
            this.pos_filter = pos_filter;
        }

    }
}