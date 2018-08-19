using Rest.Client;
using Rest.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rest
{
    public abstract class BaseTest : IDisposable
    {
        protected ApiClient Api;
        protected TestConfig Config;
        public BaseTest()
        {
            Config = TestConfig.FromFile("Config/TestConfig.json");
            Api = new ApiClient(Config.BaseUrl, Config.Token);
        }

        public void Dispose()
        {
            Api = null;
        }
    }
}
