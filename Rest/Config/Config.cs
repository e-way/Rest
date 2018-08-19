using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Rest.Config
{
    public class TestConfig
    {
        public string BaseUrl { get; set; }
        public string Token { get; set; }

        public static TestConfig FromFile(string file)
        {
            return JsonConvert.DeserializeObject<TestConfig>(File.ReadAllText(file));
        }
    }
}
