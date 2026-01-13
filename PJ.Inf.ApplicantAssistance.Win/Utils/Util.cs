using Newtonsoft.Json;
using PJ.Inf.ApplicantAssistance.Win.Model;

namespace PJ.Inf.ApplicantAssistance.Win.Utils
{
    internal class Util
    {
        static string JsonConfigPath = "config.json";

        public static Config LoadConfig()
        {
            try
            {
                string json = System.IO.File.ReadAllText(JsonConfigPath);
                return JsonConvert.DeserializeObject<Config>(json);
            }
            catch (Exception ex)
            {
                return new Config(); // Devuelve una configuración vacía para evitar errores
            }
        }
    }
}
