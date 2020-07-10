using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Abp.Elasticsearch
{
    public class AbpElasticsearchModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var configuration = context.Services.GetConfiguration();

            Configure<ElasticsearchOptions>(configuration.GetSection("Elasticsearch"));

            context.Services.AddSingleton<IElasticsearch, AbpElasticsearch>();
        }
    }
}