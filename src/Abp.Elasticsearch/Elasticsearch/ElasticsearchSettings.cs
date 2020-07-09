using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.IO;

namespace Abp.Elasticsearch.Elasticsearch
{
    public class ElasticsearchSettings : IElasticsearchSettings
    {
        public ElasticsearchSettings()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                                                    .AddJsonFile("appsettings.json", true, true);
            IConfigurationRoot configuration = builder.Build();

            var esNodes = configuration.GetSection("nodes").GetChildren();

            Nodes = new List<string>();
            foreach (var item in esNodes)
            {
                Nodes.Add(item.Value);
            }
        }

        public IList<string> Nodes { get; set; }
    }
}