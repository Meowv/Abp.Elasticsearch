using Nest;
using Volo.Abp.DependencyInjection;

namespace Abp.Elasticsearch.Elasticsearch
{
    public abstract class ElasticsearchRepositoryBase : ITransientDependency
    {
        protected IElasticsearchDatabaseProvider _databaseProvider;

        protected ElasticsearchRepositoryBase(IElasticsearchDatabaseProvider databaseProvider)
        {
            _databaseProvider = databaseProvider;
        }

        protected abstract string IndexName { get; set; }

        protected ElasticClient Client => _databaseProvider.GetClient();
    }
}