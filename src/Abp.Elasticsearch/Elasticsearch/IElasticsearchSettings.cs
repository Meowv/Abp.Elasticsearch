using System.Collections.Generic;

namespace Abp.Elasticsearch.Elasticsearch
{
    public interface IElasticsearchSettings
    {
        IList<string> Nodes { get; set; }
    }
}