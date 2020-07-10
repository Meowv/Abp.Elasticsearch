using System.Collections.Generic;

namespace Abp.Elasticsearch
{
    public class ElasticsearchOptions
    {
        public List<string> Nodes { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}