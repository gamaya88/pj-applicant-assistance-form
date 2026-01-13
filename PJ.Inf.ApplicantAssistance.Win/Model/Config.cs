using Newtonsoft.Json;

namespace PJ.Inf.ApplicantAssistance.Win.Model
{
    internal class Config
    {
        [JsonProperty("ConnectionString")]
        public string ConnectionString { get; set; }

        [JsonProperty("User")]
        public string User { get; set; }
    }
}
