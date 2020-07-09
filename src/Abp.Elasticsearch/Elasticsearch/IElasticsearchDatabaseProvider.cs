using Nest;

namespace Abp.Elasticsearch.Elasticsearch
{
    public interface IElasticsearchDatabaseProvider
    {
        ElasticClient GetClient();
    }
}