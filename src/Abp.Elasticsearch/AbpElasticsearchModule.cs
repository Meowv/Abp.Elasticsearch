using Abp.Elasticsearch.Elasticsearch;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Abp.Elasticsearch
{
    public class AbpElasticsearchModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddSingleton<IElasticsearchSettings, ElasticsearchSettings>();
            context.Services.AddSingleton<IElasticsearchDatabaseProvider, ElasticsearchDatabaseProvider>();
        }
    }
}