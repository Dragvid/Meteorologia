using Metreoligia;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meteorologia
{
    public class JsonParser
    {
        public Geral Parse(Stream payload)
        {
            JsonReader reader = new JsonTextReader(new StreamReader(payload));
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.NullValueHandling = NullValueHandling.Ignore;
            JsonSerializer serializer = JsonSerializer.Create(settings);
            return serializer.Deserialize <Geral> (reader);
        }
        /*static public IDictionary<string, List<Cities>> Parsec(string path)
        {
            string parsed = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<IDictionary<string, List<Cities>>>(parsed);
        }*/
    }
}
