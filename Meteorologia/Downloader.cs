using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;


namespace Meteorologia
{
    class Downloader
    {
        string path = "informação.txt";
        private HttpClient client;

        public Downloader()
        {
            client = new HttpClient();
        }

        public async Task<Geral> Get(string uri, JsonParser js)
        {
            Stream response = await client.GetStreamAsync(uri);
            response.Position = 0;
            await response.CopyToAsync(File.Create(path));
            response.Position = 0;
            return js.Parse(response);
            
        }
    }
}
