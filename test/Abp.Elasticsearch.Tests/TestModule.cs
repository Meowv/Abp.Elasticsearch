using Volo.Abp.Modularity;

namespace Abp.Elasticsearch.Tests
{
    [DependsOn(typeof(AbpElasticsearchModule))]
    public class TestModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<ElasticsearchOptions>(options =>
            {
                options.Nodes = new System.Collections.Generic.List<string> { "http://127.0.0.1:9200" };
            });
        }
    }
}